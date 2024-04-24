<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Category>>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>
<%@ Import Namespace="Microsoft.Web.Mvc"%>

<%@ OutputCache Duration="60" VaryByParam="None" %>

<h2>Categories</h2>

Categories.ascx: <%= DateTime.Now.ToLongTimeString() %>

<br />

<% foreach (var category in Model)
   { %>
  
  <li> <%= category.Name %> </li>    

<% } %>



