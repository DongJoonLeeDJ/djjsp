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
// 			Cookie cookie = new Cookie("id", id);
// 			cookie.setMaxAge(60); // ��Ű�� ��ȿ�Ⱓ. 1���� ������ �ڵ����� �����ȴ�.
// 			response.addCookie(cookie); //�����ϴ� response ��ü �ȿ� ��Ű�� ��´�.
			
			session.setAttribute("id", id);
			session.setAttribute("pw", pw);
			response.sendRedirect("welcome_session.jsp");
		}
		else //�α��� ����
		{
			response.sendRedirect("Login_session.html");
		}
	%>
</body>
</html>