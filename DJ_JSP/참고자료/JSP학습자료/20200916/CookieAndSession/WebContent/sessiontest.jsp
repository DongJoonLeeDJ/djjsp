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
	Enumeration enumeration4 = session.getAttributeNames();
	
	int i = 0;
	while (enumeration4.hasMoreElements()) {
		i++;
		
		String sName = enumeration4.nextElement().toString();
		String sValue = (String) session.getAttribute(sName);
		
		out.println("sName : " + sName + "<br/>");
		out.println("sValue : " + sValue + "<br/>");
	}
	if(i==0)
		out.println("�ش� ������ �����Ǿ����ϴ�.");
	else
		out.println("�ش� ������ ���� �����ֽ��ϴ�.");
		
	%>
</body>
</html>