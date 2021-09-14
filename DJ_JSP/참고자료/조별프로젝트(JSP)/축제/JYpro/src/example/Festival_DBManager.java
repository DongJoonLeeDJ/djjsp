package example;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

public class Festival_DBManager {
	//紐⑤뱺 異뺤젣
	public ArrayList<Festival> SelectAllFestival() {
		ArrayList<Festival> list = new ArrayList<Festival>();
		Connection conn = null;	;
		PreparedStatement pstmt = null;	
		ResultSet rs = null;	
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			pstmt = conn.prepareStatement("SELECT * FROM fes_table;");
			rs = pstmt.executeQuery();
			while(rs.next()) {
				Festival fst = new Festival();

				fst.setFes_idx(rs.getInt("fes_idx"));
				fst.setFes_name(rs.getString("fes_name"));
				fst.setFes_start(rs.getTimestamp("fes_start"));
				fst.setFes_end(rs.getTimestamp("fes_end"));
				fst.setFes_content(rs.getString("fes_content"));
				fst.setFes_tel(rs.getString("fes_tel"));
				fst.setFes_home(rs.getString("fes_home"));
				fst.setFes_addr(rs.getString("fes_addr"));
				fst.setFes_x(rs.getString("fes_x"));
				fst.setFes_y(rs.getString("fes_y"));
				list.add(fst);
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			try {
				if (rs!= null) rs.close();
				if (pstmt != null) pstmt.close();
				if (conn != null) conn.close();
			}catch (Exception e) {}
		}
		return list;
	}	
	
	public Festival SelectFestivalByName(String name) {
		Festival fst = new Festival();
		Connection conn = null;	;
		PreparedStatement pstmt = null;	
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			pstmt = conn.prepareStatement("select * from fes_table where fes_name= '"+name+"';");
			rs = pstmt.executeQuery();
			while(rs.next()) {
				fst.setFes_idx(rs.getInt("fes_idx"));
				fst.setFes_name(rs.getString("fes_name"));
				fst.setFes_start(rs.getTimestamp("fes_start"));
				fst.setFes_end(rs.getTimestamp("fes_end"));
				fst.setFes_content(rs.getString("fes_content"));
				fst.setFes_tel(rs.getString("fes_tel"));
				fst.setFes_home(rs.getString("fes_home"));
				fst.setFes_addr(rs.getString("fes_addr"));
				fst.setFes_x(rs.getString("fes_x"));
				fst.setFes_y(rs.getString("fes_y"));
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			try {
				if (rs!= null) rs.close();
				if (pstmt != null) pstmt.close();
				if (conn != null) conn.close();
			}catch (Exception e) {}
		}
		
		return fst;
	}
	//洹� �떖�쓽 異뺤젣
	public ArrayList<Festival> SelectFestivalByMonth(String month) {
		ArrayList<Festival> list = new ArrayList<Festival>();
		String m_time=month.substring(0, 7);
		Connection conn = null;	;
		PreparedStatement pstmt = null;	
		ResultSet rs = null;	
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			pstmt = conn.prepareStatement("select fes_idx,fes_name,fes_start,fes_end from fes_table where DATE_FORMAT(fes_start, \"%Y-%m\")<=\""+m_time+"\" and DATE_FORMAT(fes_end, \"%Y-%m\")>=\""+m_time+"\"");
			rs = pstmt.executeQuery();
			while(rs.next()) {
				Festival fst = new Festival();
				fst.setFes_idx(rs.getInt("fes_idx"));
				fst.setFes_name(rs.getString("fes_name"));
				fst.setFes_start(rs.getTimestamp("fes_start"));
				fst.setFes_end(rs.getTimestamp("fes_end"));
				list.add(fst);
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			try {
				if (rs!= null) rs.close();
				if (pstmt != null) pstmt.close();
				if (conn != null) conn.close();
			}catch (Exception e) {}
		}
		return list;
	}	
	public ArrayList<Festival> SelectFestivalByDate(String m_time) {
		ArrayList<Festival> list = new ArrayList<Festival>();
		Connection conn = null;	;
		PreparedStatement pstmt = null;	
		ResultSet rs = null;	
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			pstmt = conn.prepareStatement("select fes_name,fes_start,fes_end,fes_x,fes_y from fes_table where DATE_FORMAT(fes_start, \"%Y-%m-%d\")<=\""+m_time+"\" and DATE_FORMAT(fes_end, \"%Y-%m-%d\")>=\""+m_time+"\" limit 5");
			rs = pstmt.executeQuery();
			while(rs.next()) {
				Festival fst = new Festival();
				fst.setFes_name(rs.getString("fes_name"));
				fst.setFes_start(rs.getTimestamp("fes_start"));
				fst.setFes_end(rs.getTimestamp("fes_end"));
				fst.setFes_x(rs.getString("fes_x"));
				fst.setFes_y(rs.getString("fes_y"));
				list.add(fst);
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			try {
				if (rs!= null) rs.close();
				if (pstmt != null) pstmt.close();
				if (conn != null) conn.close();
			}catch (Exception e) {}
		}
		return list;
	}	
	
}
