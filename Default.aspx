<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--This is a web or xml comment-->
        <h1>Birthday Calcaulator</h1>
        <hr />
        <p>Choose your birthday</p>
        <asp:Calendar ID="Calendar1" runat="server">

        </asp:Calendar>
        <p>Enter your name <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></p>
        <p> <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></p>
        <asp:Label ID="ResultLabel" runat="server" Text="" CssClass="result"></asp:Label>

    </div>
    </form>
</body>
</html>
