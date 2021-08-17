<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>out 내장 객체</title>
</head>
<body>
	<h2>out 내장 객체</h2>
	<%
	String name = "홍길동";
	out.println("웹브라우저 화면 출력: "+name);
	%>
	
	<h2>동일 표현 방식</h2>
	웹브라우저 화면 출력: <%=name %>
</body>
</html>