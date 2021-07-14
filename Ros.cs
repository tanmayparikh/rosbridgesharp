using Newtonsoft.Json.Linq;
using Rosbridgenet.Protocols;
using System;
using System.Collections.Generic;

namespace Rosbridgenet
{
    public class Ros
    {
        public IProtocol Protocol { get; private set; }

        private Dictionary<string, Topic> _subscribedTopics = new Dictionary<string, Topic>();
        private Dictionary<string, Service> _pendingServices = new Dictionary<string, Service>();

        public Ros(IProtocol protocol)
        {
            if (protocol == null)
                throw new ArgumentNullException("Protocol argument cannot be null");

            Protocol = protocol;
            Protocol.OnReceive += Receive;
            Protocol.Connect();
        }

        public void Subscribe<Tmsg>(Topic<Tmsg> topic, string type = "") where Tmsg : Message
        {
            if (topic == null)
                throw new ArgumentNullException("Topic to subscribe to cannot be null");

            _subscribedTopics.Add(topic.Id, topic);

            Protocol?.Send(topic.BuildSubscriptionMsg(type));
        }

        public void Unsubscribe<Tmsg>(Topic<Tmsg> topic) where Tmsg : Message
        {
            if (topic == null)
                throw new ArgumentNullException("Topic to unsubscribe to cannot be null");

            if (_subscribedTopics.ContainsKey(topic.Id))
                _subscribedTopics.Remove(topic.Id);

            Protocol?.Send(topic.BuildUnsubscriptionMsg());
        }

        public string CallService<Targ, Tresp>(Service<Targ, Tresp> service, Targ args) where Targ : Message where Tresp : Message
        {
            if (service == null)
                throw new ArgumentNullException("Service argument cannot be null");

            string callId = "";
            do
            {
                callId = Utils.GenerateRandomString();
            }
            while (_pendingServices.ContainsKey(callId));
            _pendingServices.Add(callId, service);
            
            Protocol?.Send(service.BuildServiceCallMsg(callId, args));

            return callId;
        }

        public string CallService<Targ, Tresp>(Service<Targ, Tresp> service, Service<Targ, Tresp>.ServiceCall serviceCall) where Targ : Message where Tresp : Message
        {
            if (service == null)
                throw new ArgumentNullException("Service argument cannot be null");

            if (serviceCall == null)
                throw new ArgumentNullException("Service call argument cannot be null");

            var callId = Utils.GenerateRandomString();
            _pendingServices.Add(callId, service);
            Protocol?.Send(service.BuildServiceCallMsg(serviceCall));

            return callId;
        }

        private void Receive(object sender, RosMessageEventArgs e)
        {
            var receivedMsg = e.DataStr;
            var jsonMsg = JObject.Parse(receivedMsg);

            if (jsonMsg == null)
                return;

            switch (jsonMsg.GetValue(RosBridge.FieldOp).ToString())
            {
                case RosBridge.OpServiceResponse:
                    {
                        var id = jsonMsg.GetValue(RosBridge.FieldId).ToString();
                        if (_pendingServices.ContainsKey(id))
                        {
                            var service = _pendingServices[id];
                            service?.HandleServiceCallResponse(receivedMsg);
                            _pendingServices.Remove(id);
                        }
                        return;
                    }

                case RosBridge.OpPublish:
                    {
                        var topicName = jsonMsg.GetValue(RosBridge.FieldTopic).ToString();
                        
                        foreach (var subbedTopic in _subscribedTopics)
                        {
                            if (subbedTopic.Value.TopicName == topicName)
                                subbedTopic.Value?.HandlePublication(receivedMsg);
                        }

                        return;
                    }
            }
        }
    }
}
