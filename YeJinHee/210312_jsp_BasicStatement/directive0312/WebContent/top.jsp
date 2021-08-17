<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.sql.Timestamp"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style type="text/css">
.a{background-color: yellow;}
</style>
</head>
<body>
	<%
	Timestamp now = new Timestamp(System.currentTimeMillis()); 
	%>
	<h1 class="a">TOP 파일입니다.</h1>
	<h2 class="a"><%= now.toString() %></h2>
</body>
</html>