<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<%
	Cookie[] cookies = request.getCookies();
	if(cookies != null)
	{
		for(int i=0; i<cookies.length; i++)
		{
			out.println(cookies[i].getName() + "<br/>");
			out.println(cookies[i].getValue() + "<br/>");
		}
	}
%>
</body>
</html>