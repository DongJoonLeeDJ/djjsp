<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<meta charset="utf-8" />
<script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
<script>
function Login(){
	location.href='index.jsp?contentPage=Member/Login.jsp';
}
function Find_pw(){
	location.href='index.jsp?contentPage=Member/Find_Pw.jsp';
}
</script>
<form action="./Member/Find_IdAction.jsp" method="get">
	<div class="main" style="margin-top:100px; margin-bottom:300px;">
	<h2 class="mt-sm-5">아이디 찾기</h2>
		<div class="input-box my-3">
			<label class="me-sm-4" for="uname">이름&nbsp&nbsp&nbsp</label>
			<input class="col-2 mb-sm-2" id="uname" type="text" name="uname" placeholder="아이디">	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="umail">이메일</label>
			<input class="col-2 mb-sm-2" id="umail" type="text" name="umail" placeholder="OOOO@OOOOOO.OOO"> 
		</div>
		<div class="button-group my-3">
			<input type="button" class="btn btn-info" value="로그인" onclick="Login()">
			<input type="submit" class="btn btn-info mx-sm-2" value="ID찾기">
			<input type="button" class="btn btn-info" value="PW찾기" onclick="Find_pw()">
		</div>
	</div>	
</form>