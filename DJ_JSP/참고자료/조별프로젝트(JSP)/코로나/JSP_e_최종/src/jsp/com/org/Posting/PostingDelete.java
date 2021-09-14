package jsp.com.org.Posting;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import jsp.com.org.DBInterface;

public class PostingDelete {
	public void delete(String num) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement("delete from posting where num=?");
			pstmt.setString(1, num);
			pstmt.executeUpdate();
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
	}
}
