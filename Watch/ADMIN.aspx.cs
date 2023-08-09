using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class ADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                //login.InnerHtml = "<p class='user' style='color:white'>Xin chào " + Session["username"].ToString() + " | " + "</p>";
                //dnSession.InnerHtml = "<a href = 'logout.aspx'> Đăng xuất </a>";

                List<SanPham> danhsach;
                danhsach = (List<SanPham>)Application["ProductList"];
                
                bool check = true;
                if (IsPostBack)
                {
                    int id = int.Parse(Request.Form["id"]);
                    string name = Request.Form["name"];
                    double price = double.Parse(Request.Form["price"]);
                    string color = Request.Form["color"];
                    string detail = Request.Form["detail"];
                    if (Request.Form["btnThem"] == "Thêm")
                    {
                        if (id != -1 || name != "" || price != 0 || color != "" || detail != "")
                        {
                            foreach (SanPham sanPham in danhsach)
                            {
                                if (id == sanPham.Id || name == sanPham.Name)   //check trùng
                                {
                                    tbloi.InnerHtml = "Sản phẩm đã tồn tại";
                                    check = false;
                                }
                            }
                            if (check)
                            {
                                SanPham sp = new SanPham();
                                sp.Id = id;
                                HttpPostedFile file = Request.Files["file"];
                                if (file != null)
                                {
                                    string folderName = Server.MapPath(@"img\\") + file.FileName;   //lưu ảnh mới vào img(trùng tên ảnh thì ghi đè)
                                    file.SaveAs(folderName);
                                }
                                sp.Images = "img\\" + file.FileName;
                                sp.Name = name;
                                sp.Price = price;
                                sp.Color = color;
                                sp.Detail = detail;
                                danhsach.Add(sp);
                                Application["ProductList"] = danhsach;
                                tbloi.InnerHtml = "Thêm thành công";
                            }
                        }
                        else
                        {
                            tbloi.InnerHtml = "Mời nhập đầy đủ thông tin sản phẩm";
                        }
                    }
                }
                string chuoi = "";
                chuoi += "<form action='ADMIN.aspx' runat='server' method='post'>";
                chuoi += "<table border='1' style='margin: auto; margin-bottom: 10px'>";
                chuoi += "<tr><h2 style='text-align: center'>DANH SÁCH SẢN PHẨM</h2></tr>";
                chuoi += "<tr>";
                chuoi += "<td>ID</td>";
                chuoi += "<td>Tên Sản Phẩm</td>";
                chuoi += "<td>Giá</td>";
                chuoi += "<td>Màu</td>";
                chuoi += "<td>Image</td>";
                chuoi += "</tr>";
                foreach (SanPham sp in danhsach)
                {
                    chuoi += "<tr>";
                    chuoi += "<td>" + sp.Id + "</td>";
                    chuoi += "<td>" + sp.Name + "</td>";
                    chuoi += "<td>" + sp.Price + "</td>";
                    chuoi += "<td>" + sp.Color + "</td>";
                    chuoi += "<td width=200px><label><img src=\"" + sp.Images + "\" width=\"150px\" alt=\"\"></label></td>";
                    chuoi += "<td><button type='submit' id='btnXoa' name='btnXoa' value=\"" + sp.Id + "\">Xóa</button> </td>";
                    chuoi += "</tr>";
                }
                chuoi += "</table>";
                chuoi += "</form>";
                tblSanpham.InnerHtml = chuoi;
                try
                {
                    foreach (SanPham sp in danhsach)
                    {
                        if (Request.Form["btnXoa"] == Convert.ToString(sp.Id))      //xóa sp
                        {
                            danhsach.Remove(sp);
                            Application["ProductList"] = danhsach;
                           
                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("ADMIN.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }

        
    }
    }
}