<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Sanpham.aspx.cs" Inherits="Watch.Sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	  <link rel="stylesheet" href="/Sanpham.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="anh-bia">
		 <img src="img/DW banner.png" alt="Ảnh bìa" class="anh" id="anhbiaNam"/>
	</div>

	<div class="main-content">
		<div class="quyen-loi">
			<ul>
				<li>FREESHIP</li>
				<li>BẢO HÀNH 2 NĂM</li>
				<li>SHIP TOÀN QUỐC</li>
			</ul>
		</div>
        
        <br />
		<div class="recommend" id="titlesp" runat="server">
			<h4>DANIEL WELLINGTON FOR HIM</h4>
		</div>
		
		<section>
			<div class="container2">

				<div id="listdw1" class="list-align cl-gap" name="listdw1" runat="server"> 
					<!--List DW1-->
				</div>
			</div>
		</section>
       
        <!---Promo banner-->
			<div class="dongho container2"> 
				<div class="left">
					<div class="p_dongho">
						<h2>DANIEL WELLINGTON 2022</h2>
						<h1>ĐỒNG HỒ CHO PHÁI MẠNH</h1>
					</div>
				</div>
				<div class="right">
					<div class="p_dongho">
						<h2>DANIEL WELLINGTON 2022</h2>
						<h1>ĐỒNG HỒ CHO PHÁI ĐẸP</h1>
					</div>
				</div>
				</div>
        <div class="recommend" >
			<h3 id="titlebt" runat="server">HUBLOT FOR HIM</h3>
			<div class="container2">
				<div id="listspecial" class="list-align" name="listhl1" runat="server"> 
					<!--List HL 1-->
				</div>
			</div>
		</div>

        <%--<div id="listhl2" class="list-align" name="listhl2" runat="server"> 
            <!--List HL 2-->
        </div>
        <div id="listhlmoi" class="list-align" name="listhlmoi" runat="server"> 
            <!--List HL mới thêm từ admin-->
        </div>--%>
		</div>
		<script>
            var imageSourcesNam = ["img/DW banner 2.png", "img/hublot-banner.jpg", "img/DW banner.png", "img/hublot banner.png"]; //nam
            var index = 0;

            setInterval(function () {
                if (index === imageSourcesNam.length) {
                    index = 0;
                }
                document.getElementById("anhbiaNam").src = imageSourcesNam[index];
                index++;
            }, 3000);
        </script>
</asp:Content>
