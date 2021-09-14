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
		//쿠키를 지우는 프로세스
		
		Cookie[] cookies = request.getCookies(); //request 객체에 있는 모든 쿠키들을 한 배열에 넣는다.
		
		if(cookies != null)
		{
			//쿠키 배열 길이만큼 반복문 수행
			for(int i = 0; i <cookies.length; i++)
			{
				if(cookies[i].getValue().equals("aaa")) //삭제 프로세스 시작
				{
					//MaxAge 를 0으로 바꾼다.
					cookies[i].setMaxAge(0);
					//그걸 다시 addCookie 한다.
					//response.addCookie(cookies[i]);
				}
			}
		}
		
		//로그아웃을 하였다면 다시 로그인 페이지로 이동
		//response.sendRedirect("Login.html");
		
		//현재 남아있는 쿠키값들을 출력하는 페이지로 이동
		response.sendRedirect("cookietest.jsp");
	
	%>
</body>
</html>