<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page errorPage="Error.jsp"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		int i = 10;
		int j = 0;
		int c = i/j; //0으로 나누게 되면 숫자가 무한대이므로 에러가 남
	%>
</body>
</html>