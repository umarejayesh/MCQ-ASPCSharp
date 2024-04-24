<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="BusinessObjects.Entities"%>
<%@ Import Namespace="MyMVCApplication"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	DemoGrid
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>DemoGrid</h2>

    <table>
    <tr>
    <td>
    First Name
    </td>
    <td>
    Last Name
    </td>
    </tr>
    

    <% foreach (var customer in (ViewData["Customers"] as IEnumerable<Customer>))
       { %>
    
    <tr>
    <td>
    <%= customer.FirstName %>
    </td>
    <td>
    <%= customer.LastName %>
    </td>
    </tr>           
        
    
    <% } %>
    
    </table>
    

</asp:Content>
