<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%
	// 변수 선언
	int num1 = 100;
	int num2 = 200;
	int result = num1 + num2;
	String name = "홍길동";
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>스크립틀릿</title>
</head>
<body>
	<div><h3>1. 변수 out.print(result) : <% out.print(result);%></h3></div>
	<div><h2>2. 변수 num1+num2 : <% out.println(num1+num2); %></h2></div>
	<div><h1>3. 연산 결과 result: <%= result %></h1></div>
	<div><h2>4. 변수 name 이름: <%=name %></h2></div>
</body>
</html>