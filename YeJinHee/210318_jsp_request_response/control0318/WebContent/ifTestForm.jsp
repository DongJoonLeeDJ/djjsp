<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>값을 입력하는 폼</title>
</head>
<body>
	<h2>숫자 값을 입력하세요</h2>
	
	<!-- post: 변수숨김 / get: 정보 달고 들어감 / number > ifTestPro.jsp -->
		<!-- 같은 폴더 내
		<form method="get" action="ifTestPro.jsp"> -->
		<!-- 상대경로
		<form method="post" action="calc/ifTestPro.jsp"> -->
		
		<!-- 절대경로
		<form method="post" action="/control0318/calc/ifTestPro.jsp"> -->
		<!-- 절대경로 url 사용
		<form method="post" action="http://localhost:8080/control0318/calc/ifTestPro.jsp"> -->
		
		<form method="post" action="http://localhost:8080/control0318/calc/ifTestPro.jsp">
		<input type="text" name="number">
		<input type="submit" value="입력완료">
	</form>
</body>
</html>