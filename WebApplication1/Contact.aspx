<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CMS.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br>
    <img src="img/logo.svg" alt="Maersk Logo">
    <br>
    <h3>Head office</h3>
    <address>
        The Plaza, 12th Floor , <br />
        100 Old Hall Street , L3 9QJ<br />
        Liverpool <br />
        <abbr title="Phone">P:</abbr>
        +44 844 264 1263
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">UKQUOTES@MAERSK.COM</a><br />
        <strong>Exports:</strong> <a href="mailto:Marketing@example.com">GB.EXPORT@Maersk.com </a><br />
        <strong>Imports:</strong> <a href="mailto:Marketing@example.com">GB.IMPORT@maersk.com </a>
    </address>
</asp:Content>
