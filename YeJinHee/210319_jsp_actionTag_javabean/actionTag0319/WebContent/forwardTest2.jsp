<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
request.setCharacterEncoding("UTF-8");
String id = "jin";
String hobby = "운동하기";
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link href="m.css" rel="stylesheet" type="text/css">
</head>
<body>
	<!-- 페이지 바로 넘어가기 -->
	<div>
	<jsp:forward page="forwardToTest2.jsp">
	<jsp:param value="<%=id %>" name="id"/>
	<jsp:param value="<%=hobby %>" name="hobby"/>
	</jsp:forward>
	</div>
</body>
</html>