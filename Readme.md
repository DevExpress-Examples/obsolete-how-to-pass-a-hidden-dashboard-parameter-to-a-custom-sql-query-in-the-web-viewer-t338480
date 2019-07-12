<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/Dashboard_CustomParameters_Web/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_CustomParameters_Web/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/Dashboard_CustomParameters_Web/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_CustomParameters_Web/WebForm1.aspx.vb))
<!-- default file list end -->
# How to pass a hidden dashboard parameter to a custom SQL query in the Web Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t338480/)**
<!-- run online end -->


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example shows how to filter a custom SQL query by changing a parameter value in the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_CustomParameterstopic">ASPxDashboardViewer.CustomParameters</a> event handler.</p>
<p>In this example, the <strong>custIDQueryParameter</strong> query parameter is included in a WHERE clause of a <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument115212">custom SQL query</a>. The <strong>custIDQueryParameter </strong>parameter is also bound to the hidden <strong>custIDDashboardParameter</strong> dashboard parameter. The value of this parameter is changed at runtime by handling the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_CustomParameterstopic">ASPxDashboardViewer.CustomParameters</a>  event which is raised before the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a> sends a query to a database.<br><br><strong>See also: </strong><a href="https://www.devexpress.com/Support/Center/p/T475791">How to specify default parameter values in the Web Viewer</a></p>

<br/>


