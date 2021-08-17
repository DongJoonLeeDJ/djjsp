<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page isErrorPage="true"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>404 에러</title>
<link rel="preconnect" href="https://fonts.gstatic.com">
<link
	href="https://fonts.googleapis.com/css2?family=Russo+One&display=swap"
	rel="stylesheet">
<link href="m_err.css" rel="stylesheet" type="text/css">
<style type="text/css">
</style>
</head>
<body>
	<div>
		<p class="code">404</p>
		<img alt="페이지를 찾을 수 없습니다." src="/actionTag0319/image/error404.png">
		<h2>페이지를 찾을 수 없습니다.</h2>

		<!-- [동작되는 코드] -->

		<!--
		<img alt="페이지를 찾을 수 없습니다." src="/actionTag0319/image/error404.png"> 
		<img alt="페이지를 찾을 수 없습니다."
			src="http://localhost:8080/actionTag0319/image/error404.png"> -->

		<!-- [동작안됨] /error/error404.jsp 
		<!-- <img alt="페이지를 찾을 수 없습니다." src="/image/error404.png"> -->

	</div>

</body>
</html>