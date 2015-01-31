<%
Dim MyComObject
Dim MyText

Set MyComObject = Server.CreateObject("Launcher.Launcher")

MyText = MyComObject.Hello()


%>
<html>
<head></head>
<body>
	<%=MyText %>
</body>
</html>
