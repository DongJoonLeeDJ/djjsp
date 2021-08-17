<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%
	String param1 = request.getParameter("pa1"); /* 요청된 정보 : 클->서버 */
	String param2 = request.getParameter("pa2");
	
	int num1 = Integer.parseInt(param1);
	int num2 = Integer.parseInt(param2);
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body> 
	<div><h1><%=param1%> + <%=param2 %> = <%=num1+num2 %></h1></div> <!-- http://localhost:8080/script0312/script4.jsp?pa1=100&pa2=200 -->
</body>
</html>

