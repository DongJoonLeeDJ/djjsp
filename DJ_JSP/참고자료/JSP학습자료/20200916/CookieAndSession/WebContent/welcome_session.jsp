<%@page import="java.util.Enumeration"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
	<%
// 		Cookie[] cookies = request.getCookies();
// 		for(int i = 0; i<cookies.length; i++)
// 		{
// 			String id = cookies[i].getValue();
// 			System.out.println(id);
// 			if(id.equals("aaa"))
// 			{
// 				out.println(id + "�� �ȳ��ϼ���. </br>");
// 			}
// 		}

		//������� ��ü�� �ְ� ���� ��
		//ArrayList���� ��
		//������ ��ü���� �Ѽ����� �ϳ��� ó���� �� �ִ� �޼ҵ带 �����ϴ� �̷���
		//��ó: https://hyeonstorage.tistory.com/210 [������ �ϰ� �;��]
		//https://kutar37.tistory.com/entry/%EC%9E%90%EB%B0%94-Iterator-Enumeration-%EC%9D%B8%ED%84%B0%ED%8E%98%EC%9D%B4%EC%8A%A4
		Enumeration enumeration = session.getAttributeNames();
		while(enumeration.hasMoreElements())
		{
			String sName = enumeration.nextElement().toString();
			String sValue = (String)session.getAttribute(sName);
			
			if(sValue.equals("aaa"))
			{
				out.println(sValue + "�� �ȳ��ϼ���. </br>");
			}
		}
		
	%>
	
	<a href="logout_session.jsp">�α׾ƿ�</a>
</body>
</html>