using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Watch
{
    public partial class Giohang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cart> CartList = (List<Cart>)Application["CartList"];

            if (Request.Form["btnBuy"] != null)
            {
                int qty = Request.Form["quantity"] == null ? 1 : int.Parse(Request.Form["quantity"]);
                addCart(CartList, (string)Session["username"], int.Parse(Request.Form["btnBuy"]), qty);
                Application["CartList"] = CartList;
            }

            if (IsPostBack)
            {
                if (Request.Form["delete"] != null)
                {
                    foreach (Cart cart in  CartList)
                    {
                        if (cart.Username == (string)Session["username"] && cart.ProductId == int.Parse(Request.Form["delete"])) 
                        {
                             CartList.Remove(cart);
                            break;
                        }
                    }
                    Application["CartList"] = CartList;
                }
            }

            cartList.InnerHtml = renderCart(CartList);
        }

        protected void addCart(List<Cart> CartList, string username, int productID, int quantity)
        {
            bool check = false;

            foreach (Cart cart in CartList)
            {
                if (cart.Username == username && cart.ProductId == productID)
                {
                    cart.Quantity += quantity;
                    check = true;
                }
            }

            if (!check)
            {
                Cart cart = new Cart(username, productID, quantity);
                CartList.Add(cart);
            }
        }

        protected string renderCart(List<Cart> CartList)
        {
            List<SanPham> ProductList = (List<SanPham>)Application["ProductList"];
            string html = "";

            foreach(Cart cart in CartList)
            {
                if (cart.Username == (string)Session["username"])
                {
                    foreach(SanPham sp in ProductList)
                    {
                        if (sp.Id == cart.ProductId)
                        {
                            html += $@"
                            <div class='cart-item flex cl-gap'>
                                <div class='col-3 pd-gap'>
                                    <img src='{sp.Images}'>
                                </div>
                                <div class='col-9 pd-gap'>
                                    <div class='flex cl-gap'>
                                        <div class='col-5 pd-gap'>
                                            <div class='cart_product_name'>
                                                <h3>{sp.Name}</h3>
                                                <span class='product-cart-name'>Color: {sp.Color}</span></br>
                                                <span class='product-price'>{sp.Price:N0}</span>
                                            </div>
                                        </div>
                                        <div class='col-7 pd-gap'>
                                            <div class='cart_control flex cl-gap'>
                                                <div class='col-5 pd-gap'>
                                                    <div class='cart_quantity'>
                                                        <div class='quantity'>
                                                            <input class='qty_input' type='text' name='quantity' value='{cart.Quantity}'>
                                                        </div>
                                                        <div class='quantity_btn'>
                                                            <i class='fas fa-angle-up qtt_up'></i>
                                                            <i class='fas fa-angle-down qtt_down'></i>
                                                        </div>
                                                    </div>

                                                </div>
                                                <div class='col-5 pd-gap'>
                                                    <span class='total_cart'>{(sp.Price * cart.Quantity):N0}</span>
                                                </div>
                                                <div class='col-2 pd-gap'>
                                                    <button class='btn_delete' type='submit' name='delete' value='{sp.Id}'>
                                                        <i class='fas fa-trash-alt'></i>
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        ";

                        }
                        
                    }
                }
            }

            if (html == "")
            {
                return "<span>Không có sản phẩm nào trong giỏ hàng</span>";
            }
            else
                return html;
        }
    }
}