<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%
	request.setCharacterEncoding("UTF-8");
String id = request.getParameter("id");

if (id.equals("")) {
	out.println("<script> alert('아이디를 입력하세요');</script>");
	response.sendRedirect("sessionForm.jsp");
}
session.setAttribute("id", id);
String url = response.encodeUrl("sessionRes.jsp");
%>
<!DOCTYPE html>
<html>
<head>
<style>body{background-color: #B7ABF9;}</style>
<meta charset="UTF-8">
<title>urlSession.jsp</title>
</head>
<body>
	<h1>urlSession.jsp</h1>
	세션ID : <%=session.getId() %><br>
	ID : <%=session.getAttribute("id") %><br>
	<a href="<%=url%>">Test1</a><br>
	<a href="sessionRes.jsp">Test2</a>
</body>
</html>