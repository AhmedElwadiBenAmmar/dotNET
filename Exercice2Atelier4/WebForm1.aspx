<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exercice2Atelier4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Montant d&#39;une commande
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Nom Produit" ></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 108px"  ></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" ForeColor="Black" Text="Prix Unitaire"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" style="margin-left: 108px"   ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Quantité"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Height="16px" style="margin-left: 146px" Width="158px"  ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" ForeColor="Black" Text="TVA"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="16px" OnTextChanged="TextBox4_TextChanged" style="margin-left: 172px" Width="158px"  ></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Button ID="Button2" runat="server" Text="Calculer" Width="249px" OnClick="Button1_Click1" />
        <p>
            <asp:Label ID="Label5" runat="server" ForeColor="Black" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
