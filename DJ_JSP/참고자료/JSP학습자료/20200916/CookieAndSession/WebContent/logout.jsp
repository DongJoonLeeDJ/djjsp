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
		//��Ű�� ����� ���μ���
		
		Cookie[] cookies = request.getCookies(); //request ��ü�� �ִ� ��� ��Ű���� �� �迭�� �ִ´�.
		
		if(cookies != null)
		{
			//��Ű �迭 ���̸�ŭ �ݺ��� ����
			for(int i = 0; i <cookies.length; i++)
			{
				if(cookies[i].getValue().equals("aaa")) //���� ���μ��� ����
				{
					//MaxAge �� 0���� �ٲ۴�.
					cookies[i].setMaxAge(0);
					//�װ� �ٽ� addCookie �Ѵ�.
					//response.addCookie(cookies[i]);
				}
			}
		}
		
		//�α׾ƿ��� �Ͽ��ٸ� �ٽ� �α��� �������� �̵�
		//response.sendRedirect("Login.html");
		
		//���� �����ִ� ��Ű������ ����ϴ� �������� �̵�
		response.sendRedirect("cookietest.jsp");
	
	%>
</body>
</html>