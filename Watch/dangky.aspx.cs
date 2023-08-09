using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form.Get("username");
                string email = Request.Form.Get("email");
                string password = Request.Form.Get("password");
                string repassword = Request.Form.Get("re-password");
                List<User> users = (List<User>)Application["Users"];
                List<User> admin = (List<User>)Application["Admin"];

                bool check = true;
                if (username != "" && email != "" && password != "" && repassword != "")
                {
                    foreach (User user in users)
                    {
                        if (username == user.username)
                        {
                            tbloi.InnerHtml = "Tài khoản đã tồn tại";
                            check = false;
                        }
                        if (password != repassword)
                        {
                            tbloi.InnerHtml = "Mật khẩu chưa trùng khớp";
                            check = false;
                        }
                        //if (email.IndexOf("@gmail.com") < 0)
                        //{
                        //    tbloi.InnerHtml = "Email sai định dạng";
                        //    check = false;
                        //}
                    }
                    foreach (User ad in admin)
                    {
                        if (username == ad.username)
                        {
                            tbloi.InnerHtml = "Tài khoản đã tồn tại";   //check trùng với tk admin
                            check = false;
                        }
                    }

                    if (check)
                    {
                        tbloi.InnerHtml = "Đăng ký thành công";
                        User newUser = new User(username, email, password, repassword);
                        users.Add(newUser);
                        Application["Users"] = users;
                    }
                }
                else
                {
                    tbloi.InnerHtml = "Mời nhập đầy đủ thông tin";
                }
            }
        }
    }
}