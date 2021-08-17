<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page isErrorPage="true"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>에러 페이지</title>
<style>
h3, h4 {
	text-align: center;
}

div {
	text-align: center;
}
h1.#title{font-size: 50px;}
</style>
</head>
<body>
	<div>
	<h1 id="title">404</h1>
		<img src="error.png">
	</div>

	<h3>요청하신 페이지에서 문제가 발생했습니다.</h3>
	<h4>
		서비스 사용에 불편을 드려서 대단히 죄송합니다<br> 빠른 시간내에 문제를 처리하겠습니다.
	</h4>

	<h3>
		예외 타입:<%=exception.getClass().getName()%></h3>
	<h4>
		에러 메시지:
		<%=exception.getMessage()%></h4>
</body>
</html>