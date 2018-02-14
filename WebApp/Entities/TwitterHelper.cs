using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApp.Entities
{
  public static class TwitterHelper
  {

    public static DateTime ConvertToDate(string twitterDate)
    {
      //string date = "Thu Feb 08 18:29:59 +0000 2018";
      string datePat = @"[0-9]+:[0-9]+:[0-9]+\s+\D\d+\s+";
      ////////DATE////////
      Regex rgx = new Regex(datePat);
      string dateStr = rgx.Replace(twitterDate, "");
      DateTime dt = Convert.ToDateTime(dateStr);
      ////////////////////
      ////////TIME////////
      string time1Pat = @"\w+\s\w+\s[0-9]+\s";
      rgx = new Regex(time1Pat);
      string timeStr = rgx.Replace(twitterDate, "");
      string time2Pat = @"\s\D[0-9]+\s[0-9]+";
      rgx = new Regex(time2Pat);
      timeStr = rgx.Replace(timeStr, "");
      TimeSpan ts = TimeSpan.Parse(timeStr);
      ////////////////////
      DateTime result = new DateTime(dt.Year, dt.Month, dt.Day, ts.Hours, ts.Minutes, ts.Seconds);
      return result;
    }
  }
}