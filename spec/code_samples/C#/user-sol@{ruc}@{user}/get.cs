using System.Net;
using Newtonsoft.Json;

var ruc  = "20000000001";
var user = "MODDATOS";
var token = "YOUR-TOKEN";

using (WebClient wc = new WebClient())
{
   var json = wc.DownloadString($"http://consulta.pe/api/v1/user-sol/{ruc}/{user}?token={token}");
   var isValid = JObject.Parse(json);
}