<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>sessionRes.jsp</title>
<style>
body {
	background-color: #CBCBCB;
}
</style>
</head>
<body>
	<h1>로그인정보 sessionRes.jsp</h1>
	세션ID : 	<%=session.getId()%><br>
	ID : <%=session.getAttribute("id")%><br>
	
	<h2>세션종료</h2>
	<% session.invalidate(); %>
	<a href="sessionForm.jsp">로그아웃</a>
</body>
</html>