<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tarefas.aspx.cs" Inherits="TarefaS4e.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
                
    <div class="form-group">
        <label for="title">Título</label>
        <asp:TextBox ID="title" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label for="description">Descrição</label>
        <asp:TextBox ID="description" TextMode="MultiLine" CssClass="form-control" Rows="3" runat="server" />
    </div>
    <div class="form-group">
        <label for="startDate">Data de Início</label>
        <asp:TextBox ID="startDate" CssClass="form-control" runat="server" />
    </div>
    <asp:Button ID="btnSubmit" CssClass="btn btn-primary" Text="Enviar" OnClick="btnSubmit_Click" runat="server" />

    </main>
</asp:Content>
