<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>입력받은 숫자 비교</title>
</head>
<body>
	<h2>입력받은 숫자가 10보다 작거나 같은지 비교</h2>
	<%
	String strNumber = request.getParameter("number");
	int num = Integer.parseInt(strNumber);
	if (num <= 10) { 
	%>
	<h3>입력받은 숫자는 <%=num%></h3>
	<%
	}
	%>

</body>
</html>