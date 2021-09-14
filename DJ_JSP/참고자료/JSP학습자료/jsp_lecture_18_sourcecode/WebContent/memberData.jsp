<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.Statement"%>
<%@page import="java.sql.Connection"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
	<%!
		Connection connection;
		Statement statement;
		ResultSet resultSet;
	
		String driver = "oracle.jdbc.driver.OracleDriver";
		String url = "jdbc:oracle:thin:@localhost:1521:xe";
		String uid = "scott";
		String upw = "TIGER";
		String query = "select * from member";
	%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
	
	<%
		try{
			
			Class.forName(driver);	//oracle.jdbc.driver.OracleDriver
			connection = DriverManager.getConnection(url, uid, upw);	//jdbc:oracle:thin:@localhost:1521:xe
			statement = connection.createStatement();
			resultSet = statement.executeQuery(query);	//select * from member
			
			while(resultSet.next()){
				String id = resultSet.getString("id");
				String pw = resultSet.getString("pw");
				String name = resultSet.getString("name");
				String phone = resultSet.getString("phone");
				
				out.println("아이디 : " + id + ", 비밀번호 : " + pw + ", 이름 : " + name + ", 전화번호 : " + phone + "<br />");
			}
			
		} catch(Exception e) {
			e.printStackTrace();
		} finally {
			try{
				if(resultSet != null) resultSet.close();
				if(statement != null) statement.close();
				if(connection != null) connection.close();
			} catch(Exception e){}
		}
	%>
	
</body>
</html>