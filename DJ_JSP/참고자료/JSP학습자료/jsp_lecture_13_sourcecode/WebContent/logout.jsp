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
		
		if(cookies != null) {
			for(int i=0; i<cookies.length; i++) {
				if(cookies[i].getValue().equals("abcde")){
					cookies[i].setMaxAge(0);
					response.addCookie(cookies[i]);
				}
			}
		}
		
		//response.sendRedirect("login.html");
		response.sendRedirect("cookietest.jsp");
	%>
	
</body>
</html>