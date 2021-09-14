package kb;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import example.DBInfo;


public class ConnMysql {
	
public int registerCheck(String id) {
		
		Connection conn =  null;	// DB �뿰寃곌컼泥�
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			
			pstmt = conn.prepareStatement(""
							+ "SELECT * FROM user " 
							+ " WHERE userID=?"
							+ "");
			pstmt.setString(1, id);
			rs = pstmt.executeQuery();
			if(rs.next() || id.equals("")) {
				return 0;	//이미 존재하는 회원
			}
			else {
				return 1;	//가입 가능한 회원
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			try{
				if(rs != null) rs.close();
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception ex){
			}
		}
		return -1;	//데이터베이스 오류
	}

	//회원가입
	public int register(String id, String pw, String name, String phone) {
	
		Connection conn=null;
		PreparedStatement pstmt=null;
	
		try{
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			
			pstmt = conn.prepareStatement(
					"INSERT INTO "+ 
					"user "+
					"(userID,userPassword,Name,Phone) "+
					"VALUES "+
					"(?,?,?,?)");
			
			pstmt.setString(1, id);
			pstmt.setString(2, pw);
			pstmt.setString(3, name);
			pstmt.setString(4, phone);
			
			int ret = pstmt.executeUpdate();
			if(ret > 0 ){
				return ret;
			}
		}
		catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception ex){
				
			}
		}
		return 0;
	}
	
public Member ckLogin(String id, String pwd) {
	Member member = null;
	Connection conn=null;
	PreparedStatement pstmt=null;
	ResultSet rs = null;
	
	try {
	
		Class.forName(DBInfo.mysql_class);
		conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
		
		pstmt=conn.prepareStatement("SELECT * FROM user WHERE userID=? AND userPassword=?");
		pstmt.setString(1, id);
		pstmt.setString(2, pwd);
		rs=pstmt.executeQuery();
		if(rs.next()) {
			member = new Member();
			member.setId(id);
			member.setPwd(pwd);
			member.setName(rs.getString("Name"));
			member.setPhone(rs.getString("Phone"));
		}
		
	}catch(Exception e){
		e.printStackTrace();

	}
	finally {
		try {
			if(pstmt !=null) pstmt.close();
			if(conn !=null) conn.close();
			if(rs != null) rs.close();
		}catch(Exception ex) {
			
		}
	}
	return member;
	
}


}
