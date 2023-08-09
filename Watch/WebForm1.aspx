<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Watch.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">
        <!-- slide-banner -->
        <div id="slide-banner">
            <div class="slideshow-container">
                <div class="slide-banner-content fade">
                    <a href="#">
                        <div class="banner-img">
                            <img src="./img/Qday_Petite_Melrose_28_D2800x1000.jpg" width="100%"/>

                        </div>
                    </a>
                    <div class="text-content1">
                        <p class="row1 col">QUADRO</p>
                        <p class="row2 col">STUDIO</p>
                        <p class="row3 col">BỘ SƯU TẬP ĐỒNG HỒ SQUARE DIAL WATCH COLLECTION<br>LẤY CẢM HỨNG TỪ THẬP NIÊN 70</p>
                        <button class="explore col">KHÁM PHÁ</button>
                    </div>
                </div>
                <div class="slide-banner-content fade">
                    <a href="#">

                        <div class="banner-img">
                            <img src="./img/color-dials-hero-petite-2800x950.png" width="100%"/>
                        </div>
                    </a>
                    <div class="text-content mg-cnt col">
                        <p class="row1 col">COLOR DIAL</p>
                        <p class="row3 col">SÁU MÀU SẮC LẤY TỪ VẺ ĐẸP CỦA THIÊN NHIÊN<br> ĐƯỢC THIẾT KẾ BỔ SUNG CHO CÁC BỘ SƯU TẬP ICOMIC & PETITE</p>

                        <button class="explore col">KHÁM PHÁ</button>
                    </div>
                </div>
                <div class="slide-banner-content fade">
                    <a href="#">

                        <div class="banner-img">
                            <img src="./img/melrose_gift_set_hero_2800x1000.png" width="100%">

                        </div>
                    </a>
                    <div class="text-content col">
                        <p class="row1 col">QUADRO</p>
                        <p class="row2 col">STUDIO</p>
                        <p class="row3 col">BỘ SƯU TẬP ĐỒNG HỒ SQUARE DIAL WATCH COLLECTION<br>LẤY CẢM HỨNG TỪ THẬP NIÊN 70</p>
                        <button class="explore col">KHÁM PHÁ</button>
                    </div>
                </div>
            </div>
            <br>

            <div style="text-align:center">
                <span class="dot"></span>
                <span class="dot"></span>
                <span class="dot"></span>
            </div>

        </div>
        <!--service-->
        <div class="service-all">
            <div class="service">
                <div class="container1">
                    <div class="service-container flex">
                        <div class="col-4 col-sm-12">
                            <div class="service-item flex">
                                <div class="service-icon">
                                    <i class="ti-truck"></i>
                                </div>
                                <div class="service-content">
                                    <p class="service-name">FREESHIP</p>
                                </div>

                            </div>
                        </div>
                        <div class="col-4 col-sm-12">
                            <div class="service-item flex">
                                <div class="service-icon">
                                    <i class="ti-save"></i>
                                </div>
                                <div class="service-content">
                                    <p class="service-name">HOÀN TRẢ MIỄN PHÍ</p>
                                </div>

                            </div>
                        </div>
                        <div class="col-4 col-sm-12">
                            <div class="service-item flex">
                                <div class="service-icon">
                                    <i class="ti-server"></i>
                                </div>
                                <div class="service-content">
                                    <p class="service-name">BẢO HÀNH 2 NĂM</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--end-service-->
        <!-- tag-watch -->
        <div class="content">
            <div class="row">
                <a class="link-Dongho transition" href="#">ĐỒNG HỒ</a>
                <a class="link-smartwatch transition" href="#">SMARTWATCH</a>
                <a class="link-necklaces transition" href="#">NECKLACES</a>
                <a class="link-sunglasses transition" href="#">SUNGLASSES</a>
            </div>
        </div>
        <!--San pham-->
        <div class="products">
            <div class="container1">
                <div class="block-title">
                    <p class="title mg-title">RETRO VÀ MẶT VĨNH CỬU</p>
                </div>
                <div class="new-product-img" id="listrcmDW" runat="server">
                    <%--<div class="banner">
                        <a href="">
                            <img class="banner-product" src="./img/desk_category_tile_eyewear_inspo_2.jpg" width="100%"/>
                        </a>
                        <div class="btn-explore">
                            <button>KHÁM PHÁ</button>
                        </div>
                    </div>--%>
                    <!--watch-product-->
                	<%--<div id="listrcmDW" class="list-align-product" name="listrcmDW" runat="server"> 
                        <!--List rcm DW-->
                    </div>--%>
                </div>
            </div>
            <!--end-watch-product-->
        </div>
        <!-- banner-glasses -->
        <div class="banner-glasses">
            <div class="container1">
                <a href="">
                    <img src="./img/dek-start-page-hero-eyewear.jpg" width="100%">
                </a>
                <div class="btn-explore-glasses">
                    <p>DANIEL WELLINGTON</p>
                    <h2>KÍNH MẮT</h2>
                    <div class="btn-slider-all">
                        <button>KHÁM PHÁ</button>
                    </div>
                </div>

            </div>

        </div>

        <div class="all-banner-gender">
            <div class="container1">
                <div class="grid-all">

                    <!-- banner-womanwatch -->
                    <div class="banner-womanwatch">
                        <div class="banner-cotainer-watch">
                            <a href="">
                                <img src="./img/looks-her-studio.jpg" width="100%">
                            </a>
                            <div class="btn-explore-glasses">
                                <p>ĐỒNG HỒ CHO</p>
                                <p>CÔ ẤY</p>
                                <div class="btn-slider-all">
                                    <button>KHÁM PHÁ</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- banner-manwatch -->
                    <div class="banner-manwatch">
                        <a href="">
                            <img src="./img/looks-him-studio.jpg" width="100%"/>
                        </a>
                        <div class="btn-explore-glasses">
                            <p>ĐỒNG HỒ CHO</p>
                            <p>ANH ẤY</p>
                            <div class="btn-slider-all">
                                <button>KHÁM PHÁ</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--new-product-->
        <div class="new-product">
            <div class="container1">
                <div class="block-title">
                    <p class="title mg-title">SẢN PHẨM NỔI BẬT</p>
                </div>
                <div class="new-product-img-standout">
                    <div id="listrcmHL" class="list-align-standout" name="listrcmHL" runat="server"> 
                        <!--List rcm HL-->
                    </div>
                </div>
            </div>
        </div>
        <div class="brand-container">
            <div class="container1">
                <div class="brand-slideshow">
                    <div class="swiper">
                        <div class="swiper-wrapper">
                            <div class="brand1 border-brand swiper-slide">
                                <img src="./img/orient_1579072250.png"/>
                            </div>
                            <div class="brand2 border-brand swiper-slide">
                                <img src="./img/rotarry_1579066082.png"/>
                            </div>
                            <div class="brand3 border-brand swiper-slide">
                                <img src="./img/skagen_1579064882.png"/>
                            </div>
                            <div class="brand4 border-brand swiper-slide">
                                <img src="./img/candino_1579065087.png"/>
                            </div>
                            <div class="brand5 border-brand swiper-slide">
                                <img src="./img/chariol_1579066567.png"/>
                            </div>
                            <div class="brand6 border-brand swiper-slide">
                                <img src="./img/frederique-constant_2_1576645033.png"/>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </main>
</asp:Content>
