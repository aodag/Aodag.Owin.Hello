using Microsoft.AspNet.Http;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Owin;

namespace Aodag.Owin.Hello
{
  public class Startup
  {
    public void Configure(IApplicationBuilder builder)
    {
      builder.UseOwin(addMiddleware => {
        addMiddleware(
          app =>
          {
            return Greeting.Invoke;
          });
      });
    }
  }
}