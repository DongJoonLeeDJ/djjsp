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
		//세션을 삭제하는 프로세스

	Enumeration enumeration = session.getAttributeNames();

 	System.out.println("쿠키 삭제 전");
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
 	System.out.println("쿠키 삭제 후");
 	while (enumeration3.hasMoreElements()) {
 		String sName = enumeration3.nextElement().toString();
 		String sValue = (String) session.getAttribute(sName);
 		System.out.println("sName : " + sName + "<br/>");
 		System.out.println("sValue : " + sValue + "<br/>");
 	}
	%>

	<a href="sessiontest.jsp">세션 테스트 페이지 확인</a>
</body>
</html>