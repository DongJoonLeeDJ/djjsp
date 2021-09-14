<%@page import="Member.MemberInfo"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<meta charset="utf-8" />
<script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
<script>
<%
	MemberInfo userinfo  = (MemberInfo)session.getAttribute("userinfo");
	String id = userinfo.getUserid();
%>
	
function changepw(){
	location.href='index.jsp?contentPage=Member/Change_Pw.jsp';
}
function submitCheck() {
	var special_pattern = /[`~!@#$%^&*|\\\'\";:\/?]/gi;
   if( special_pattern.test(uaddr) == true ){
       alert('특수문자는 사용할 수 없습니다.');
       return false;
   }
	//특수문자 사용 체크
   if( special_pattern.test(uname) == true ){
       alert('특수문자는 사용할 수 없습니다.');
       return false;
   }
   //이메일 유효성 검사
   var umail = $('#umail').val();
   if(umail ==""){
	   return true;
   }
   var reg_email = /^([0-9a-zA-Z_\.-]+)@([0-9a-zA-Z_-]+)(\.[0-9a-zA-Z_-]+){1,2}$/;
   if(!reg_email.test(umail)) {                            
	   alert("이메일 형식에 맞지 않습니다.")
	   return false;
   }
   
   return true;
}
</script>
<form onsubmit="return submitCheck();" action="./Member/Change_InfoAction.jsp" method="get">
	<div class="main" style="margin-top:100px; margin-bottom:300px;">
	<h2 class="mt-sm-5">회원 정보 수정</h2>
		<div class="input-box my-3">
			<label class="me-sm-4" for="userid">ID&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</label>
			<input class="col-3 mb-sm-2" id="userid" type="text" name="userid" placeholder ="<%=id %>" disabled>	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="uname">이름&nbsp&nbsp&nbsp</label>
			<input class="col-3 mb-sm-2" id="uname" type="text" name="uname" placeholder="이름">	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="uaddr">주소&nbsp&nbsp&nbsp</label>
			<input class="col-3 mb-sm-2" id="uaddr" type="text" name="uaddr" placeholder="주소">	
		</div>
		<div class="input-box my-3">
			<label class="me-sm-4" for="umail">이메일</label>
			<input class="col-3 mb-sm-2" id="umail" type="text" name="umail" placeholder="OOOO@OOOOOO.OOO">
		</div>
		<div class="button-group my-3">
			<input type="button" class="btn btn-info mx-sm-2" value="비밀번호 변경" onclick="changepw()">
			<input type="submit" class="btn btn-info" value="변경">
		</div>
	</div>	
</form>


