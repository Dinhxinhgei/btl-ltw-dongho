<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Giohang.aspx.cs" Inherits="Watch.Giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Giohang.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--table cart-->
    <form action="Giohang.aspx" method="post" runat="server">
        <div class="container-shopping-cart">
            <div class="container1">
                <div class="cart-details flex cl-gap">
                    <div class="col-8 pd-gap">
                        <div class="cart-info">
                            <div class="cart_head_info">
                                <p>GIỎ HÀNG</p>
                            </div>
                            <div class="cart_body_info" id="cartList" runat="server">
                            
                            </div>
                        </div>

                    </div>
                    <!-- total-cart -->
                    <div class="col-4 pd-gap">
                        <div class="cart_price">

                            <h2 class="cart__title_right">Đơn hàng<br /></h2>
                            <div class="cart__products_total_count">
                                <span class="cart__total_count">Số lượng sản phẩm:</span>
                                <span class="cart__product_price_unit">0</span>
                            </div>
                            <div class="cart__order_total">
                                <span>Tổng tiền: </span>
                                <span class="cart__product_price_unit ">0đ</span>
                            </div>
                            <div class="cart__buttons_right">
                                <button class="purchase_button" type="button">Thanh toán</button>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript" src="./Cart.js"></script>
</asp:Content>
