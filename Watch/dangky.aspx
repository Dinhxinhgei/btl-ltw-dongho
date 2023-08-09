<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="Watch.dangky" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
	    <div id="reg-form" class="auth">
            <form action="dangky.aspx" method="post" runat="server">
                <div class="auth__header">
                    <h2>Đăng ký</h2>
                    <a href="login.aspx">Đăng nhập</a>
                </div>
                <div class="auth_form">
                    <div class="form-control">
                        <label for="username">Tên đăng nhập</label>
                        <input type="text" id="username" placeholder="Nhập tên đăng nhập" name="username"/>
                    </div>
                    <div class="form-control">
                        <label for="email">Email</label>
                        <input type="text" id="email" placeholder="vd: nguyenvana@gmail.com" name="email" runat="server"/>
                        <p></p>
                    </div>
                    <div class="form-control">
                        <label for="password">Mật khẩu</label>
                        <input type="password" id="password" placeholder="Nhập mật khẩu" name="password"/>
                        <p></p>
                    </div>
                    <div class="form-control">
                        <label for="re-password">Xác nhận mật khẩu</label>
                        <input type="password" id="re-password" placeholder="Nhập lại mật khẩu" name="re-password"/>
                        <p></p>
                    </div>
                    <p runat="server" id="tbloi" style="color:red"></p>
                    <button type="submit" class="auth_btn" id="btnReg">Đăng ký</button>
                </div>
                </form>
            </div>
            </div>
</asp:Content>
