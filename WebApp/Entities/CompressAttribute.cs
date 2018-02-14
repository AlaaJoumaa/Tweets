using System.IO.Compression;
using System.Web.Mvc;

namespace WebApp.Entities
{
  public class CompressAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {
      string acceptEncoding = filterContext.HttpContext.Request.Headers["Accept-Encoding"];
      if (!string.IsNullOrEmpty(acceptEncoding))
      {
        var response = filterContext.HttpContext.Response;
        acceptEncoding = acceptEncoding.ToLower();
        if (acceptEncoding.Contains("gzip"))
        {
          response.AppendHeader("Content-Encoding", "gzip");
          response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
        }
        else if (acceptEncoding.Contains("deflate"))
        {
          response.AppendHeader("Content-Encoding", "deflate");
          response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
        }
      }
      base.OnActionExecuted(filterContext);
    }
  }
}