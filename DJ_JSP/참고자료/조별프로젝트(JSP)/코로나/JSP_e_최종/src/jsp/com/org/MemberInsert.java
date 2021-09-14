package jsp.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class MemberInsert {
	
	public int insert(String id,String pw,String name,String phone) {
		
		Connection conn = null; // DB 연결객체
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		int ret = 0;
		try {
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement("insert into member values(?,?,?,?)");
			pstmt.setString(1, id);
			pstmt.setString(2, pw);
			pstmt.setString(3, name);
			pstmt.setString(4, phone);
			pstmt.executeUpdate();
			ret = 1;
		} catch (Exception e) {
			e.printStackTrace();
			ret=0;
		} finally {
			try {
				if (rs != null)
					rs.close();
				if (pstmt != null)
					pstmt.close();
				if (conn != null)
					conn.close();
			} catch (Exception ex) {

			}
		}
		return ret;
	}
	
}
