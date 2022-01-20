using System.Collections.Generic;
using Newtonsoft.Json;

namespace M5SokubaiPosEditor;

public class GoodsItem
{
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    
    [JsonProperty(PropertyName = "image_path")]
    public string ImagePath { get; set; }
    
    [JsonProperty(PropertyName = "price")]
    public int Price { get; set; }
    
    [JsonProperty(PropertyName = "uuid")]
    public List<byte> Uuid { get; set; }
}