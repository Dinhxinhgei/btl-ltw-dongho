<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ADMIN.aspx.cs" Inherits="Watch.ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
	    <div id="reg-form" class="auth">
            <form method="post" runat="server" action="ADMIN.aspx">
                <div class="auth__header">
                    <h2>QUẢN TRỊ SẢN PHẨM</h2>
                </div>
                <div class="auth_form">
                    <div class="form-control">
                        <label>ID</label>
                        <input type="text" id="id" placeholder="Nhập ID" name="id" runat="server" value=""/>
                    </div>
                    <div class="form-control">
                        <label>Chọn ảnh</label>
                        <input type="file" id="file" name="file" runat="server" onchange="loadFile(event)" />
                        <img id="imgoutput" src="#" style="width: 150px"/>
                    </div>
                    <div class="form-control">
                        <label>Name</label>
                        <input type="text" id="name" placeholder="Nhập tên sản phẩm" name="name" runat="server" value=""/>
                    </div>
                    <div class="form-control">
                        <label>Price</label>
                        <input type="text" id="price" placeholder="Nhập giá sản phẩm" name="price" runat="server" value=""/>
                    </div>
                    <div class="form-control">
                        <label>Color</label>
                        <input type="text" id="color" placeholder="Nhập màu sản phẩm" name="color" runat="server" value=""/>
                    </div>
                    <div class="form-control">
                        <label>Detail</label>
                        <input type="text" id="detail" placeholder="Nhập detail sản phẩm" name="detail" runat="server" value=""/>
                    </div>
                    <p runat="server" id="tbloi" style="color:red"></p>
                    <input type="submit" class="auth_btn" id="btnThem" name="btnThem" value="Thêm"/>
                </div>
                </form>
            </div>
            </div>
    <div id="tblSanpham" runat="server">
        <!--tbl danh sách sản phẩm-->
    </div>
    <script>
      var loadFile = function(event) {
        var reader = new FileReader();
        reader.onload = function(){
          var output = document.getElementById("imgoutput");
          output.src = reader.result;
        };
          reader.readAsDataURL(event.target.files[0]);
            };

    </script>
    
</asp:Content>
