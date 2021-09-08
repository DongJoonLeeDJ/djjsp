<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1 style="color:springgreen; background:blue">공부해라</h1>
	<% out.println("너의 나이는 "+request.getParameter("age")+"야."); %>
</body>
</html>