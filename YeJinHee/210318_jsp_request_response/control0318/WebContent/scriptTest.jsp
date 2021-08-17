<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%-- 주석 --%>
<%-- 
	선언문(declation)		: <%!	%>	- 전역변수 선언, 메쏘드 선언
	스크립틀릿(scriptlet)	: <%	%>	- 지역변수, 일반 루틴(문장)
	표현식(expression)	: <%=	%>	- 화면 출력(변수, 메쏘드 호출)  
--%>

<%!
	// 일반 자바 주석
	/* 일반 자바 주석 */
	int num = 100;
	public int sum(int n1, int n2) {
		return n1 + n2;
	}

	public int sub(int n1, int n2) {
		return n1 - n2;
	}
%>
<%
	int num = 10;
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div><h1>덧셈 결과: <%=sum(100,50) %></h1> </div>
	<div><h1>뺄셈 결과: <%=sub(100,50) %></h1> </div>
	<div>num: <%=num %></div>
</body>
</html>