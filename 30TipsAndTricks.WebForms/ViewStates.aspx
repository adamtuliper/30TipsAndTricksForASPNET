<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStates.aspx.cs" Inherits="_30TipsAndTricks.WebForms.ViewStates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="statesList" AutoGenerateColumns="False" runat="server" UpdateMethod="SaveState" SelectMethod="LoadStates" ItemType="_30TipsAndTricks.WebForms.Models.State">
            <Columns>
            <asp:BoundField DataField="Abbreviation" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name"/>
            <%--<asp:TemplateField HeaderText="State Name">
                <ItemTemplate>
                    <asp:Label ID="name" runat="server" Text='<%#: Item.Name%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:CommandField ShowEditButton="True"></asp:CommandField>
        </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
