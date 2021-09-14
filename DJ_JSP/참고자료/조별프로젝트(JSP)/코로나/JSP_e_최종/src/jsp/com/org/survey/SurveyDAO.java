package jsp.com.org.survey;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import jsp.com.org.DBInterface;


public class SurveyDAO {
	private Connection conn;
	private PreparedStatement pstmt;
	private ResultSet rs;
	
	public SurveyDAO() {
		try {
			Class.forName(DBInterface.mysql_class);
			conn=DriverManager.getConnection(DBInterface.mysql_url,DBInterface.mysql_id,DBInterface.mysql_pw);
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	public int Submit(String answer, String sql) {
		String SQL =sql;
		try {
			PreparedStatement pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, answer);

			return pstmt.executeUpdate();
		}catch (Exception e) {
			e.printStackTrace();
		}
		return -1; //�뜲�씠�꽣踰좎씠�뒪 �삤瑜�
	}
	public int allCount() {
		String sql="select count(*) from JSP.question1";
		try {
			PreparedStatement pstmt = conn.prepareStatement(sql);
			rs= pstmt.executeQuery();
			if(rs.next()) {
				return rs.getInt(1);
			}
		}catch(Exception e) {
			e.printStackTrace();
		}
		return -1;
	}
	public int result(String answer, String question) {
		String sql="select count("+answer+") from "+question;
		try {
			PreparedStatement pstmt = conn.prepareStatement(sql);
			rs=pstmt.executeQuery();
			if(rs.next()) {
				return rs.getInt(1);
			}
			
		}catch(Exception e) {
			e.printStackTrace();
		}
		return -1;
	}

}
