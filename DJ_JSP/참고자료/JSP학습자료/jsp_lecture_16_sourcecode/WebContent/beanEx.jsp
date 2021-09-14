<%@ page language="java" contentType="text/html; charset=EUC-KR"
	pageEncoding="EUC-KR"%>

<!-- Student student = new Student(); -->
<jsp:useBean id="student" class="com.javalec.ex.Student" scope="page" />

<!-- Student student2 = new Student(); -->
<jsp:useBean id="student2" class="com.javalec.ex.Student" scope="page" />


<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>

	<jsp:setProperty name="student" property="name" value="홍길동" />
	<jsp:setProperty name="student" property="age" value="13" />
	<jsp:setProperty name="student" property="grade" value="6" />
	<jsp:setProperty name="student" property="studentNum" value="7" />

	이름 :
	<jsp:getProperty name="student" property="name" /><br /> 나이 :
	<jsp:getProperty name="student" property="age" /><br /> 학년 :
	<jsp:getProperty name="student" property="grade" /><br /> 번호 :
	<jsp:getProperty name="student" property="studentNum" /><br />

	<jsp:setProperty name="student2" property="name" value="이동준" />
	<jsp:setProperty name="student2" property="age" value="32" />
	<jsp:setProperty name="student2" property="grade" value="4" />
	<jsp:setProperty name="student2" property="studentNum" value="2009038033" />

	이름 :
	<jsp:getProperty name="student2" property="name" /><br /> 나이 :
	<jsp:getProperty name="student2" property="age" /><br /> 학년 :
	<jsp:getProperty name="student2" property="grade" /><br /> 번호 :
	<jsp:getProperty name="student2" property="studentNum" /><br />


</body>
</html>