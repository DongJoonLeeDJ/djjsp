<%-- <%@page import="java.util.Arrays"%> --%> <!-- JSP ��Ÿ�� �ּ��� Ŭ���̾�Ʈ���� �� ���� -->
<!-- ctrl + shift + c  = �ּ�  -->   <!-- HTML ��Ÿ�� �ּ��� Ŭ���̾�Ʈ���� ���� -->
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