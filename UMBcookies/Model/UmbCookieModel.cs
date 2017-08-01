using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco_Cookies.App_Plugins.UMBcookies.Model
{
    public class UmbCookieModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("dismiss")]
        public string Dismiss { get; set; }
        [JsonProperty("policy")]
        public string Policy { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("layout")]
        public string Layout { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("buttonBackground")]
        public string ButtonBackground { get; set; }
        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }
        [JsonProperty("popupBackground")]
        public string PopupBackground { get; set; }
        [JsonProperty("popupText")]
        public string PopupText { get; set; }
    }
}