using Newtonsoft.Json;
using System.ComponentModel;

namespace Rosbridgenet
{
    public abstract class Topic
    {
        public abstract string Id { get; }
        public abstract string TopicName { get; }

        public abstract bool HandlePublication(string jsonData);
    }
    public class Topic<Tmsg> : Topic where Tmsg : Message
    {
        public delegate void TopicPublicationHandler(Tmsg data);

        public override string Id { get; }
        public override string TopicName { get; }

        public TopicPublicationHandler PulbicationHandler { get; set; }

        public Topic(string topicName)
        {
            Id = Utils.GenerateRandomString();
            TopicName = topicName;
        }

        public Topic(string id, string topicName)
        {
            Id = id;
            TopicName = topicName;
        }

        public Topic(string topicName, TopicPublicationHandler publicationHandler)
        {
            Id = Utils.GenerateRandomString();
            TopicName = topicName;
            PulbicationHandler = publicationHandler;
        }

        public string BuildSubscriptionMsg(string type = "")
        {
            var subscription = new Subscription(Id, TopicName)
            {
                Type = type
            };
            var serializerSettings = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore };
            return JsonConvert.SerializeObject(subscription, serializerSettings);
        }

        public string BuildUnsubscriptionMsg()
        {
            var unsubscription = new Unsubscription(TopicName);

            return JsonConvert.SerializeObject(unsubscription);
        }

        public override bool HandlePublication(string jsonData)
        {
            var topicMsg = JsonConvert.DeserializeObject<Publication>(jsonData);

            if (topicMsg == null)
                return false;

            PulbicationHandler?.Invoke(topicMsg.Message);

            return true;
        }

        public class Subscription : ICommData
        {
            [JsonProperty(RosBridge.FieldOp)]
            public string Operation { get; set; }

            [JsonProperty(RosBridge.FieldId)]
            public string Id { get; set; }

            [JsonProperty(RosBridge.FieldTopic)]
            public string Topic { get; set; }

            [DefaultValue("")]
            [JsonProperty(RosBridge.FieldType)]
            public string Type { get; set; }

            [JsonProperty(RosBridge.FieldThrottleRate)]
            public int ThrottleRate { get; set; }

            [JsonProperty(RosBridge.FieldQueueLength)]
            public int QueueLength { get; set; }

            [JsonProperty(RosBridge.FieldFragmentSize)]
            public int FragmentSize { get; set; }

            [JsonProperty(RosBridge.FieldCompression)]
            public string Compression { get; set; }

            public Subscription(
                string id,
                string topic,
                string type = "",
                int throttleRate = 0,
                int queueLength = 1,
                int fragmentSize = int.MaxValue,
                string compression = RosBridge.CompressionType.NONE)
            {
                Operation = RosBridge.OpSubscribe;
                Id = id;
                Topic = topic;
                Type = type;
                ThrottleRate = throttleRate;
                QueueLength = queueLength;
                FragmentSize = fragmentSize;
                Compression = compression;
            }
        }

        public class Unsubscription : ICommData
        {
            [JsonProperty(RosBridge.FieldOp)]
            public string Operation { get; set; }

            [JsonProperty(RosBridge.FieldTopic)]
            public string Topic { get; set; }

            public Unsubscription(string topic)
            {
                Operation = RosBridge.OpUnsubscribe;
                Topic = topic;
            }
        }

        public class Publication : ICommData
        {
            [JsonProperty(RosBridge.FieldOp)]
            public string Operation { get; set; }

            [JsonProperty(RosBridge.FieldId)]
            public string Id { get; set; }

            [JsonProperty(RosBridge.FieldTopic)]
            public string Topic { get; set; }

            [JsonProperty(RosBridge.FieldMessage)]
            public Tmsg Message { get; set; }

            public Publication(string id, string topic, Tmsg message)
            {
                Operation = RosBridge.OpPublish;
                Id = id;
                Topic = topic;  
                Message = message;
            }
        }
    }
}
