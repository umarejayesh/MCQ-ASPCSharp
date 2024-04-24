<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="MyMVCApplication"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    
    <% using(Html.BeginForm( new { Action="Register"}  ))
 {
 %>    
       
    <%= Html.Captcha() %>
    <%=Html.TextBox("captcha")%>
    
    <input type="submit" value="Submit" />
    
    <%
  
}%>
    

</asp:Content>
