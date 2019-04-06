<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="def.aspx.cs" Inherits="Challenge2.def" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>First Value&nbsp;
                <asp:TextBox ID="firstNum" runat="server" OnTextChanged="FirstNum_TextChanged"></asp:TextBox>
            </p>
            <p>Second Value&nbsp;
                <asp:TextBox ID="secText" runat="server" OnTextChanged="SecText_TextChanged"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="add" runat="server" Text="+" OnClick="add_Click" />
                <asp:Button ID="subtract" runat="server" Text="-" OnClick="subtract_Click" />
                <asp:Button ID="multiply" runat="server" Text="*" OnClick="multiply_Click" style="width: 21px" />
                <asp:Button ID="divide" runat="server" Text="/" OnClick="divide_Click" />
            </p>
        </div>
        <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
