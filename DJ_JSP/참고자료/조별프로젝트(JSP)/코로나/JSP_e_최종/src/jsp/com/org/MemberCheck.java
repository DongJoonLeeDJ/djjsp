package jsp.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;




public class MemberCheck {
	public int check(String id) {
		
		Connection conn = null; // DB 연결객체
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		int ret = 0;
		try {
			Class.forName(DBInterface.mysql_class);

			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement("select * from member where ID=?");
			pstmt.setString(1, id);
			rs = pstmt.executeQuery();
			if (rs.next()) {
				ret = 1;
			}
			return ret;
		} catch (Exception e) {
			e.printStackTrace();
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
