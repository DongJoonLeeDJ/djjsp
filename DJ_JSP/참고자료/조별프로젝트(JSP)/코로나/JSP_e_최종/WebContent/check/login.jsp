<%@page import="jsp.com.org.Login"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<head>
<meta charset="UTF-8">
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>
   
<script type="text/javascript">
history.replaceState({}, null, location.pathname); //넘겨받은 파라메터를 숨기는 구문
</script>
 <%
	String ID = request.getParameter("id");
	String PW = request.getParameter("pwd");
	Login log = new Login();
	int ret =log.login(ID,PW);
	
	if(ret==1){
		session.setAttribute("ID", ID);
		session.setAttribute("PW", PW);
	}
 %>
 <script>
window.onload = function(){
 if(<%=ret%>==1){
	 swal("로그인 성공","","success").then((value) => {
			location.href = "../Main.jsp"
		});
	
 }else{
	 swal("로그인실패","","error").then((value) => {
			location.href="../loginPage.jsp"
		});
 }
}
 
 </script>