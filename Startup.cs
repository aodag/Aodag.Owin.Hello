using Microsoft.AspNet.Http;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Owin;
using System.Threading.Tasks;
using System.IO;


namespace MyApp
{
  public class Startup
  {
    public void Configure(IApplicationBuilder builder)
    {
      builder.UseOwin(addMiddleware => {
        addMiddleware(
          app =>
          {
            return async (env) =>
            {
              var text = "Hello";
              var message = System.Text.Encoding.UTF8.GetBytes(text);
              await Task.Run(()=> (env["owin.ResponseBody"] as Stream).Write(message, 0, message.Length));
            };
          });
      });
    }
  }
}