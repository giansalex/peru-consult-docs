using System.Net;
using Newtonsoft.Json;

var ruc = "20000000001";
var token = "YOUR-TOKEN";

using (WebClient wc = new WebClient())
{
   var json = wc.DownloadString("http://consulta.pe/api/v1/dni/"+ruc+"?token="+token);
   var company = JObject.Parse(json);
}