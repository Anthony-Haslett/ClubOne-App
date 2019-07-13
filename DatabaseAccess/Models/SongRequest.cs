namespace todo.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;

    public class SongRequest
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}