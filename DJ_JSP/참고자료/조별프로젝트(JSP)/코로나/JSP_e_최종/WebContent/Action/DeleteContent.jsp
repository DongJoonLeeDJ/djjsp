<%@page import="jsp.com.org.Posting.PostingDelete"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>

<%PostingDelete del = new PostingDelete();
String num = request.getParameter("num");
del.delete(num);%>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script>
history.replaceState({}, null, location.pathname); //�Ѱܹ��� �Ķ���͸� ����� ����
window.onload = function(){
swal("�����Ϸ�","","success").then((value) => {
	location.href="../Tab/NoticeBoard.jsp"
});
}

</script>