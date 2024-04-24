<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	SimpleValidation
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Simple Validation</h2>
        
   <% using (var form = Html.BeginForm(new { Action = "SimpleValidation" }))
      { %>     
        
        
    <%= Html.ValidationSummary("Errors") %>     
        
   FirstName:  <%= Html.TextBox("FirstName")%>
   <%= Html.ValidationMessage("FirstName","*") %>
   
   LastName: <%= Html.TextBox("LastName")%>
    <%= Html.ValidationMessage("LastName","*") %>
    
    <input type="submit" value="Save" />
    
    <% } %>

</asp:Content>
