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

�̸� : <%= name %><br />
���̵� : <%= id %><br />
��й�ȣ : <%= pw %><br />
��� : <%= Arrays.toString(hobbys) %><br />
���� : <%= major %><br />
�������� : <%= protocol %><br />
</body>
</html>