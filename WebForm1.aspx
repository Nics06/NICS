<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication57.WebForm1" %>

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
    <br />
    <asp:Label ID="Label5" runat="server" Text="Nics Flower Shop" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
    <br />
    <p>
    <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
    </p>
    <p>
    <asp:TextBox ID="TextBox3" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
    </p>
    <p>
    <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click"/>
    </p>
    <a href="WebForm2.aspx">Login</a>
    </div>
    </form>
</body>
</html>
