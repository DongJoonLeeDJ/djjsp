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
<h1>updateform</h1>
<form action="memberupdate">
	<input type="hidden" name="idx" value="${member.idx}"/>
	아이디<br>
	<input type="text" name="id" value="${member.id}"/><br>
	비밀번호<br>
	<input type="text" name="pw" value="${member.pw}"/><br>
	나이<br>
	<input type="text" name="age" value="${member.age}"/><br>
	성별<br>
	<input type="text" name="gender" value="${member.gender}"/><br>
	<input type="submit" value="이동"/>
</form>
</body>
</html>