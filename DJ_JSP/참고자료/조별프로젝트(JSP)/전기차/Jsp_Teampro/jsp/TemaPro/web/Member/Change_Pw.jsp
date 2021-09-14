<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<meta charset="UTF-8">
<script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
<script>
function changeinfo(){
	location.href='index.jsp?contentPage=Member/Change_Info.jsp';
}
function passwardCheck(){
	var pw1 = $('#upasswd').val();
	var pw2 = $('#upasswd_check').val();
	if(pw1 != pw2){
		$('#submit').prop('disabled',true);
	}
	else if(pw1 == "" && pw2 ==""){
		$('#submit').prop('disabled',true);
	}
	else{
		$('#submit').prop('disabled',false);
	}
}

</script>
<form onsubmit="return submitCheck();" action="Member/Change_PwAction.jsp" method="get">
	<div class="main" style="margin-top:100px; margin-bottom:300px;">
	<h2 class="mt-sm-5">비밀번호 변경</h2>
		<div class="input-box my-3">
			<label class="me-sm-4" for="nowpw">현재 비밀번호&nbsp&nbsp&nbsp</label>
			<input class="col-3 mb-sm-2" id="nowpw" type="password" name="nowpw" placeholder ="현재 비밀번호">	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="upasswd">변경할 비밀번호</label>
			<input class="col-3 mb-sm-2" id="upasswd" onkeyup = "passwardCheck();" type="password" name="upasswd" placeholder="변경할 비밀번호">	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="upasswd_check">비밀번호 확인&nbsp&nbsp&nbsp</label>
			<input class="col-3 mb-sm-2" id="upasswd_check" onkeyup = "passwardCheck();" type="password" name="upasswd_check" placeholder="비밀번호 확인">	
		</div>
		<div class="button-group my-3">
			<input type="button" class="btn btn-info mx-sm-2" value="회원정보 변경" onclick="changeinfo()">
			<input id="submit" type="submit" class="btn btn-info" value="변경" disabled>
		</div>
	</div>	
<!-- </form>
	<form action="Change_PwAction.jsp" method="get">
		<div class="form-group" >
			<label for="nowpw">현재 비밀번호</label>
			<input class = "col-8" type="password" name="nowpw" id="nowpw" class="form-control" placeholder ="비밀번호를 입력해 주세요" />
		</div>
		<div class="form-group" >
			<label for="upasswd">변경할 비밀번호</label>
			<input class = "col-8" type="password" name="upasswd" id="upasswd" class="form-control" onkeyup = "passwardCheck();" placeholder ="비밀번호를 입력해 주세요" />
		</div>
		<div class="form-group">
			<label for="upasswd_check">비밀번호 확인</label> 
			<input class = "col-8" type="password" name="upasswd_check" onkeyup = "passwardCheck();" id="upasswd_check" class="form-control" placeholder ="비밀번호를 입력해 주세요" />
		</div>
		<input id="submit" type="submit" value="변경하기" class="btn btn-primary" disabled />
	</form> -->