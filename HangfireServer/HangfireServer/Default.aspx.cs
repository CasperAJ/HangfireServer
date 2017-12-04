using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Owin;
using Hangfire;
using Hangfire.MySql;

namespace HangfireServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(""));

            app.UseHangfireServer();
            //using (var server = new BackgroundJobServer())
            //{
            //    Console.WriteLine("Hangfire Server started. Press any key to exit...");
            //    Console.ReadKey();
            //}
        }
    }


    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}