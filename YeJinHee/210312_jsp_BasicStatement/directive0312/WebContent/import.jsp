<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.sql.Timestamp"%>
<%@ page import="java.util.Date"%>
<%@ page import="java.text.SimpleDateFormat"%>
<%@ page info="Copyright by 홍길동" %>
<%@ page session="true" %> <!-- 보통 세션이나 쿠키(사용자 PC) -->
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>directive import 속성</title>
</head>
<body>
	<h2>page 디렉티브 - import 속성</h2>
	<%
	Timestamp now = new Timestamp(System.currentTimeMillis());
	SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
	String strDate = format.format(now);
	
	Date nowTime = new Date();
	SimpleDateFormat date 
		= new SimpleDateFormat("yyyy년 MM월 dd일 a hh시 mm분 ss초");
	%> <!-- a는 오전오후 -->

	<h1> 오늘은 <%=strDate%> 입니다.</h1>
	<h1> 현재 날짜와 시간은 <%=date.format(nowTime)%> 입니다.</h1>
	<h2> 저작 <%= getServletInfo() %> </h2><!-- 내장된 메소드 -->
	
	
</body>
</html>