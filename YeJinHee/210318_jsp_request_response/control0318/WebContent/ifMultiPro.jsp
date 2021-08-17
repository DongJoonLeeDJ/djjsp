<%@page import="jdk.internal.misc.FileSystemOption"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
// 한글 처리 - post방식
request.setCharacterEncoding("UTF-8");
%>

<!-- 서버, back-end -->
<!-- 프론트 - 서버, 백엔드(jsb) - 자바빈즈 - DB -->
<%
String name = request.getParameter("name");
String local = request.getParameter("local");
String tel = request.getParameter("tel");
// 디버깅
System.out.println("tel: "+tel);
out.println("tel: "+tel);

String localNum = "";

if(local.equals("서울")){
	localNum = "02";
} 
else if(local.equals("대구")){
	localNum = "053";
} 
else if(local.equals("부산")){
	localNum = "051";
} out.println("<br><h2> \""+name +"\"</h2>님의 전화번호는 "+
		localNum+"-"+tel+"입니다."); //태그 같이 쓸 수 있음
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>결과</title>
<style>
h2{display: inline;}
</style>
</head>
<body>

</body>
</html>