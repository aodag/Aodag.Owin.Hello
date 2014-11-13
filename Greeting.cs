using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Aodag.Owin.Hello
{
  public class Greeting
  {
    const string text = "Hello";
    public static async Task Invoke(IDictionary<string, object> env)
    {
      var message = Encoding.UTF8.GetBytes(text);
      var response = env["owin.ResponseBody"] as Stream;
      await response.WriteAsync(message, 0, message.Length);
    }
  }
}