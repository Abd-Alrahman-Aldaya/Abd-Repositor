<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 3.aspx.cs" Inherits="WebApplication_1.page_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="direction: ltr">
    
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="109px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />
    
    </div>
    </form>
</body>
</html>
