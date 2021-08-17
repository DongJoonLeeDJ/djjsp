<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
String name = request.getParameter("name");
int age = Integer.parseInt(request.getParameter("age"));

if (age >= 20) {
	out.println("<h2>\"" + name + "\"</h2> 님의 나이는 <b>성인</b>입니다.");
} else {
	out.println("<h2>\"" + name + "\"</h2> 님의 나이는 <b>미성년자</b>입니다.");
}
%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
* {
	font-size: 15pt;
	font-weight: 100;
}

h2 {
	display: inline;
	font-weight: 300
}
</style>
</head>
<body>

</body>
</html>