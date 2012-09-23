<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStates.aspx.cs" Inherits="_30TipsAndTricks.WebForms.ViewStates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="statesList" runat="server" ItemType="_30TipsAndTricks.WebForms.Models.State"></asp:GridView>
    </div>
    </form>
</body>
</html>
