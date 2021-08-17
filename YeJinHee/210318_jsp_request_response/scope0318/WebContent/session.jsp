<%@page import="java.text.SimpleDateFormat"%>
<%@page import="java.util.Date"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
Date date = new Date();
SimpleDateFormat sf = 
	new SimpleDateFormat("yyyy-MM-dd HH:mm:ss"); 
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<!-- 쿠키, 세션 -->
	<h2>
	세션 ID : <%= session.getId() %><br>
	<%date.setTime(session.getCreationTime()); %>
	세션 생성 시간 : <%=sf.format(date) %><br>
	<% date.setTime(session.getLastAccessedTime()); %>
	최종 접속 시간 : <%=sf.format(date) %>
	</h2>
</body>
</html>