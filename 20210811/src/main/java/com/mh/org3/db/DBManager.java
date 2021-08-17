package com.mh.org3.db;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import org.springframework.stereotype.Component;

@Component
//@Service
//@Repository
public class DBManager {

	public void inserttest(String para1,String para2) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			conn = DriverManager
					.getConnection("jdbc:mysql://localhost:3306/mh","root","1234");
			pstmt = conn.prepareStatement("insert into test values (?,?)");
			pstmt.setString(1, para1);
			pstmt.setString(2, para2);
			pstmt.executeUpdate(); // 실행...
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (conn != null)
					conn.close();
				if (pstmt != null)
					pstmt.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
	}
}
