<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="atelierForm1.aspx.cs" Inherits="Atelier4.atelierForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="nbre1"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 

     <asp:Label ID="Label2" runat="server" Text="nbre2"></asp:Label> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList2" runat="server">
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
        <div>
            Bonjour tous le monde. Ici ESPRIM <br />
            <%Response.Write("Hello word"); %>
        </div>
    </form>
</body>
</html>
