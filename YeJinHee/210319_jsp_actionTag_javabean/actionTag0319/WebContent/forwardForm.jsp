<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link href="m.css" rel="stylesheet" type="text/css">
</head>
<body>
	<h1>forward action tag</h1>
	<div>
		<form method="post" action="forwardTest.jsp">
			<table>
				<tr>
					<td>아이디</td>
					<td><input type="text" name="id"></td>
				</tr>
				<tr>
					<td>취미</td>
					<td><select name="hobby">
							<option value="wow">wow</option>
							<option value="만화보기">만화보기</option>
							<option value="게임하기">게임하기</option>
					</select></td>
				</tr>
			</table>
			<div class="button">
				<input type="submit" value="입력완료">
			</div>
		</form>
	</div>
</body>
</html>