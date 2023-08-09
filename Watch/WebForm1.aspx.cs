using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] != null)
            //{
            //    login.InnerHtml = "<p class='user' style='color:white'>Xin chào " + Session["username"].ToString() + " | " + "</p>";
            //    dnSession.InnerHtml = "<a href = 'logout.aspx'> Đăng xuất </a>";
            //}
            List<SanPham> ProductList = (List<SanPham>)Application["ProductList"];
            string html = $@"
                <div class='banner'>
                    <a href=''>
                            <img class='banner-product' src='./img/desk_category_tile_eyewear_inspo_2.jpg' width='100%'/>
                    </a>
                    <div class='btn-explore'>
                        <button>KHÁM PHÁ</button>
                    </div>
                </div>
            ";
            string html2 = "";
            int dem = 0;
            foreach (SanPham product in ProductList)
            {
                dem++;
                if (dem <= 3)
                {

                    html += "<div class='columns-product'>";
                    html += "<a href=chitietsanpham.aspx?id=" + product.Id + ">";
                    html += "<div class='product-img'>";
                    html += "<img src=\"" + product.Images + "\" width=\"100%\" alt=\"\">";
                    html += "</div>";
                    html += "</a>";
                    html += "<div class='price'>";
                    html += "<div class='product-card'>";
                    html += "<span class='product-card-name'>NEW</span>";
                    html += "</div>";
                    html += "<div class='product-tag'>";
                    html += " <p>QUADRO STUDIO</p>";
                    html += "</div>";
                    html += "<div class='product-btn-choice mg-price'>";
                    html += "<button class='choice-color btn-gold'>" + "</button>";
                    html += " <button class='choice-color btn-gray'>" + "</button>";
                    html += "</div>";
                    html += " <div class='product-name mg-price'>";
                    html += " <a href = '' >";
                    html += "<span> " + product.Name + "</span>";
                    html += "</a>";
                    html += "</div>";
                    html += "<div class='product-price mg-price'>";
                    html += $"<span>{product.Price:N0} &nbsp;₫</span>";
                    html += "</div>";
                    html += "</div>";
                    html += "</div>";

                }
            }
            listrcmDW.InnerHtml = html;
            dem = 1;
            foreach (SanPham product in ProductList)
            {
                if (dem<=4 && product.Type.IndexOf("Special") !=-1)
                {
                    dem++;
                    html2 += "<div class='columns-product'>";
                    html2 += "<a href=chitietsanpham.aspx?id=" + product.Id + ">";
                    html2 += "<div class='product-img'>";
                    html2 += "<img src=\"" + product.Images + "\" width=\"100%\" alt=\"\">";
                    html2 += "</div>";
                    html2 += "</a>";
                    html2 += "<div class='price'>";
                    html2 += "<div class='product-card'>";
                    html2 += "<span class='product-card-name'>NEW</span>";
                    html2 += "</div>";
                    html2 += "<div class='product-tag'>";
                    html2 += " <p>QUADRO STUDIO</p>";
                    html2 += "</div>";
                    html2 += "<div class='product-btn-choice mg-price'>";
                    html2 += "<button class='choice-color btn-gold'>" + "</button>";
                    html2 += " <button class='choice-color btn-gray'>" + "</button>";
                    html2 += "</div>";
                    html2 += " <div class='product-name mg-price'>";
                    html2 += " <a href = '' >";
                    html2 += "<span> " + product.Name + "</span>";
                    html2 += "</a>";
                    html2 += "</div>";
                    html2 += "<div class='product-price mg-price'>";
                    html2 += $"<span>{product.Price:N0}&nbsp;₫</span>";
                    html2 += "</div>";
                    html2 += "</div>";
                    html2 += "</div>";

                }
                
            }
            listrcmHL.InnerHtml = html2;

        
        }

    }
}