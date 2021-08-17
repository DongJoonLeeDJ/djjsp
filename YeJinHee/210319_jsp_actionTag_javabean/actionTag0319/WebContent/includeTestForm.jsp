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
	<h2>include action tag</h2>
	<div>
	<form method="post" action="includeTest.jsp">
		<table>
			<tr>
				<td>이름</td>

				<td><input type="text" name="name"><br></td>
			</tr>

			<tr>
				<td>페이지 이름</td>
				<td><input type="text" name="pageName" value="includedTest">
				</td>
			</tr>
		</table>
		<div class="button">
		<input type="submit" value="입력완료"></div>
	</form>
	</div>

</body>
</html>