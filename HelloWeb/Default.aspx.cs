using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// 1. Create Dynamic Controls
        /// 2. Set Master Page
        /// 3. Set the Theme
        /// </summary>
        protected void Page_PreInit(object sender,EventArgs e)
        {
            Response.Write("1. Pre Init");
        }

        /// <summary>
        /// 1.Set custom events to the controls
        /// 2.Set Properties of a control like background
        /// </summary>
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("2.  Init");
        }


        /// <summary>
        /// 1. First instance where post back data is available
        /// </summary>
        protected void Page_PreLoad(object sender, EventArgs e)
        {
             lblPostBackMessage.Text = "<br/>PAGE PRE LOAD";
        }


        /// <summary>
        /// 1. Used to load data and initialize controls
        /// 2. React to post back data
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPostBackMessage.Text += "<br />PAGE LOAD";
            //if(IsPostBack)
            //{
            //    lblPostBackMessage.Text = "Post back request";
            //}
            //else
            //{
            //    lblPostBackMessage.Text = "Newly loaded page";
            //}
        }

        protected void Page_PreRender(object sender,EventArgs e)
        {
            lblPostBackMessage.Text += "<br />PAGE PRE RENDER";
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("5. Render");
            lblPostBackMessage.Text += "<br />PAGE RENDER";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            

            lblPostBackMessage.Text += "<br />PAGE Unload";
        }

        protected void  btnChangeTheMessage_Click  (object sender, EventArgs e)
        {
            lblMessage.Text = txtSampleMessage.Text;
        }
    }
}