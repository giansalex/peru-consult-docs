using System.Net;
using Newtonsoft.Json;

var dni = "00000001";
var token = "YOUR-TOKEN";

using (WebClient wc = new WebClient())
{
   var json = wc.DownloadString("http://consulta.pe/api/v1/dni/"+dni+"?token="+token);
   var person = JObject.Parse(json);
}