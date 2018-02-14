using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WebApp.Entities
{

  public class Twitter
  {
    private string ConsumerSecret { get; set; }
    private string ConsumerKey { get; set; }

    public Twitter(string consumerKey,string consumerSecret)
    {
      ConsumerKey = consumerKey;
      ConsumerSecret = consumerSecret;
    }

    private WebResponse GetWebResponse(string oAuthConsumerKey, string oAuthConsumerSecret,string oAuthUrl= "https://api.twitter.com/oauth2/token")
    {
      var authHeader = string.Format("Basic {0}", Convert.ToBase64String(Encoding.UTF8.GetBytes(
          Uri.EscapeDataString(oAuthConsumerKey) + ":" +  Uri.EscapeDataString((oAuthConsumerSecret)))
      ));
      HttpWebRequest oAuthRequest = (HttpWebRequest)WebRequest.Create(oAuthUrl);
      oAuthRequest.Headers.Add("Authorization", authHeader);
      oAuthRequest.Method = "POST";
      oAuthRequest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
      oAuthRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
      using (Stream stream = oAuthRequest.GetRequestStream())
      {
        byte[] content = ASCIIEncoding.ASCII.GetBytes("grant_type=client_credentials");
        stream.Write(content, 0, content.Length);
      }
      oAuthRequest.Headers.Add("Accept-Encoding", "gzip");
      return oAuthRequest.GetResponse();
    }

    private string GetJsonResult(WebResponse oauthResponse, string apiUri)
    {
      TwitterAuthenticate twitoAuthResponse;
      using (var reader = new StreamReader(oauthResponse.GetResponseStream()))
      {
        var jsonText = reader.ReadToEnd();
        twitoAuthResponse = JsonConvert.DeserializeObject<TwitterAuthenticate>(jsonText);
      }
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUri);
      var headerFormat = "{0} {1}";
      request.Headers.Add("Authorization", string.Format(headerFormat, twitoAuthResponse.token_type, twitoAuthResponse.access_token));
      request.Method = "Get";
      using (WebResponse apiResponse = request.GetResponse())
      {
        var reader = new StreamReader(apiResponse.GetResponseStream());
        var jsonResult = reader.ReadToEnd();
        return jsonResult;
      }
    }

    public TwitteSearchResult TextSearch(string text,string nextResults="")
    {
      WebResponse webResponse = GetWebResponse(ConsumerKey, ConsumerSecret);
      //geocode=41.018247,29.00528,1000000mi&
      string param = (string.IsNullOrEmpty(nextResults) ? $"?count=15&q={text}" : nextResults);
      string jsonResult = GetJsonResult(webResponse, "https://api.twitter.com/1.1/search/tweets.json?" + param);
      return JsonConvert.DeserializeObject<TwitteSearchResult>(jsonResult);
    }
  }
}
