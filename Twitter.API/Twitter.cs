using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Script.Serialization;

namespace WebApp.Entities
{
  public class Twitter
  {
    public async Task<string> GetAccessToken()
    {
      var httpClient = new HttpClient();
      var OAuthConsumerKey = "TzCdOEUhB2d0tSB0u1fIHJkpH";
      var OAuthConsumerSecret = "wizuKJeBpHhYVhUnu8Z4sQKN1Z1DqUHWo8C93bVV7YuLOZVcBH";
      var request = new HttpRequestMessage(HttpMethod.Post, "https://api.twitter.com/oauth2/token");
      var customerInfo = Convert.ToBase64String(new UTF8Encoding()
                                .GetBytes(OAuthConsumerKey + ":" + OAuthConsumerSecret));
      request.Headers.Add("Authorization", "Basic " + customerInfo);
      request.Content = new StringContent("grant_type=client_credentials",
                                              Encoding.UTF8, "application/x-www-form-urlencoded");
      HttpResponseMessage response = await httpClient.SendAsync(request);
      string json = await response.Content.ReadAsStringAsync();
      var serializer = new JavaScriptSerializer();
      dynamic item = serializer.Deserialize<object>(json);
      return item["access_token"];
    }

    public async Task<IEnumerable<string>> GetTweets(string searchText, int count, string accessToken = null)
    {
      if (accessToken == null)
      {
        accessToken = await GetAccessToken();
      }

      var requestUserTimeline = new HttpRequestMessage(HttpMethod.Get,
      string.Format("https://api.twitter.com/1.1/search/tweets.json?q={0}",searchText));
      requestUserTimeline.Headers.Add("Authorization", "Bearer " + accessToken);
      var httpClient = new HttpClient();
      HttpResponseMessage responseUserTimeLine = await httpClient.SendAsync(requestUserTimeline);
      var serializer = new JavaScriptSerializer();
      dynamic json = serializer.Deserialize<object>(await responseUserTimeLine.Content.ReadAsStringAsync());
      var enumerableTweets = (json as IEnumerable<dynamic>);

      if (enumerableTweets == null)
      {
        return null;
      }
      return enumerableTweets.Select(t => (string)(t["text"].ToString()));
    }
  }
}
