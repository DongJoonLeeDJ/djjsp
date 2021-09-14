<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%! String strName, strID, strPW; %>

<!DOCTYPE html>

<html>


<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>


<body>
	<%
		strName	=	(String)session.getAttribute("name"); 
		strID	=	(String)session.getAttribute("id");; 
		strPW	=	(String)session.getAttribute("pw");;
	%>
	
	<%= strName %>님 안녕!<br/>
	<a href="modify.jsp">회원정보 수정</a>

</body>


</html>