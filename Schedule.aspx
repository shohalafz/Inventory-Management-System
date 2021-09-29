<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="IMSPM.Schedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 55%;
        height: 70px;
        background-color: #66FFFF;
    }
    .auto-style2 {
        width: 248px;
    }
    .auto-style3 {
        width: 44%;
        height: 155px;
    }
    .auto-style4 {
        text-align: center;
    }
    .auto-style5 {
        background-color: #0066FF;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Distributor Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="241px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mobile Number</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="241px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <br />
        Select Your RDC Here (Only One RDC Booked at Time)<br />
        <br />
        <table align="left" class="auto-style3">
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Text="RDC-1" OnClick="Button1_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" Text="RDC-2" OnClick="Button2_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button3" runat="server" Text="RDC-3" OnClick="Button3_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button4" runat="server" Text="RDC-4" OnClick="Button4_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button5" runat="server" Text="RDC-5" OnClick="Button5_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button6" runat="server" Text="RDC-6" OnClick="Button6_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button7" runat="server" Text="RDC-7" OnClick="Button7_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button8" runat="server" Text="RDC-8" OnClick="Button8_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button9" runat="server" Text="RDC-9" OnClick="Button9_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button10" runat="server" Text="RDC-10" OnClick="Button10_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button11" runat="server" Text="RDC-11" OnClick="Button11_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button12" runat="server" Text="RDC-12" OnClick="Button12_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button13" runat="server" Text="RDC-13" OnClick="Button13_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button14" runat="server" Text="RDC-14" OnClick="Button14_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button15" runat="server" Text="RDC-15" OnClick="Button15_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button16" runat="server" Text="RDC-16" OnClick="Button16_Click" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button17" runat="server" CssClass="auto-style5" Height="40px" OnClick="Button17_Click" Text="Booked Now" Width="133px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Inventory Management SystemConnectionString2 %>" SelectCommand="SELECT * FROM [RSchedule]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />

    </div>
</asp:Content>
