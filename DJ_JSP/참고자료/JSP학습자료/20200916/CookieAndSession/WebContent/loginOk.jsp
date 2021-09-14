<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
	<%! String id, pw; %>
	<%
		id = request.getParameter("id");
		pw = request.getParameter("pw");
		
		//로그인 성공   ID는 aaa이고 비밀번호 1234라고 가정
		if(id.equals("aaa") && pw.equals("1234"))
		{
			Cookie cookie = new Cookie("id", id);
			cookie.setMaxAge(60); // 쿠키의 유효기간. 1분이 지나면 자동으로 삭제된다.
			response.addCookie(cookie); //응답하는 response 객체 안에 쿠키를 담는다.
			response.sendRedirect("welcome.jsp");
		}
		else //로그인 실패
		{
			response.sendRedirect("Login.html");
		}
	%>
</body>
</html>