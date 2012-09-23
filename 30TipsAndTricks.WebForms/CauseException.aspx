<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CauseException.aspx.cs" Inherits="_30TipsAndTricks.WebForms.CauseException" Trace="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="btnException" runat="server" OnClick="btnException_Click" Text="Cause Exception" />
</asp:Content>
