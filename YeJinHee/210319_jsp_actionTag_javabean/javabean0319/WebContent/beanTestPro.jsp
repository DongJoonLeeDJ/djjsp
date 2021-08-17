<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	request.setCharacterEncoding("UTF-8"); 
String name = request.getParameter("name"); 
%>
<jsp:useBean id="testBean" class="dto.TestBean">
	<jsp:setProperty name="testBean" property="name" />
	<!-- java - setter 호출 -->
</jsp:useBean>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>
		입력된 이름:
		<jsp:getProperty property="name" name="testBean" />
		<!-- java - getter 호출 -->
	</h2>
</body>
</html>