<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestTemperatureWebService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <label for="textInput">Input</label>
             <asp:TextBox ID="textInput" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <label for="textResult">Result</label>
             <asp:TextBox ID="textResult" class="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
        <div class="row">
        <div class="col">
            <asp:Button ID="ConvertCToF" class="btn btn-danger" runat="server" Text="C to F" OnClick="ConvertCToF_Click" />
            <asp:Button ID="ConvertFToC" class="btn btn-warning" runat="server" Text="F to C" OnClick="ConvertFToC_Click" />
        </div>
    </div>

</asp:Content>
