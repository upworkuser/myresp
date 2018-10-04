<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sampleApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="Info"></asp:GridView>
        </div>
        <br /> <br />
        <div>
            <asp:GridView ID="GridView2" runat="server" BackColor="Orchid"></asp:GridView>
        </div>
        <br /> <br />
        <div>
            <asp:GridView ID="GridView3" runat="server" BackColor="LightPink"></asp:GridView>
        </div>
    </form>
</body>
</html>
