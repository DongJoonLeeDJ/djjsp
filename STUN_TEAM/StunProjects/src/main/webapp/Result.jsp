<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import = "java.util.Arrays" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="description" content="HTML Study">
<meta name="keywords" content="HTML,CSS,XML,JavaScript">
<meta name="author" content="Bruce">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>회원가입</title>
</head>
<body>
<%
	request.setCharacterEncoding("UTF-8");
	String name = request.getParameter("name");
	String id = request.getParameter("id");
	String pw = request.getParameter("pw");
	String email = request.getParameter("email");
	String phonecompany = request.getParameter("phonecompany");
	String phonenumber = request.getParameter("phonenumber");

	/* string list = [10];
	for (int i = 0; i<len(list)) */
	
	out.print("이름 : " + name + "<br>");
	out.print("아이디 : " + id + "<br>");
	out.print("비밀번호 : " + pw + "<br>");
	out.print("이메일 : " + email + "<br>");
	out.print("통신사 : " + phonecompany + "<br>");
	out.print("전화번호 : " + phonenumber + "<br>");
	%>
</body>
</html>