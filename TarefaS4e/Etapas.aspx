<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Etapas.aspx.cs" Inherits="TarefaS4e.Etapas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <main aria-labelledby="title">

        <div class="form-group">
            <label for="title">Título</label>
            <input type="text" class="form-control" id="title" placeholder="Insira o título">
        </div>
        <div class="form-group">
            <label for="description">Descrição</label>
            <textarea class="form-control" id="description" rows="3" placeholder="Insira a descrição"></textarea>
        </div>
        <div class="form-group">
            <label for="startDate">Data de Início</label>
            <input type="date" class="form-control" id="startDate">
        </div>

        <div class="form-group">
            <label for="startDate">Tratativa</label>

            <div class="form-group form-check">
                <label class="form-check-label">
                    <input type="checkbox" class="form-check-input" asp-for="Done" />
                    Recebimento
                </label>
            </div>
            <div class="form-group form-check">
                <label class="form-check-label">
                    <input type="checkbox" class="form-check-input" asp-for="Done" />
                    Em Andamento
                </label>
            </div>
            <div class="form-group form-check">
                <label class="form-check-label">
                    <input type="checkbox" class="form-check-input" onclick="" asp-for="Done" />
                    Concluído
                </label>
            </div>
        </div>

        <%--<div class="form-group">
            <label for="status">Status</label>
            <select class="form-control" id="status">
                <option>Recebimento</option>
                <option>Andamento</option>
                <option>Concluído</option>
            </select>
        </div>--%>
        <button type="submit" class="btn btn-primary">Enviar</button>


    </main>

</asp:Content>
