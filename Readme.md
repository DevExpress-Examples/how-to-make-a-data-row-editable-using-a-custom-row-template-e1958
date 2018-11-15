<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGridTest/Window1.xaml) (VB: [Window1.xaml.vb](./VB/DXGridTest/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/DXGridTest/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGridTest/Window1.xaml.vb))
<!-- default file list end -->
# How to make a data row editable using a custom row template


<p>The main idea is to create a custom row template that allows editing. In the sample, a row template is specified for several editors. To provide correct tabbing between editors, it's necessary to create a custom TableView where you override OnKeyDown and OnKeyUp methods.</p>

<br/>


