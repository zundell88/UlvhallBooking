using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UlvhallBooking.Startup))]
namespace UlvhallBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
