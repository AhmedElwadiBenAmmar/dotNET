<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Partie B.aspx.cs" Inherits="Exercice2Atelier4.Partie_B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 419px;
            margin-left: 14px;
        }
        #Password2 {
            width: 425px;
            margin-left: 0px;
        }
    </style>
</head>
<body style="height: 584px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Nom"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 181px" Width="418px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Prenom"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 92px" Width="423px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 108px" Width="424px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Date of birth"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 108px" Width="424px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged" style="margin-left: 0px" Width="424px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 0px" Width="424px"></asp:TextBox>
&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="49px" OnClick="Button1_Click" style="margin-left: 205px" Text="Create" Width="332px" />
        </p>
    </form>
</body>
</html>
