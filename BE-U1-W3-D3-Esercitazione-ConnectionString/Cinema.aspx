<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cinema.aspx.cs" Inherits="BE_U1_W3_D3_Esercitazione_ConnectionString._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       <div class="container">
            <h1>Vendita Biglietti</h1>
            <div>
                <label for="nome">Nome:</label>
                <asp:TextBox ID="TextBoxNome" runat="server" required></asp:TextBox>
            </div>
            <div>
                <label for="cognome">Cognome:</label>
                <asp:TextBox ID="TextBoxCognome" runat="server" required></asp:TextBox>
            </div>
            <div>
                <label for="sala">Sala:</label>
                <asp:DropDownList ID="DropDownListSala" runat="server" required>
                    <asp:ListItem Value="Nord" Text="SALA NORD" />
                    <asp:ListItem Value="Est" Text="SALA EST" />
                    <asp:ListItem Value="Sud" Text="SALA SUD" />
                </asp:DropDownList>
            </div>
            <div>
                <label for="tipoBiglietto">Tipo Biglietto:</label>
                <asp:CheckBox ID="CheckBoxBigliettoRidotto" runat="server" Text="Biglietto ridotto" />
            </div>
            <div>
                <asp:Button ID="ButtonAcquista" runat="server" Text="Acquista" OnClick="ButtonAcquista_Click" />
            </div>
        </div>
    </main>

</asp:Content>
