<%@page import="java.util.Enumeration"%>
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
// 		Cookie[] cookies = request.getCookies();
// 		for(int i = 0; i<cookies.length; i++)
// 		{
// 			String id = cookies[i].getValue();
// 			System.out.println(id);
// 			if(id.equals("aaa"))
// 			{
// 				out.println(id + "님 안녕하세요. </br>");
// 			}
// 		}

		//순서대로 객체를 넣고 싶을 때
		//ArrayList같은 것
		//각각의 객체들을 한순간에 하나씩 처리할 수 있는 메소드를 제공하는 켈렉션
		//출처: https://hyeonstorage.tistory.com/210 [개발이 하고 싶어요]
		//https://kutar37.tistory.com/entry/%EC%9E%90%EB%B0%94-Iterator-Enumeration-%EC%9D%B8%ED%84%B0%ED%8E%98%EC%9D%B4%EC%8A%A4
		Enumeration enumeration = session.getAttributeNames();
		while(enumeration.hasMoreElements())
		{
			String sName = enumeration.nextElement().toString();
			String sValue = (String)session.getAttribute(sName);
			
			if(sValue.equals("aaa"))
			{
				out.println(sValue + "님 안녕하세요. </br>");
			}
		}
		
	%>
	
	<a href="logout_session.jsp">로그아웃</a>
</body>
</html>