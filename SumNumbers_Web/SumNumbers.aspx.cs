using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumNumbers_Web
{
    public partial class SumNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            SumBumbers_BLL.SumBumbers_BLL bll = new SumBumbers_BLL.SumBumbers_BLL();
            Response.Write( bll.SumNumbers(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)));
        }
    }
}