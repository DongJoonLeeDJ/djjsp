<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<!-- java 연산 상의 오류으로 500 에러 유발  -->
	<% int i = 100/0; %>
	<% Integer.parseInt("aaaa"); %>
</body>
</html>