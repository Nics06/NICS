<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication57.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       body {
            background-color:whitesmoke; 
            font-family: Arial, sans-serif;
        }
        #form1 {
            background-color:lightpink;
            padding: 20px;
            width: 300px;
            margin: 0 auto;
            border-radius: 10px;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Nics Flower Shop Order Form</h2>
        
            
            <asp:Label ID="lblItemName" runat="server" Text="Item Name:"></asp:Label>
            <asp:TextBox ID="txtItemName" runat="server" OnTextChanged="txtItemName_TextChanged"></asp:TextBox><br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity:"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnOrder" runat="server" Text="Place Order" OnClick="btnOrder_Click" /><br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="height: 26px" /><br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br />
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click1" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Visible="false"></asp:Label><br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView> 
    </div>
    </form>
</body>
</html>
