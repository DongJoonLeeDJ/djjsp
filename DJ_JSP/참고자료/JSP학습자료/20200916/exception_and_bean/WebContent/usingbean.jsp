<%@page import="exception_and_bean.Customer"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>   
<!-- Customer cus = new Customer(); -->
<jsp:useBean id="cus" class="exception_and_bean.Customer" scope="page" />
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<!-- 
		private String name;		private int age;
		private int grade;		private String number;
	 -->
	<!-- cus.setName("이동준") -->
	<jsp:setProperty property="name" name="cus" value="이동준"/>
	<!-- cus.setAge(32) -->
	<jsp:setProperty property="age" name="cus" value="32"/>
	<!-- cus.setGrade(4) -->
	<jsp:setProperty property="grade" name="cus" value="4"/>
	<!-- cus.setNumber("2009038033") -->
	<jsp:setProperty property="number" name="cus" value="2009038033"/>
	이름:<jsp:getProperty property="name" name="cus"/><br/>
	나이:<jsp:getProperty property="age" name="cus"/><br/>
	학년:<jsp:getProperty property="grade" name="cus"/><br/>
	번호:<jsp:getProperty property="number" name="cus"/><br/>
	<%
		//위의 코드와 똑같은 코드
		Customer cus2 = new Customer();
		cus2.setName("이제영");
		cus2.setAge(33);
		cus2.setGrade(5);
		cus2.setNumber("2007123123");
		
		out.println("이름 : " + cus2.getName() + "<br/>");
		out.println("나이 : " + cus2.getAge() + "<br/>");
		out.println("학년 : " + cus2.getGrade() + "<br/>");
		out.println("번호 : " + cus2.getNumber() + "<br/>");
	%>
</body>
</html>