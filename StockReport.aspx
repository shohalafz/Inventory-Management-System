<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="StockReport.aspx.cs" Inherits="IMSPM.StockReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        </br>
    <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Height="431px" Width="857px">
        <Series>
            <asp:Series IsValueShownAsLabel="True" Legend="Legend1" Name="Series1" XValueMember="productname" YValueMembers="qty" ChartType="StackedColumn">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
        <Legends>
            <asp:Legend Name="Legend1" Title="Stocked" BackColor="Silver" Font="Microsoft Sans Serif, 14pt, style=Bold" IsTextAutoFit="False" TitleFont="Microsoft Sans Serif, 14pt, style=Bold">
            </asp:Legend>
        </Legends>
        <Titles>
            <asp:Title Name="Title1" Text="Stock Details" BackColor="DarkSalmon" Font="Microsoft Sans Serif, 14pt, style=Bold">
            </asp:Title>
        </Titles>
    </asp:Chart>
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Inventory Management SystemConnectionString %>" SelectCommand="SELECT * FROM [ProductInverntory]"></asp:SqlDataSource>

    </div>
</asp:Content>
