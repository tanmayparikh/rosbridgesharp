using Newtonsoft.Json;

namespace Rosbridgenet
{
    public interface ICommData
    {
        [JsonProperty(RosBridge.FieldOp)]
        string Operation { get; set;}
    }
}
