<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>

	<%
		Cookie[] cookies = request.getCookies();
		for(int i=0; i<cookies.length; i++) {
			String str = cookies[i].getName();
			if(str.equals("cookieN")) {
				out.println("name : " + cookies[i].getName() + "<br />");
				cookies[i].setMaxAge(0);
				response.addCookie(cookies[i]);
			}
		}
	%>
	
	<a href="cookietest.jsp">쿠키확인</a>

</body>
</html>

