<%@page import="java.sql.PreparedStatement"%>
<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.Connection"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
    <%!
		Connection connection;
		PreparedStatement preparedStatement;
		ResultSet resultSet;
	
		String driver = "oracle.jdbc.driver.OracleDriver";
		String url = "jdbc:oracle:thin:@localhost:1521:xe";
		String uid = "scott";
		String upw = "TIGER";
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
			
			Class.forName(driver);
			connection = DriverManager.getConnection(url, uid, upw);
			int n;
			String query = "insert into memberforpre (id, pw, name, phone) values (?, ?, ?, ?)";
			preparedStatement = connection.prepareStatement(query);
			
			preparedStatement.setString(1, "abc");
			preparedStatement.setString(2, "123");
			preparedStatement.setString(3, "홍길동");
			preparedStatement.setString(4, "010-1234-5678");
			n = preparedStatement.executeUpdate();
			
			preparedStatement.setString(1, "def");
			preparedStatement.setString(2, "456");
			preparedStatement.setString(3, "홍길자");
			preparedStatement.setString(4, "010-9012-3456");
			n = preparedStatement.executeUpdate();
			
			preparedStatement.setString(1, "ghi");
			preparedStatement.setString(2, "789");
			preparedStatement.setString(3, "홍길순");
			preparedStatement.setString(4, "010-7890-1234");
			n = preparedStatement.executeUpdate();
			
			preparedStatement.setString(1, "AAA");
			preparedStatement.setString(2, "111");
			preparedStatement.setString(3, "이길동");
			preparedStatement.setString(4, "010-1234-1111");
			n = preparedStatement.executeUpdate();
			
			if(n == 1) {
				out.println("insert success");
			} else { 
				out.println("insert fail");
			}
			
		} catch(Exception e) {
				e.printStackTrace();
		} finally {
			try{
				if(resultSet != null) resultSet.close();
				if(preparedStatement != null) preparedStatement.close();
				if(connection != null) connection.close();
			} catch(Exception e){}
		}
	%>
	
	<br />
	<a href="memberDateView.jsp">회원정보 보기</a>

</body>
</html>