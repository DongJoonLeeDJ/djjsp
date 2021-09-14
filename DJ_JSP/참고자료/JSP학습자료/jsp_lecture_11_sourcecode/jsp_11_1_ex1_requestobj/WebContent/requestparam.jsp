<%@page import="java.util.Arrays"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
<%!
	String name, id, pw, major, protocol;
	String[] hobbys;
%>

<%
	request.setCharacterEncoding("EUC-KR");
	
	name = request.getParameter("name");
	id = request.getParameter("id");
	pw = request.getParameter("pw");
	major = request.getParameter("major");
	protocol = request.getParameter("protocol");
	
	hobbys = request.getParameterValues("hobby");
%>

이름 : <%= name %><br />
아이디 : <%= id %><br />
비밀번호 : <%= pw %><br />
취미 : <%= Arrays.toString(hobbys) %><br />
전공 : <%= major %><br />
프로토콜 : <%= protocol %><br />
</body>
</html>