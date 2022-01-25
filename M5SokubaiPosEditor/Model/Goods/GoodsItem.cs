using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Prism.Mvvm;

namespace M5SokubaiPosEditor;

public class GoodsItem : BindableBase
{
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    
    [JsonProperty(PropertyName = "image_path")]
    public string ImagePath { get; set; }
    
    [JsonProperty(PropertyName = "price")]
    public int Price { get; set; }
    
    [JsonProperty(PropertyName = "uuid")]
    public ObservableCollection<byte> Uuid { get; set; }
}