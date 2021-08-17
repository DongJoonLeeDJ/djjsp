<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%!
    	int num = 100;
    	public int sum(int n1, int n2){
    		return n1+n2;
    	}
    	
    	public int sub(int n1, int n2){
    		return n1 - n2;
    	}
    %>
    <% int num = 10; %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	 <div><h1>덧셈 결과: <%= sum(100,50) %></h1></div>
	 <div><h1>뺄셈 결과: <%= sub(100,50) %></h1></div>
	 <div>this.num: <%=this.num %> </div> <!-- 전역변수 -->
	 <div>num: <%=num %> </div> <!-- 지역변수 -->
</body>
</html>