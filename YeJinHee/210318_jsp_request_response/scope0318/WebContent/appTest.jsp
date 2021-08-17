<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%
String info = application.getServerInfo();
String path = application.getRealPath("/");
application.log("로그 기록: ");
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
.a {color: blue; font-weight: 800; display: inline;}
</style>
</head>
<body>
	<h1>application 내장 객체</h1>
	<p class="a"> 웹 컨테이너 이름, 버전 정보 :</p> <%=info%><br>
	<font color="#B6B6B6">(웹 컨테이너 = WAS = 톰캣 / 웹 애플리케이션 서버)</font><br><br>
	
	<p class="a">웹 애플리케이션 폴더의 로컬 시스템 경로 : </p><%=path%>
</body>
</html>