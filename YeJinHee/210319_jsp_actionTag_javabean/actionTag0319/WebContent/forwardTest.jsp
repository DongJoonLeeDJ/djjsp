<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	request.setCharacterEncoding("UTF-8");
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link href="m.css" rel="stylesheet" type="text/css">
</head>
<body>
	<div class="a">
		<h1>포워딩하는 페이지 : 화면에 표시되지 않음</h1>
		<!-- forwardToTest.jsp 페이지로 이동(포워딩: 거치고 다시 돌아감) -->
		<jsp:forward page="forwardToTest.jsp"></jsp:forward></div>
</body>
</html>