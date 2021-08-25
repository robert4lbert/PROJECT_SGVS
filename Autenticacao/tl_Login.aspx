<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tl_Login.aspx.cs" Inherits="Project_SGVS.Autenticacao.tl_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row" id="ContextoForm" style="padding-top: 25px; padding-left: 30px;">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-4">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuário:"> </asp:Label>
                        <asp:TextBox ID="txtUsuario" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <asp:Label ID="lvlSenha" runat="server" Text="Senha:"></asp:Label>
                        <asp:TextBox ID="txtSenha" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4" style="text-align: end">
                        <asp:Button ID="btn_Login" runat="server" Text="Entrar" OnClick="btn_Login_Click" />
                    </div>
                </div>
            </div>
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
