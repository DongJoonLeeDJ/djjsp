<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
	<%! String id, pw; %>
	<%
		id = request.getParameter("id");
		pw = request.getParameter("pw");
		
		//�α��� ����   ID�� aaa�̰� ��й�ȣ 1234��� ����
		if(id.equals("aaa") && pw.equals("1234"))
		{
			Cookie cookie = new Cookie("id", id);
			cookie.setMaxAge(60); // ��Ű�� ��ȿ�Ⱓ. 1���� ������ �ڵ����� �����ȴ�.
			response.addCookie(cookie); //�����ϴ� response ��ü �ȿ� ��Ű�� ��´�.
			response.sendRedirect("welcome.jsp");
		}
		else //�α��� ����
		{
			response.sendRedirect("Login.html");
		}
	%>
</body>
</html>