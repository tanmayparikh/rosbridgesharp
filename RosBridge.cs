namespace Rosbridgenet
{
    public class RosBridge
    {
        public const string FieldArgs = "args";
        public const string FieldClient = "client";
        public const string FieldCompression = "compression";
        public const string FieldData = "data";
        public const string FieldDestination = "destination";
        public const string FieldEndTime = "end";
        public const string FieldFragmentSize = "fragment_size";
        public const string FieldId = "id";
        public const string FieldLevel = "level";
        public const string FieldMac = "mac";
        public const string FieldMessage = "msg";
        public const string FieldOp = "op";
        public const string FieldQueueLength = "queue_length";
        public const string FieldRand = "rand";
        public const string FieldResult = "result";
        public const string FieldService = "service";
        public const string FieldThrottleRate = "throttle_rate";
        public const string FieldTime = "t";
        public const string FieldTopic = "topic";
        public const string FieldType = "type";
        public const string FieldValues = "values";
        public const string OpAdvertise = "advertise";
        public const string OpAdvertiseService = "advertise_service";
        public const string OpUnadvertiseService = "unadvertise_service";
        public const string OpAuth = "auth";
        public const string OpCallService = "call_service";
        public const string OpPng = "png";
	    public const string OpPublish = "publish";
        public const string OpServiceResponse = "service_response";
	    public const string OpSubscribe = "subscribe";
	    public const string OpUnadvertise = "unadvertise";
	    public const string OpUnsubscribe = "unsubscribe";

        public static class CompressionType
        {
            public const string NONE = "none";
            public const string PNG = "png";
        }
    }
}
