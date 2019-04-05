<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexUI.aspx.cs" Inherits="Stock_Management_System.indexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <div style="text-align:center;border:1px solid red">
                <h1>Stock Management System</h1>
            </div>

            <br />
            <fieldset >
 
            <legend >Home Page:</legend>&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
        <asp:Label ID="Label2" runat="server" Text="1."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UI/CategoryUI.aspx">Category Setup</asp:HyperLink>
                <br />
        <asp:Label ID="Label3" runat="server" Text="2."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/UI/ComapnyUI.aspx">Company Setup</asp:HyperLink>
                <br />
        <asp:Label ID="Label4" runat="server" Text="3."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink3" runat="server">Item Setup</asp:HyperLink>
                <br />
        <asp:Label ID="Label5" runat="server" Text="4."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink4" runat="server">Stock In</asp:HyperLink>
                <br />
        <asp:Label ID="Label6" runat="server" Text="5."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink5" runat="server">Stock Out</asp:HyperLink>
                <br />
        <asp:Label ID="Label7" runat="server" Text="6."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink6" runat="server">Search &amp; View Items Summary</asp:HyperLink>
                <br />
        <asp:Label ID="Label8" runat="server" Text="7."></asp:Label>
                &nbsp;&nbsp;&nbsp;
                
                

                <asp:HyperLink ID="HyperLink7" runat="server">View Sales Between Two Dates</asp:HyperLink>
                
                

                <br />
                </fieldset>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
