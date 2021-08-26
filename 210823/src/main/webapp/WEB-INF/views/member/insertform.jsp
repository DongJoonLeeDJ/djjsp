<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style type="text/css">
	input {
		margin: 10px 0;
	}
</style>
</head>
<body>
<h1>insertform</h1>
<form action="memberinsert">
	아이디<br>
	<input type="text" name="id"/><br>
	비밀번호<br>
	<input type="text" name="pw"/><br>
	나이<br>
	<input type="text" name="age"/><br>
	성별<br>
	<input type="text" name="gender"/><br>
	<input type="submit" value="이동"/>
</form>
</body>
</html>