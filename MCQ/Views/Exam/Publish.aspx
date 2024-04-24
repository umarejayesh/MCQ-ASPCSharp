<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Exam>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Publish
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
   <h1> <%= Model.Name %> </h1>
   <br />      
    
    <%= Html.Hidden("Id", Model.Id ) %>
    
  <% using (var form = Html.BeginForm(new { Action = "Grade"}))
     { %>  
    
    
    <% foreach (var question in Model.Questions)
       { %>
    
        <% Html.RenderPartial("__question", question); %>           
     
     <br />
     
    <% } %>
    
    <input type="submit" value="Submit" />
    
   
    
<% } %>

</asp:Content>
