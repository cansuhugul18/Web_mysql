<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_mysql.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="tablegridview" runat="server">
        <Columns>
        <asp:BoundField DataField="kisi_id" HeaderText="kisi_id" />
        <asp:BoundField DataField="kisi_adi" HeaderText="kisi_adi" />
     

    </Columns>
    </asp:GridView>
</asp:Content>
