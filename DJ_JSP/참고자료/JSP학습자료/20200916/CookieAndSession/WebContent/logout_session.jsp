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
		//������ �����ϴ� ���μ���

	Enumeration enumeration = session.getAttributeNames();

 	System.out.println("��Ű ���� ��");
 	while (enumeration.hasMoreElements()) {
 		String sName = enumeration.nextElement().toString();
 		String sValue = (String) session.getAttribute(sName);
 		System.out.println("sName : " + sName + "<br/>");
 		System.out.println("sValue : " + sValue + "<br/>");
 	}
 	Enumeration enumeration2 = session.getAttributeNames();
	while (enumeration2.hasMoreElements()) {
		String sName = enumeration2.nextElement().toString();
		String sValue = (String) session.getAttribute(sName);
		if (sValue.equals("aaa")) {
			session.removeAttribute(sName);
		}
		if(sName.equals("pw"))
		{
			session.removeAttribute(sName);
		}
	}

	Enumeration enumeration3 = session.getAttributeNames();
 	System.out.println("��Ű ���� ��");
 	while (enumeration3.hasMoreElements()) {
 		String sName = enumeration3.nextElement().toString();
 		String sValue = (String) session.getAttribute(sName);
 		System.out.println("sName : " + sName + "<br/>");
 		System.out.println("sValue : " + sValue + "<br/>");
 	}
	%>

	<a href="sessiontest.jsp">���� �׽�Ʈ ������ Ȯ��</a>
</body>
</html>