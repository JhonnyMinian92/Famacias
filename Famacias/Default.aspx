<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Famacias._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-top:20px;">
    <div>
        <div> <a>INGRESO DE FARMACOS</a> </div>
        <div> <a>Nombre: </a> <div><asp:TextBox ID="txtnom" runat="server"></asp:TextBox> </div></div>
        <div> <a>Descripcion: </a> <div><asp:TextBox ID="txtdesc" runat="server"></asp:TextBox> </div></div>
        <div> <a>Precio: </a> <div><asp:TextBox ID="txtprec" runat="server"></asp:TextBox> </div></div>
    </div>
        <div><asp:Button ID="btning" runat="server" Text="Ingresar" OnClick="btning_Click" /></div>
            <br />
            <br />
        <div>
            <asp:GridView ID="DatosFarmacos" runat="server" AutoGenerateColumns="False" DataKeyNames="id_farmaco" OnSelectedIndexChanged="DatosFarmacos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="id_farmaco" HeaderText="id_farmaco" InsertVisible="False" ReadOnly="True" SortExpression="id_farmaco" />
                    <asp:BoundField DataField="nom_farmaco" HeaderText="nom_farmaco" SortExpression="nom_farmaco" />
                    <asp:BoundField DataField="desc_farmaco" HeaderText="desc_farmaco" SortExpression="desc_farmaco" />
                    <asp:BoundField DataField="prec_farmaco" HeaderText="prec_farmaco" SortExpression="prec_farmaco" />
                </Columns>
            </asp:GridView>
        </div>

        <div>
            <asp:Button runat="server" ID="btnactual" Text="Actualizar" OnClick="btnactual_Click" />
        </div>

    </div>

</asp:Content>