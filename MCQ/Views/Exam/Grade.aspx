<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Grade>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Grade
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Grade</h2>

    Exam Name: <%= Model.Exam.Name %>
    
    <br />
    
    Total Questions: <%= Model.Exam.Questions.Count %> 
    <br />
    Your Score: <%= Model.Score  %> / <%= Model.Exam.TotalPoints %>
    <br />  

    <% foreach (var question in Model.Exam.Questions)
       { %> 
    
        <% Html.RenderPartial("__question",question); %>
    
    <% } %>

</asp:Content>
