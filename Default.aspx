<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        
          <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
          <asp:Label ID="Label1" runat="server" Text="ingrese el username"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
           <asp:Label ID="Label2" runat="server" Text="ingrese la contraseña"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
           <asp:Label ID="Label3" runat="server" Text="ingrese el Rol (debe ser 3)"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblHolaMundo" runat="server" Text="Enviar"></asp:Label>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

           <asp:Label ID="Label4" runat="server" Text="ingrese el nombre"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
           <asp:Label ID="Label5" runat="server" Text="ingrese el apellido"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
           <asp:Label ID="Label6" runat="server" Text="ingrese el genero"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label8" runat="server" Text="ingrese la fecha de nacimiento"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label9" runat="server" Text="ingrese el usuario(debe ser 3)"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" Text="Enviar"></asp:Label>

        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Button" />


    </form>
</body>
</html>
