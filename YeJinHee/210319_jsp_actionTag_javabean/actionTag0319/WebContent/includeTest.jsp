<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	request.setCharacterEncoding("UTF-8");
String pageName = request.getParameter("pageName");
pageName += ".jsp";
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
* {
	margin: 0;
}

.b {
	background-color: skyblue;
	padding: 20px;
}
</style>
</head>
<body>
	<div class="b">
		<h1>포함되는 페이지 : includeTest.jsp</h1>
		<jsp:include page="<%=pageName%>"></jsp:include>
		<!-- 액션태그 -->
	</div>
</body>
</html>