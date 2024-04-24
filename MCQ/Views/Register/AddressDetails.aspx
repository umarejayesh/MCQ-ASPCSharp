<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AddressDetails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>AddressDetails</h2>

<% using (Html.BeginForm())
   { %>

Street: <%= Html.TextBox("Street")%> <br />
City: <%= Html.TextBox("City")%> <br />
State: <%= Html.TextBox("State")%> <br />

<input type="submit" value="Next" name="nextButton" />
<input type="submit" value="Back" name="backButton" />


<% } %>



</asp:Content>
