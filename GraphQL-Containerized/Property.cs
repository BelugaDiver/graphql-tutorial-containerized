using Newtonsoft.Json;

namespace GraphQL_Containerized
{
    /// <summary>
    /// The Property class is a data structure describing an Optimizely property.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
