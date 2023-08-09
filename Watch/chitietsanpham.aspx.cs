using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class chitietsanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                //login.InnerHtml = "<p class='user' style='color:white'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                //    "<a href = 'logout.aspx'> Đăng xuất </a>";
            }

            string html = "";

            List<SanPham> ProductList = (List<SanPham>)Application["ProductList"];

            int idsp = Request.QueryString["id"] == null ? 1 : int.Parse(Request.QueryString["id"]);
            foreach (SanPham product in ProductList)
            {
                if (idsp == product.Id)
                {
                    html += "<div class='product'>";
                    html += "<a href=chitietsp.aspx?id=" + product.Id + ">";
                    html += "<div class='slideshow-container1'>";
                    html += "<img src=\"" + product.Images + "\" width=\"100%\" \"alt=\"\">";
                    html += "</div>";
                    html += "</a>";

                    html += "<div class='product-deatil'>";
                    html += "<div class='header-content'>";
                    html += " <div class='product-title'>";
                    //html += " <a href = '' >";
                    html += "<span> " + product.Name + "</span>";
                    html += "</a>";
                    html += "</div>";

                    html += "<div class='price'>";
                    html += $"<span>{product.Price:N0}&nbsp;₫</span>";
                    html += "</div>";
                    html += "</div>";

                    html += "<div class='color-pick'> ";
                    html += "<h5 class='color-title'> Color: </h5>";
                    html += "</div>";
                    html += "<div class='product-btn-choice-ct'>";
                    html += "<p>"+product.Color+"</p>";
                    //html += "<button class='btn-gold-ct'>" + "</button>";
                    //html += "<button class='btn-gray-ct'>" + "</button>";
                    html += "</div>";

                    html += "<div class='cart_quantity'>";
                    html += "<div class='quantity'>";
                    html += "<input class='qty_input' type='text' name='quantity' value='1'>";
                    html += "</div>";
                    html += "<div class='quantity_btn'>";
                    html += "<i class='fas fa-angle-up qtt_up'></i>";
                    html += "<i class='fas fa-angle-down qtt_down'></i>";
                    html += "</div>";
                    html += "</div>";     
                    if((string)Session["username"] == null)
                    {
                        html += $"<button type='button' name='btnBuy' value='{product.Id}' class='btnBuy'>";
                        html += "<a href='login.aspx' class='loadingBtn'>Thêm vào giỏ hàng";
                        html += "</a>";
                        html += "</button>";
                    }
                    else
                    {
                        html += $"<button type='submit' name='btnBuy' value='{product.Id}' class='btnBuy'>";
                        html += "<span class='loadingBtn'>Thêm vào giỏ hàng";
                        html += "</span>";
                        html += "</button>";

                    }
                    html += "</div>";
             
                    html += "<div class='info-table'>";
                    html += "<div class='info'>";
                    html += "<h1>Chi tiết sản phẩm</h1>";
                    html += "<section class='details'>";
                    html += "<div class='detail-info'>";
                    html += "<p class='detail'>" + product.Detail + "</p>";
                    html += "</div>";
                    html += "</section>";
                    html += "</div>";
                    html += "</div>";


                }
            }
            newlist.InnerHtml = html;





        }
    }
}
