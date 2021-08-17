<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	request.setCharacterEncoding("UTF-8");
String id = request.getParameter("id");
String hobby = request.getParameter("hobby");
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link href="m.css" rel="stylesheet" type="text/css">
</head>
<body>
	<div class="c">
		<h2>forwardTest.jsp에서 포워딩 되었음.</h2>
		<h1>
			ID :
			<%=id%></h1>
		<br>
		<h1>
			취미:
			<%=hobby%></h1>
	</div>
</body>
</html>