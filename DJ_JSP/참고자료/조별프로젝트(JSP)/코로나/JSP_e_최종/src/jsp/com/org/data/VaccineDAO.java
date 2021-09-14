package jsp.com.org.data;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import jsp.com.org.DBInterface;



public class VaccineDAO {
	Connection conn= null;
	PreparedStatement pstmt = null;
	ResultSet rs = null;
	
	public ArrayList<Vaccine> select(String addr){
		ArrayList<Vaccine> list = new ArrayList<Vaccine>();
		String sql="select * from JSP.vaccine where addr like '"+addr+"%'";
		try {
			Class.forName(DBInterface.mysql_class);
			conn=DriverManager.getConnection(DBInterface.mysql_url,DBInterface.mysql_id,DBInterface.mysql_pw);
			pstmt=conn.prepareStatement(sql);
			rs=pstmt.executeQuery();
			while(rs.next()) {
				Vaccine data = new Vaccine();
				data.setIdx(rs.getInt("idx"));
				data.setCentertype(rs.getString("centertype"));
				data.setCenterName(rs.getString("centerName"));
				data.setOperation(rs.getString("operation"));
				data.setFacility(rs.getString("facility"));
				data.setPostNum(rs.getString("postNum"));
				data.setAddr(rs.getString("addr"));
				data.setTel(rs.getString("tel"));
				list.add(data);
			}
		}catch(Exception e) {
			e.printStackTrace();
		}finally {
			if(pstmt!=null)
				try {pstmt.close();}catch(SQLException e) {}
			if(conn!=null)
				try {conn.close();}catch(SQLException e) {}
			if(rs!=null)
				try {rs.close();}catch(SQLException e) {}
		}
		return list;
	}

}
