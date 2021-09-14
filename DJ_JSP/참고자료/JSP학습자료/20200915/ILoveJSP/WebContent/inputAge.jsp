<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>

<%! int age = 0; %>
<%String str = request.getParameter("age");
	try
	{
		age = Integer.parseInt(str);
	} catch(Exception e)
	{
		e.printStackTrace();
		age = 0;
	}
	
	if(age >= 20)
	{
		response.sendRedirect("ok.jsp?age="+age);
	}
	else
	{
		response.sendRedirect("ng.jsp?age="+age);	
	}
	

%>

</body>
</html>