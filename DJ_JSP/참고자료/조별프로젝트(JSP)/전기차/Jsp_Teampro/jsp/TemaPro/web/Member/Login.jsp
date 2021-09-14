<%@ page language="java" contentType="text/html; charset=UTF-8"	pageEncoding="UTF-8"%>
<meta charset="utf-8" />
<link href="CSS/styles.css" rel="stylesheet" />

<script>
function Find_id(){
	location.href='index.jsp?contentPage=Member/Find_Id.jsp';
}
function Find_pw(){
	location.href='index.jsp?contentPage=Member/Find_Pw.jsp';
}
</script>
<form action="./Member/LoginAction.jsp" method="get">
	<div class="main" style="margin-top:100px; margin-bottom:300px;">
	<h2 class="mt-sm-5">로그인</h2>
		<div class="input-box my-3">
			<label class="me-sm-4" for="id">ID&nbsp</label>
			<input id="id" type="text" name="id" placeholder="아이디">	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="pw">PW</label>
			<input id="pw" type="password" name="pw" placeholder="비밀번호"> 
		</div>
		<div class="button-group my-3">
			<input type="submit" class="btn btn-info" value="로그인">
			<input type="button" class="btn btn-info mx-sm-2" value="ID찾기" onclick="Find_id()">
			<input type="button" class="btn btn-info" value="PW찾기" onclick="Find_pw()">
		</div>
	</div>	
</form>
