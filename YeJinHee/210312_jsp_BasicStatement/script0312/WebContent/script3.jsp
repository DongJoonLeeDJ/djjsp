<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%-- 
	선언문(declation)		: <%!	%>	- 전역변수 선언, 메쏘드 선언
	스크립틀릿(scriptlet)	: <%	%>	- 지역변수, 일반 루틴(문장)
	표현식(expression)	: <%=	%>	- 화면 출력(변수, 메쏘드 호출)  
--%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<% 
		String str2 = "2. 홍길동";
	%>
	<%!
		String str = "1. 전역 변수";
	%>
	<%!
		public String getStr(){
			return str;
		}
	%>	
	<!-- html 주석 <h1>전역변수: <%=str %></h1> --> 
	<%-- jsp  주석 <h1>전역변수: <%=str %></h1> --%>
	<h1>전역변수: <%=str %></h1>
	<h2>메쏘드 호출: <%=getStr() %></h2>
	<h3>지역변수: <%=str2 %></h3>
</body>
</html>