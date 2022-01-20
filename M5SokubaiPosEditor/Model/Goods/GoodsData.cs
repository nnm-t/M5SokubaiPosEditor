using System.Collections.Generic;
using Newtonsoft.Json;

namespace M5SokubaiPosEditor;

public class GoodsData
{
    [JsonProperty(PropertyName = "goods")]
    public List<GoodsItem> Goods { get; set; }

    public GoodsData()
    {
        Goods = new List<GoodsItem>();
    }

    public static GoodsData? Deserialize(string jsonString)
    {
        return JsonConvert.DeserializeObject<GoodsData>(jsonString);
    }

    public string Serialize()
    {
        return JsonConvert.SerializeObject(this);
    }
}