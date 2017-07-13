<%@ Page Title="Delete Record" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete_Info.aspx.cs" Inherits="CMS.Delete_Info" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Delete Record</h2>
    <h3>Please select the information that needs to be updated</h3>
    
    <div class="row">
        <div id="shipmentDetails">
            <table class="table table-striped">
                <thead>
                  <tr>
                    <th>ShipmentID</th>
                    <th>Shipname</th>
                    <th>ShipmentSize</th>
                    <th>ShipmentDate</th>
                    <th>ShipmentLocation</th>
                    <th>ShipmentStatus</th>
                  </tr>
                </thead>
                <tbody>
                <asp:ListView ID="shipmentList"
                    ItemType="CMS.Models.ShipmentActivity"
                    runat="server"
                    SelectMethod="getShipmentList">
                        <ItemTemplate>
                            <tr>
                                <td><%#: Item.ShipmentID %></td>
                                <td><%#: Item.Shipname %></td>
                                <td><%#: Item.ShipmentSize %></td>
                                <td><%#: Item.ShipmentDate %></td>
                                <td><%#: Item.ShipmentLocation %></td>
                                <td><%#: Item.ShipmentStatus %></td>
                            </tr>
                        </ItemTemplate>
                 </asp:ListView>
                 </tbody>
             </table>
        </div>
        <br>
        <br>
    </div>

    <div class="row">
        <h3>Enter Shipment ID to be deleted:</h3>
        <input type="text" name="shipmentid" value="" runat="server" id="shipmentid">
        <br>
        <br>
        <input class="btn btn-default" type="submit" value="Submit" runat="server" onserverclick="deleteRecord">
    </div>
</asp:Content>
