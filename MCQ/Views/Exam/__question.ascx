<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Question>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>

<div class="question">

<%= Html.Hidden("Exam.Questions[" + Model.OrderNumber +"].Id",Model.Id) %>

<%= Model.Text %>  <div class="points"> (<%= Model.Point %>) </div> <br />

<% foreach (var choice in Model.Choices)
   { %>

    <% Html.RenderPartial("__choice",choice); %> <br />

<%
      
   } %>
   
   </div>
   
    
    