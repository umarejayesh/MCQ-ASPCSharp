<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="MyMVCApplication.Controllers"%>
<%@ Import Namespace="Microsoft.Web.Mvc"%>

<%@ Register Src ="~/Views/Category/Categories.ascx" TagName="Partial" TagPrefix="mvc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>List</h2>
    
    List.aspx: <%= DateTime.Now.ToLongTimeString() %>
    
    <% Html.RenderAction("PartialList"); %>
    
    <%= Html.ActionLink<CategoryController>( x=> x.List(),"Show List") %>
    
    
    <mvc:Partial runat="server" />
    
</asp:Content>
