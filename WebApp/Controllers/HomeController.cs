using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Entities;

namespace WebApp.Controllers
{
  [CompressAttribute]
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    private void InitSessions()
    {
      Session["NextResults"] = "";
      Session["SearchText"] = "";
    }

    [HttpPost]
    public ActionResult GetTwittes(string searchText="Istanbul")
    {
      try
      {
        if(Session["SearchText"] == null)
        {
          InitSessions();
        }
        string lastSearchText = Session["SearchText"].ToString();
        if (Session["NextResults"] == null)
        {
          Session["NextResults"] = "";
          if (lastSearchText.Trim() == searchText.Trim())
          {
            var emptyData = new
            {
              Result = "",
              Success = false,
              NewPage = false
            };
            return Json(emptyData);
          }
        }
        string consumerKey = ConfigurationManager.AppSettings["oAuthConsumerKey"];
        string consumerSecret = ConfigurationManager.AppSettings["oAuthConsumerSecret"];
        string nextResults = Session["NextResults"].ToString();
        nextResults = ( (lastSearchText.Trim() == searchText.Trim()) ? nextResults : "" );
        Twitter twitter = new Twitter(consumerKey,consumerSecret);
        TwitteSearchResult result = twitter.TextSearch(searchText, nextResults);
        result = TwitteSearchResult.FormatModel(result);//Foramt the model.
        var newPage = searchText.Trim() == lastSearchText.Trim();
        Session["NextResults"] = result.SearchMetadata.NextResults;
        Session["SearchText"] = searchText;
        var jsonData = new
        {
          Result = result,
          Success = true,
          NewPage = newPage
        };
        return Json(jsonData);
      }
      catch(Exception ex)
      {
        return Json(new
        {
          Result = ex.StackTrace,
          Success = false,
          NewData = false
        });
      }
    }

  }
}