<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Customer>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>
<%@ Import Namespace="MyMVCApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	New
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add New Customer</h2>

<%= Html.FluentTextBox("myTextBox",String.Empty)
    .OnFocus("doSomething();")
    .OnBlur("donothing();")
    
    %> 



</asp:Content>
