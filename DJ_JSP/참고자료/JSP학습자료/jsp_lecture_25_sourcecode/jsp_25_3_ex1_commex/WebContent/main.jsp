<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	if(session.getAttribute("ValidMem") == null) {
%>
	<<jsp:forward page="login.jsp" />
<%
	}

	String name = (String)session.getAttribute("name");
	String id = (String)session.getAttribute("id");
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
	
	<h1><%= name %>�� �ȳ��ϼ���.</h1> <br />
	<form action="logout.jsp" method="post">
		<input type="submit" value="�α׾ƿ�">&nbsp;&nbsp;&nbsp;<input type="button" value="��������" onclick="javascript:window.location='modify.jsp'">
	</form>

</body>
</html>