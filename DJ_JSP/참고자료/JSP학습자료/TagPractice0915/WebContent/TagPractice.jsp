<%@ page language="java" contentType="text/html; charset=EUC-KR"
	pageEncoding="EUC-KR"%>
<%@page import="java.util.Arrays"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
	<%--지시자 : <%@ %> :페이지 속성
	주석 : <%-- --%>
	<%-- 	선언: <%! %> :변수, 메소드 선언
	표현식: <%= %> :결과값 출력
	스크립트릿 : <%  %> : java코드
	액션태그: <jsp:action></jsp:action> :자바빈연결--%>

	<%
		int i = 0;
	while (true) {
		i++;
		out.println("2 *" + i + "=" + (2 * i) + "<br/>");
	%>

	=============
	<br />
	<%
		if (i >= 5)
		break;
	}
	%>
	<br />
	====Arrays import====
	<%
	int[]iArr={10,20,30};
	%>
	<br />
	<br />
	<%
	out.println(Arrays.toString(iArr));
	%>
	<h1>include파일로 이동!</h1>
	<%@ include file="include.jsp" %> <%--include.jsp의 내용이 나온다. --%>
	<a href="include.jsp">include.jsp로!</a> <%--하이퍼링크로 include.jsp로 이동하도록 만듬 --%>
</body>
</html>