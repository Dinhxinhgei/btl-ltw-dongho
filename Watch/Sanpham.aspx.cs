using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class Sanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<SanPham> ProductList = (List<SanPham>)Application["ProductList"];
            string html = "";
            string typeFind = Request.QueryString["type"] == null ? "" : Request.QueryString["type"];
            string searchFind = Request.QueryString["search"] == null ? "" : Request.QueryString["search"];
            string changeTitle="";
            string changeTitlebt = "";
            int dem = 1;
            foreach (SanPham product in ProductList)
            {
               
                if (typeFind == "Men")
                {
                     changeTitle = $@"
                        <h4> DANIEL WELLINGTON FOR HIM</h4>
                       ";
                }
                else if(typeFind=="Women")
                {
                    changeTitle = $@"
                        <h4> DANIEL WELLINGTON FOR HER</h4>
                       ";
                   
                }
                if (dem <= 12 && product.Type.IndexOf(typeFind) != -1 && product.Name.ToLower().IndexOf(searchFind.ToLower()) != -1)
                {

                    dem++;
                    html += "<div class='columns col-3 pd-gap'>";
                    html += "<div class='thumbnail_align'>";
                    html += "<a href=chitietsanpham.aspx?id=" + product.Id + ">";
                    html += "<img src=\"" + product.Images + "\" width=\"100%\" class=\"thumbnail\" alt=\"\">";
                    html += "</a>";
                    html += "<div class='recommend_gia' >";
                    html += "<h4 class='ten'>" + product.Name + "</h4>";
                    html += "<p class='mau'>" + product.Color + "</p>";
                    html += $"<p class='gia'>{product.Price:N0}</p>";
                    html += "</div>";
                    html += "</div>";
                    html += "</div>";
                }

            }
            
            titlesp.InnerHtml = changeTitle;
            listdw1.InnerHtml = html;
            html = "";
            dem = 1;
            foreach (SanPham product in ProductList)
            {
                if (typeFind == "Men")
                {
                    changeTitlebt = $@"
                            <h3>HUBLOT FOR HIM</h3>
                           ";
                }
                else if (typeFind == "Women")
                {
                    changeTitlebt = $@"
                            <h3>HUBLOT FOR HER</h3>
                           ";
                }
                if (dem <= 4 && product.Type.IndexOf("Special") != -1 && product.Type.IndexOf(typeFind) != -1)
                {
                    dem++;
                    html += "<div class='columns col-3'>";
                    html += "<div class='thumbnail_align'>";
                    html += "<a href=chitietsanpham.aspx?id=" + product.Id + ">";
                    html += "<img src=\"" + product.Images + "\" width=\"100%\" class=\"thumbnail\" alt=\"\">";
                    html += "</a>";
                    html += "<div class='recommend_gia' >";
                    html += "<h4 class='ten'>" + product.Name + "</h4>";
                    html += "<p class='mau'>" + product.Color + "</p>";
                    html += "<p class='gia'>" + product.Price + "</p>";
                    html += "</div>";
                    html += "</div>";
                    html += "</div>";

                }

            }
            titlebt.InnerHtml = changeTitlebt;
            listspecial.InnerHtml = html;
        }
    }
}