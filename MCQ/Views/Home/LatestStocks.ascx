<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Stock>>" %>
<%@ Import Namespace="MyMVCApplication.Models"%>

<div id="divLatestStocks">





<table>
<tr>
<td>
<b>Name </b>
</td> 
<td>
<b>Price </b>
</td> 
<td>
<b>Last Price</b>
</td>
</tr>

<% foreach (var stock in Model)
   { %>
   
    <tr>
    <td>
    <%= stock.Name %>
    </td>
    <td>
    
    <% if (stock.Price > stock.LastPrice)
       { %>    
       
    <span class="stockUp"> <%= stock.Price %> </span>
    
    <% }

       else
       { 
        %>
        
        <span class="stockDown"> <%= stock.Price %> </span>
        
        <% } %>
    
    
    </td>
    <td>
    <%= stock.LastPrice %>
    </td>    
    </tr>

<% } %>

</table>

</div>

