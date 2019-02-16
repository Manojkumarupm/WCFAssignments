<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Text="Job By Role"></asp:Label>  
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

       <div id="Alldata" runat="server">

       </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="GetAllJob Opening" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="GetJobByRole" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
