<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.Statement"%>
<%@page import="java.sql.Connection"%>

<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

	<%!
		Connection	connection;
		Statement	statement;
		ResultSet	resultSet;
		
		String	strName, strID, strPW, strPhone1, strPhone2, strPhone3, strGender;
	%>
	
<!DOCTYPE html>

<html>


<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>


<body>
	<%
		strID	=	(String)session.getAttribute("id");
			
		String	strQuery	=	"select * from member where id = '" + strID + "'";
		System.out.println(strQuery);
		
		String	strDriver	=	"oracle.jdbc.driver.OracleDriver";
		String	strURL		=	"jdbc:oracle:thin:@localhost:1521:xe";
		String	strUserID	=	"scott";
		String	strUserPW	=	"tiger";
		
		Class.forName(strDriver);
		connection	=	DriverManager.getConnection( strURL, strUserID, strUserPW );
		statement	=	connection.createStatement();
		resultSet 	=	statement.executeQuery(strQuery);
		
		//// 행이 끝날 때까지 탐색..
		while( resultSet.next() )
		{
			//// column별로 data를 가져 옴.
			strName 	= resultSet.getString("name");
			strID 		= resultSet.getString("id");
			strPW 		= resultSet.getString("pw");
			strPhone1 	= resultSet.getString("phone1");
			strPhone2 	= resultSet.getString("phone2");
			strPhone3 	= resultSet.getString("phone3");
			strGender 	= resultSet.getString("gender");
		} //	while( resultSet.next() ){..
			
		System.out.println( "id : " + strID + " pw : " + strPW + " name : " + strName  );
	%>
	
	
	<form action="ModifyOk" method="post">
		이름 : <input type="text" name="name" size="10" value=<%=strName %>><br/>
		
		<!-- 함부로 수정하지 못하게 하기 위함 ( readonly 속성 )  -->
		ID : <input type="text" name="id" size="10" value=<%=strID %> readonly="readonly"><br/>
		PW : <input type="password" name="pw" size="10" value=<%=strPW %> readonly="readonly"><br/>
		전화번호: 
		<select name="phone1">
			<option value="010">010</option>
			<option value="011">011</option>
			<option value="007">007</option>
		</select> - 
		<input type="text" name="phone2" size="5" value=<%=strPhone2 %> > -
		<input type="text" name="phone3" size="5" value=<%=strPhone3 %> >
		
		<% if( strGender.equals("man") ) {%>
		성별구분 : <input type="radio" name="gender" value="man" checked="checked">남
		<input type="radio" name="gender" value="woman">여
 		<% } else {%>
		<input type="radio" name="gender" value="man" >남
		<input type="radio" name="gender" value="woman" checked="checked">여
		<% } %>
		
		<!-- &nbsp; 이 값은 HTML이나 XML 상에서 공백을 의미한다. -->
		<input type="submit" value="정보수정"> &nbsp;
		<input type="reset" value="취소">	
	</form>
	
	
	
</body>


</html>