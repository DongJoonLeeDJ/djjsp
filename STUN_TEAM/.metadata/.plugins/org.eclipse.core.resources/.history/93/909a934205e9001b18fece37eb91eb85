<%@ page contentType="text/html; charset=utf-8"%>
<%@ page import="java.sql.DriverManager"%>
<%@ page import="java.sql.Connection"%>
<%@ page import="java.sql.Statement"%>
<%@ page import="java.sql.ResultSet"%>
<%@ page import="java.sql.SQLException"%>
<html>
<head>
<title>Member List</title>

<link
	href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"
	rel="stylesheet"
	integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"
	crossorigin="anonymous">
</head>
<body>
	<h1 class="btn btn-danger">user Table Contents</h1>
	<table class ="table-primary" width="100%" border="1">
		<tr class ="table-primary">
			<td class ="table-primary">Name</td>
			<td class ="table-primary">ID</td>
		</tr>
		<% // MySQL JDBC Driver Loading 
		Class.forName("com.mysql.cj.jdbc.Driver"); 
		Connection conn = null; 
		Statement stmt = null; 
		ResultSet rs = null; 
		try { 
		String jdbcDriver = "jdbc:mysql://localhost:3306/TUTORIAL?" + "useUnicode=true&characterEncoding=utf8"; 
		//String jdbcDriver = "jdbc:mysql://localhost:3306/TUTORIAL?useSSL=false&serverTimezone=UTC";
		//String jdbcDriver = "jdbc:mysql://localhost:3306/TUTORIAL?serverTimezone=UTC"; 
			
		String dbUser = "root";
		String dbPass = "0430"; 
		String query = "select * from user"; // Create DB 
		conn = DriverManager.getConnection(jdbcDriver, dbUser, dbPass); 
		// Create Statement 
		stmt = conn.createStatement(); 
		// Run Qeury 
		rs = stmt.executeQuery(query); 
		// Print Result (Run by Query) 
		while(rs.next()) { %>
		<tr>
			<td><%= rs.getString("userID") %></td>
			<td><%= rs.getString("userPassword") %></td>
		</tr>
		<%
		} }catch(

			SQLException ex)
			{
				out.println(ex.getMessage());
				ex.printStackTrace();
			}finally
			{ // Close Statement 
				if (rs != null) try { rs.close(); } catch(SQLException ex) {}
			if (stmt != null) try { stmt.close(); } catch(SQLException ex) {} 
			// Close Connection 
			if (conn != null) try { conn.close(); } catch(SQLException ex) {} }
		%>
	</table>
		<script
		src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"
		integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"
		crossorigin="anonymous"></script>
	
	
</body>
</html>

<!-- 출처: https://cameldev.tistory.com/40 [낙타의 개발일기 - CamelDev] -->