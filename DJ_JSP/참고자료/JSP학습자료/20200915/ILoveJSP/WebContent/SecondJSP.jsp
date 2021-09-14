<%-- <%@page import="java.util.Arrays"%> --%> <!-- JSP 스타일 주석은 클라이언트에서 안 보임 -->
<!-- ctrl + shift + c  = 주석  -->   <!-- HTML 스타일 주석은 클라이언트에서 보임 -->
<%@page import="java.util.Arrays"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<style>
	h1
	{
		color:red;
	}
</style>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>

	<%
		int[] iArr =  {10,20,30};
		out.println(Arrays.toString(iArr));
	%>
	<h1>Hello1</h1>
	<%@ include file="ldjjoon.jsp" %>
	<h1>Hello2</h1>

</body>
</html>