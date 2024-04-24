<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Choice>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>




<% if (Model.IsSelected && Model.IsAnswer)
   { %> 

<div style="background-color:lightgreen">
<%= Html.RadioButton("Exam.Questions[" + Model.Question.OrderNumber + "].Choices[0].Id",Model.Id) %>
<%= Model.Text %>
</div>

<% } else { %> 

<%= Html.RadioButton("Exam.Questions[" + Model.Question.OrderNumber + "].Choices[0].Id",Model.Id) %>
<%= Model.Text %>


<% } %>


