<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StealLogon.aspx.cs" Inherits="EvilShopliftingSite.StealLogon" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <div>
    <p>You just posted your credentials off to an evil site!</p>
    <p>
      You username is:
      <asp:Label ID="UsernameLabel" runat="server"></asp:Label>
    </p>
    <p>
      You password is:
      <asp:Label ID="PasswordLabel" runat="server"></asp:Label>
    </p>
    <p>Happy shopping!</p>
  </div>
</body>
</html>
