using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MikeCIDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = TestFunktion().ToString() + " updated time:" + System.DateTime.Now.ToString();
        }
        public static int TestFunktion()
        {
            return 40;
        }
    }
}