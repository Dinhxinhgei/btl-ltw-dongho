<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="chitietsanpham.aspx.cs" Inherits="Watch.chitietsanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="maincontent">
        <form action="Giohang.aspx" method="post" runat="server">
            <div class="page-container">
                <div class="slideshow-container1">
                    <div class="mySlides1" runat="server" id="imgpd">
                        <!-- <img src="img/dw quadro studio.png" style="width:100%"><%# Eval("Images") %>
                    </div>
                
                    <div class="mySlides1">
                        <img src="img/DW00100517_Quadro_St-HHOgxmBb.png" style="width:100%"><%# Eval("Images") %>
                    </div>
                
                    <div class="mySlides1">
                        <img src="img/DW00100517_Quadro_St-MhsxcEMc.png" style="width:100%"><%# Eval("Images") %> -->
                    </div>
                
                    <!--<a class="prev" onclick="plusSlides(-1, 0)">
                        <span>&#10094;</span>
                    </a>
                    <a class="next" onclick="plusSlides(1, 0)">
                        <span>&#10095;</span>
                    </a> -->
                </div>
                <div id="newlist" runat="server" class="list" name="newlist">

                </div>
                <!--<div class="product-details">
                    <div class="header-content">
                        <div class="product-title">
                            <h1 runat="server" id="producttitle"></h1>
                        </div>
                        <div class="price" >
                            <span runat="server" id="productprice"></span>
                        </div>
                    </div>
                    
                    <div class="poduct-info">
                        <div class="color-pick" >
                            <h5 class="color-title" runat="server" id="colortitle">
                                Color
                                :
                            </h5>
                            <div class="product-btn-choice">
                                <button class="btn-gold"></button>
                                <button class="btn-gray"></button>
                            </div>
                        </div>
                        <div class="size-container">
                            <h5 class="size-title" runat="server" id="sizetitle">
                                Size
                                :
                            </h5>
                            <div class="swatch-size" aria-label="color">
                                <button disabled="" class="btnSize" aria-label="size-22x22">22x22mm</button>
                            </div>
                        </div>
                    </div> -->
                    
                    <!--<button class="btnBuy" runat="server" id="btnBuy">
                        <span class="loadingBtn">
                            <a href="Giohang.aspx">
                                Thêm vào giỏ hàng
                                <i class="fa-solid fa-arrow-right"></i>
                            </a>
                        </span>
                    </button>
                    <ul class="list">
                        <li>
                            <i class="arrow"></i>
                            <span class="size-details">Freeship</span>
                        </li>
                        <li>
                            <i class="arrow"></i>
                            <span class="size-details">Hoàn trả miễn phí</span>
                        </li>
                        <li>
                            <i class="arrow"></i>
                            <span class="size-details">Thuế và lệ phí hải quan sẽ được áp dụng khi giao hang theo quy định của Hải Quan Việt Nam </span>
                        </li>
                    </ul>
                </div>
            </div> -->
            
            
            <div class="info-table">
                <div class="info">
                 <%--   <h1>Chi tiết sản phẩm</h1>--%>
                    <section class="details">
                        <div class="detail-info" >
                            <p class="detail" runat="server" id="detailinfo">
                                
                            </p>
                        <div class="details-table" id="tabledetail" runat="server">
                            <div class="container">
                                <div class="row">
                                    <span class="row-1">sku</span>
                                    <span class="row-1-1">dw00100517</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">case thickness</span>
                                    <span class="row-1-1">6,5mm</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">dial color</span>
                                    <span class="row-1-1">trắng sữa</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">moverment</span>
                                    <span class="row-1-1">động cơ chuyển động quartz</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">material</span>
                                    <span class="row-1-1">thép không gỉ mạ hai lớp (316l)</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">strap width</span>
                                    <span class="row-1-1">10mm</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">adjustable length</span>
                                    <span class="row-1-1">122-176mm</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">strap</span>
                                    <span class="row-1-1">dây đeo đồng hồ mắt xích dạng thanh ngang</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">strap color</span>
                                    <span class="row-1-1">rose gold</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">interchangeable straps</span>
                                    <span class="row-1-1">yes</span>
                                </div>
                                <div class="row">
                                    <span class="row-1">water resistant</span>
                                    <span class="row-1-1">tối thiểu 3atm ( chống nước mưa )</span>
                                </div>
                            </div>
                        </div>
                        </div>
                        
                        
                    </section>
                </div>
            </div>
        </div>
        </form>
        </div>
    <script type="text/javascript">
        const quantityInput = document.querySelector(".qty_input");
        const quantityUp = document.querySelector(".qtt_up");
        const quantityDown = document.querySelector(".qtt_down");

        quantityUp.addEventListener("click", () => {
            const quantityNumber = parseInt(quantityInput.value);
            quantityInput.value = quantityNumber + 1;
        })
        quantityDown.addEventListener("click", () => {
            const quantityNumber = parseInt(quantityInput.value);
            quantityInput.value = quantityNumber == 1 ? 1 : quantityNumber - 1;
        })

        quantityInput.addEventListener("blur", () => {
            if (quantityInput.value == "") {
                quantityInput.value = 1;
            }
        })
    </script>
</asp:Content>
