<%@page import="jsp.com.org.MemberInsert"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%

	String ID = request.getParameter("ID");
	String PWD = request.getParameter("PW");
	String NAME = request.getParameter("NAME");
	String PHONE = request.getParameter("PHONE");
	
	MemberInsert Minsert = new MemberInsert();
	int ret = Minsert.insert(ID,PWD,NAME,PHONE);
%>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script>
window.onload = function(){
	if(<%=ret%>==1){
		swal("성공","회원가입이 완료되었습니다.","success").then((value) => {
			location.href='../Main.jsp'
		});
	}else{
		swal("실패","회원가입에 실패하였습니다.","error").then((value) => {
			location.href='../Main.jsp'
		});
	}
}
</script>