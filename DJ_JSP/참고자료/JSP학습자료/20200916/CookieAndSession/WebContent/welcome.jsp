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
		for(int i = 0; i<cookies.length; i++)
		{
			String id = cookies[i].getValue();
			System.out.println(id);
			if(id.equals("aaa"))
			{
				out.println(id + "님 안녕하세요. </br>");
			}
		}
	%>
	
	<a href="logout.jsp">로그아웃</a>
</body>
</html>