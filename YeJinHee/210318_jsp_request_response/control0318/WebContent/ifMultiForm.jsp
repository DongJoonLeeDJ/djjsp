<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>이름과 전화번호 입력 폼</title> <!-- 클라이언트, front-end -->
</head>
<body>
	<h2>이름과 전화번호를 입력하세요.</h2>
	
	<form method="post" action="ifMultiPro.jsp">
	이름: <input type="text" name="name"><br>
	전화번호: 
	<select name="local">
		<option value="서울">서울 02</option>
		<option value="대구">대구 053</option>
		<option value="부산">부산 051</option>
	</select>
	
	- <input type="text" name="tel"><br>
	<input type="submit" value="입력완료">
	</form>
</body>
</html>