<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>

<%= session.getAttribute("name") %>���� ȸ������ ������ ���� ó�� �Ǿ����ϴ�.<br />
<a href="logout.jsp">�α׾ƿ�</a> &nbsp;&nbsp; <a href="modify.jsp">��������</a>

</body>
</html>