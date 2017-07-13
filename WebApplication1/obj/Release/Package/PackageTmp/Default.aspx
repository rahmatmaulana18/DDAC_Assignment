<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CMS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <img src="img/logo.svg" alt="Maersk Logo" style="max-width:60%;">
        <h1>Welcome to container management system</h1>
        <p class="lead">This management system will help you to manage information on shipping easily</p>
        <p><a href="https://my.maerskline.com/" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Add Record</h2>
            <p>
                Add information to the database
            </p>
            <p>
                <a class="btn btn-default" href="Add_Info">Add Record &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Update Record</h2>
            <p>
                Update information in the database
            </p>
            <p>
                <a class="btn btn-default" href="Update_Info">Update Record &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Delete Record</h2>
            <p>
                Delete information from the database
            </p>
            <p>
                <a class="btn btn-default" href="Delete_Info">Delete Record &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
