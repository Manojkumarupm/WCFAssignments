﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <div> <asp:Label ID="Label2" runat="server" Text=""/> </div>
   
    </div>
        <asp:Button ID="Button1" runat="server" Text="Http Request" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="TCP Request" />
    </form>
    
</body>
</html>
