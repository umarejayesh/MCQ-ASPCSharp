<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Category>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	New
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>New Category</h2>
    
    <% using (var form = Html.BeginForm(new { Action = "Create" }))
       { %>     
      
    Category Name: <%= Html.TextBox("Name")%>   
    
    <div id="products">
    
    </div>
    
      
    <input id="btnAddProduct" type="button" value="Add Product" />    
        
    
    <input type="submit" value="Create" />
    
    <% } %>
    
    <script language="javascript" type="text/javascript">

        (function() {

        var noOfProducts = 0;
         
         $("#btnAddProduct").click(function() {    
                     
           
           var product = getNestedItemName("Category.Products",noOfProducts);           

           // increment for the next one! 
           noOfProducts++;

           // append a new textbox inside the products div           

           $("#products").append("<input type='text' name='" + product + ".Name' /><p>");

       });

       function getNestedItemName(itemName,itemNumber) {

           return ( itemName + "[" + itemNumber + "]" );           
       } 
        
        
        
         })();
      
      
      
  
    
    </script>
    
    

</asp:Content>
