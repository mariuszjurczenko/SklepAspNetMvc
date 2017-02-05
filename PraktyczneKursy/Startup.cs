using Hangfire;
using Owin;

namespace PraktyczneKursy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            GlobalConfiguration.Configuration.UseSqlServerStorage("KursyContext");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}