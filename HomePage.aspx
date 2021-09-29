<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="IMSPM.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style2 {
            width: 80%;
            height: 83px;
            color:white;
        }
        .auto-style3 {
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <img src="images/Presentation6.jpg" class="panel" />
        </section>
        <div class="sec2">

            <asp:Label ID="LabUserLogin" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <div class="content">
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">User Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
            <br />
                </div>
        </div>
    </form>
</body>
</html>
