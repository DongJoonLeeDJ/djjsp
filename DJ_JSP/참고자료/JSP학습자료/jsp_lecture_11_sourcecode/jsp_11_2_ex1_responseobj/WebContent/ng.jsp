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
	int age;
%>

<%
	String str = request.getParameter("age");
	age = Integer.parseInt(str);
%>

미성년자 입니다. 주류구매가 불가능 합니다.

<a href="requestex.html">처음으로 이동</a>
</body>
</html>