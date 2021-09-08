<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
		<%! int age; //선언부 %>
		
<%-- 		<% int aaa; %> --%>
		<%
			age = Integer.parseInt( request.getParameter("age"));
			//aaa = 222;
			///System.out.println("aaa="+aaa);
		//클라이언트로부터 받은 메시지에 대한 응답을 위한 객체
			if( age >= 20)
			{
				response.sendRedirect("pass.jsp?age="+age);
			}
			else
			{
				response.sendRedirect("fail.jsp?age="+age);	
			}
		%>
</body>
</html>