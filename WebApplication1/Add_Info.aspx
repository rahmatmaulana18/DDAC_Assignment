<%@ Page Title="Add Record" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_Info.aspx.cs" Inherits="CMS.Add_Info" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Record</h2>
    <h3>Please fill all the information</h3>
    
    <div class="row">
        Ship name:<br>
        <input type="text" name="shipname" value="" runat="server" id="shipname">
        <br>
        Shipment size:<br>
        <input type="text" name="shipmentsize" value="" runat="server" id="shipmentsize">
        <br>
        Shipment Date:<br>
        <input type="text" name="shipmentdate" value="" runat="server" id="shipmentdate">
        <br>
        Shipment Location:<br>
        <input type="text" name="shipmentlocation" value="" runat="server" id="shipmentlocation">
        <br>
        Shipment Status:<br>
        <input type="text" name="shipmentstatus" value="" runat="server" id="shipmentstatus">
        <br>
        <br>
        <input class="btn btn-default" type="submit" value="Submit" runat="server" onserverclick="addRecord">
    </div>
</asp:Content>
