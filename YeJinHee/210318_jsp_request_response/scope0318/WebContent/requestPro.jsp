<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%
request.setCharacterEncoding("UTF-8");	

String num = request.getParameter("num");
String name = request.getParameter("name");
String grade = request.getParameter("grade");
String subject = request.getParameter("subject");
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
table{border-collapse:collapse; border: 1px solid;}
td{ border:1px solid; width: 100px; height: 30px; padding: 10px,4px;}
</style>
</head>
<body>
	<h2>학생 정보</h2>
	<table>
		<tr>
		<td>학번</td>
		<td><%=num %></td>
		</tr>	
		<tr>
		<td>이름</td>
		<td><%=name %></td>
		</tr>	
		<tr>
		<td>학년</td>
		<td><%=grade %></td>
		</tr>	
		<tr>
		<td>선택과목</td>
		<td><%=subject %></td>
		</tr>	
	</table>
</body>
</html>