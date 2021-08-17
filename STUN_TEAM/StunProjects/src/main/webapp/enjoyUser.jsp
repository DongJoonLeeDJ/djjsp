<%@ page language="java" 
contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="description" content="HTML Study">
<meta name="keywords" content="HTML,CSS,XML,JavaScript">
<meta name="author" content="Bruce">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>회원가입</title>
</head>

<body>
<form method = "post" action="Result.jsp">
	<table border="1">
		<caption>회원가입</caption>
		
		<tr>
			<td><label for="name">이름 </label></td>
			<td><input type="text" name="name" id="name" required></td>
		</tr>
		
		<tr>
			<td><label for="id">아이디 </label>
			<td><input type="text" name="id" id="id" required></td>
		</tr>
		
		<tr>
			<td><label for="pw">비밀번호 </label>
			<td><input type="password" name="pw" id="pw" required></td>
		</tr>
		
		<tr>
			<td><label for="pwcheck">비밀번호 확인</label></td>
			<td><input type="password" name="pwcheck" id="pwcheck" required> <span id="pwcheckText"></span> </td>
		</tr>
		
		<tr>
			<td><label for="email">이메일</label></td>
			<td><input type="email" name="email" id="email" required>
			<input type="submit" value="인증">
			</td>
		</tr>
		
		<tr>
		<td><label for="phonenumber">전화번호</label> </td>
			<td>
			<select name="phonecompany">
					<option value="SKT">SKT</option>
					<option value="LGT">LGT</option>
					<option value="KT">KT</option>
				</select>
			<input type="phonenumber" name="phonenumber" id="phonenumber" required>
			<br><input type="checkbox" name="phonenumber" value="개인정보동의" id="reading">개인정보동의<br>
				
			</td>
		</tr>
		
		<tr>
			<td colspan="2" style="text-align:center;">
				<input type="submit" value="전송">
				<input type="reset" value="초기화">
			</td>
		</tr>
	</table>
</form>

<script src="js/문제4JS.js"></script>

</body>
</html>