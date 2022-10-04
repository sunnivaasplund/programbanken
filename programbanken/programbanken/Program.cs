using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using Newtonsoft.Json;
using programbanken;
using RestSharp;

var settings = new ElasticsearchClientSettings(new Uri("https://elastic-thesearch.es.devcoretools01.k8s.sr.se"))
    .CertificateFingerprint("52:F3:A0:5E:71:20:54:23:2E:D2:D8:40:63:5E:93:E6:A2:07:F7:07:46:3B:DD:FD:0A:DF:DE:68:44:43:60:03")
    .Authentication(new BasicAuthentication("thesearch-user", "895vNaDIsSkuGJhp"));

var eclient = new ElasticsearchClient(settings);

var client = new RestClient("http://programbanken-api.stotmhweb01.sr.se/");
var request = new RestRequest("Post/GetModifiedPosts?changedAfter=2022-10-03&maxRowCount=10");

var cancellationToken = CancellationToken.None;
RestResponse response = await client.GetAsync(request, cancellationToken);

if (response.IsSuccessful)
{ 
    var episodes = JsonConvert.DeserializeObject<List<ModifiedPostInfo>>(response.Content);

    foreach (var episode in episodes)
    {
        var episdodeRequest = new RestRequest($"Post/GetPost?postHeaderId={episode.PostHeaderId}");
        var episodeResponse = await client.GetAsync<SimplerPost>(episdodeRequest, cancellationToken);
        var eresponse = await eclient.IndexAsync(episodeResponse, request => request.Index("programarchive-index"));
    }

    Console.WriteLine(response.Content);
}
