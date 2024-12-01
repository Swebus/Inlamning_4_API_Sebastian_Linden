using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inlamning_4_API
{
    internal class Repo
    {
        [property: JsonPropertyName("name")]
        public string Name { get; set; }

        [property: JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [property: JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [property: JsonPropertyName("description")]
        public string Description { get; set; }

        [property: JsonPropertyName("watchers_count")]
        public int Watchers { get; set; }
        
        [property: JsonPropertyName("pushed_at")]
        public DateTime PushedAt { get; set; }

        public override string ToString()
        {
            return $"Name:{this.Name} \n Homepage:{this.Homepage} \n GitHub:{this.HtmlUrl} \n Description:{this.Description} \n Watchers:{this.Watchers} \n Latest Push:{this.PushedAt}";
        }

    }
}
