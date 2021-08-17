<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>권역을 선택하세요</h2>

	<form method="post" action="switchPro.jsp">
		<input type="radio" name="localNum" value="0" checked>0권역<br>
		<input type="radio" name="localNum" value="1">1권역<br>
		<input type="radio" name="localNum" value="2">2권역<br>
		<input type="radio" name="localNum" value="3">3권역<br>
		<input type="radio" name="localNum" value="4">4권역<br>
		<input type="radio" name="localNum" value="5">5권역<br><br>
		<input type="submit" value="입력완료">
	</form>
</body>
</html>