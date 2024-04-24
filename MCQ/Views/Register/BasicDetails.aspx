<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="BusinessObjects.Utils"%>
<%@ Import Namespace="MyMVCApplication"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<% using (Html.BeginForm())
   { %>

<%= Html.Hidden("Customer",SerializationUtility.Serialize(Model)) %>

FirstName: <%= Html.TextBox("FirstName")%> <br />
LastName: <%= Html.TextBox("LastName")%> 

<input type="submit" value="Next" name="nextButton" />

<% } %>



</asp:Content>
