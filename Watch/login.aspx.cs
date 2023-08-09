using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form.Get("username");
                string password = Request.Form.Get("password");
                int dem = 0;
                if (username != "" && password != "")
                {
                    List<User> users = (List<User>)Application["Users"];
                    List<User> admin = (List<User>)Application["Admin"];
                    foreach (User ad in admin)
                    {
                        if (username == ad.username && password == ad.password)    //login bằng tk admin để redirect sang trang admin
                        {
                            Session["username"] = username;
                            Response.Redirect("ADMIN.aspx");
                        }
                    }
                    foreach (User user in users)
                    {
                        if (username == user.username)
                        {
                            dem = 1;
                            if (password == user.password)
                            {
                                Session["username"] = username;
                                Response.Redirect("WebForm1.aspx");
                                break;
                            }
                            else
                            {
                                tbloi.InnerHtml = "Sai mật khẩu";
                                break;
                            }
                        }
                    }
                    if (dem == 0)
                    {
                        tbloi.InnerHtml = "Không tồn tại tài khoản, xin mời đăng ký ";
                    }
                }
                else
                {
                    tbloi.InnerHtml = "Mời nhập đầy đủ tài khoản và mật khẩu";
                }
            }
        }
    }
}