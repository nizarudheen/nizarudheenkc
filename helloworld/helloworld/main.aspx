<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="helloworld.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 500px; width: 929px">
    <form id="form1" runat="server">
    <div style="height: 78px; margin-top: 0px;" aria-grabbed="undefined">
    </div>
    <div style="height: 354px">
        Name<asp:TextBox ID="TextBox1" runat="server" Height="28px" style="margin-left: 11px" Width="161px"></asp:TextBox>
        <asp:ListBox ID="txt_location" runat="server" Height="71px" Width="117px">
            <asp:ListItem>calicut</asp:ListItem>
            <asp:ListItem>cochi</asp:ListItem>
            <asp:ListItem>trivandram</asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
    </form>
</body>
</html>
