<%@page import="java.util.Enumeration"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
String name[] = { "프로토콜 이름", "서버이름", "Method방식", 
		"컨텍스트 경로", "URI", "접속한 클라이언트 IP" };
String values[] = {
		request.getProtocol(),
		request.getServerName(),
		request.getMethod(),
		request.getContextPath(),
		request.getRequestURI(),
		request.getRemoteAddr()
};

Enumeration<String> en = request.getHeaderNames();
String headerName = null;
String headerValue = null;
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>request 내장 객체</title>
</head>
<body>

	<h2>✅ 브라우저와 웹 서버 정보</h2>
	<%
	for(int i = 0; i<name.length; i++){
		out.println(name[i]+" : "+values[i]+"<br>");
	}
	%>
	<h2>✅ 헤더 정보 표시</h2>
	<%
	while (en.hasMoreElements()){
		headerName = en.nextElement();
		headerValue = request.getHeader(headerName);
		out.println(headerName+" : "+headerValue+"<br>");
	}
	%>
	<!-- 
	request > response 후 끊어짐 
	URI콘텐츠경로 
	
	[+] 게시판, rest
	-->
</body>
</html>