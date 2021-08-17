<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%
request.setCharacterEncoding("UTF-8");
String name = request.getParameter("name");
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
* {
	margin: 0;
}
.a {
	background-color: lightgray;
	padding: 20px;
}
</style>
</head>
<body>
	<div class="a">
		<h1>포함되는 페이지 : includedTest.jsp</h1>
		<h2><%=name%>
			님이 입장하셨습니다.
		</h2>
	</div>
</body>
</html>