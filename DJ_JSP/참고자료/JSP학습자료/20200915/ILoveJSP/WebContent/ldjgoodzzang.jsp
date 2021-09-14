<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<!-- 전역 변수 선언 -->

	<%! 
		int i = 10;
    	String str = "ABCD";
    %>
   
   <!-- 함수 생성 --> 
   <%!
   		public int sum(int a, int b)
   		{
	   		return i+a+b;
   		}
   %>
   
   
   <%
   		out.println("i = " + i + "<br/>");
		out.println("str = " + str + "<br/>");
		out.println("str = " + sum(1,5) + "<br/>");
   
   %>
   
   <%= i %><br/>
   <%= str %><br/>
   <%=sum(1,2) %>

</body>
</html>