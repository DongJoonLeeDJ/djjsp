<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<img src="https://d2u3dcdbebyaiu.cloudfront.net/uploads/atch_img/811/2c6c1b6df81d794b48d4044d8a652d8b.jpeg" alt="" />
	<!--isErrorPage=true 일 때 exception 객체 사용 가능  -->
	<%out.println( exception.getMessage() );%>
</body>
</html>