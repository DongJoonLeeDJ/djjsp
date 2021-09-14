<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
    <%@page import="java.util.Arrays" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<%!

String name, id, pw, major, protocol,gender;
	String[]hobbys;
%>

<%
request.setCharacterEncoding("utf-8");

name=request.getParameter("name");
id=request.getParameter("id");
pw=request.getParameter("pw");
major=request.getParameter("major");
protocol=request.getParameter("protocol");
gender=request.getParameter("gender");

hobbys=request.getParameterValues("hobby");
%>


이름: <%= name%><br/>
아이디: <%= id %><br/>
비밀번호: <%= pw %><br/>
전공: <%=major %><br/>
프로토콜: <%=protocol %><br/>
성별: <%=gender %><br/>
취미: <%=Arrays.toString(hobbys) %>

</body>
</html>