package user;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class UserDAO {
	
	private Connection conn; 
	private PreparedStatement pstmt; 
	private ResultSet rs; 
	

	public UserDAO() {
		try {
			String dbURL = "jdbc:mysql://localhost:3306/jsp_teamproject";
			String dbID = "root";
			String dbPassword = "1234";
			Class.forName("com.mysql.jdbc.Driver");
			conn = DriverManager.getConnection(dbURL, dbID, dbPassword);
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	public int login(String userID, String userPassword) {
		String sql = "select userPassword from user where userID = ?";
		try {
			pstmt = conn.prepareStatement(sql); 
			pstmt.setString(1, userID); 
			rs = pstmt.executeQuery(); 
			if(rs.next()) {
				if(rs.getString(1).equals(userPassword)) {
					return 1;
				}else
					return 0; 
			}
			return -1;
		}catch (Exception e) {
			e.printStackTrace();
		}
		return -2; 
	}
	
	
	public int signin(User user) {
		  String sql = "insert into user values(?, ?, ?, ?)";
		  try {
		    pstmt = conn.prepareStatement(sql);
		    pstmt.setString(1, user.getUserID());
		    pstmt.setString(2, user.getUserPassword());
		    pstmt.setString(3, user.getUserName());
		    pstmt.setString(4, user.getUserPhone());
		  
		    return pstmt.executeUpdate();
		  }catch (Exception e) {
		 	e.printStackTrace();
		  }
		  return -1;
		}
	
	
	
	
	
	
	
}