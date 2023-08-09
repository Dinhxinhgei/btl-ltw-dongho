using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                //login.InnerHtml = "<p class='user' style='color:white'>Xin chào " + Session["username"].ToString() + " | " + "</p>";
                dnSession.InnerHtml = "<a href = 'logout.aspx'> ĐĂNG XUẤT </a>";
                
                int countCart = 0;
                List<Cart> CartList = (List<Cart>)Application["CartList"];
                foreach (Cart cart in CartList)
                {
                    if(cart.Username == (string)Session["username"])
                    {
                        countCart += cart.Quantity;

                    }
                }
                cartCount.InnerHtml = $"{countCart}";
                
            }
        }
    }
}