package Ask;

import java.sql.*;
import java.util.*;

import Ask.DBinfo.DBInfo;

public class AskDBManager {
	
	public ArrayList<AskDTO> select(String ct){
		ArrayList<AskDTO> list = new ArrayList<AskDTO>();
		Connection conn = null;
		PreparedStatement pstmt =null;
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement("SELECT SIDO,CITY,DEP,PN FROM ask_info where cartype=?");
			pstmt.setString(1, ct);
			rs=pstmt.executeQuery();
		
			while(rs.next()) {
				String sido = rs.getString("sido");
				String city = rs.getString("city");
				String dep = rs.getString("dep");
				String pn = rs.getString("pn");
			
				AskDTO info_list = new AskDTO();
				info_list.setSido(sido);
				info_list.setCity(city);
				info_list.setDep(dep);
				info_list.setPn(pn);
				list.add(info_list);
			}			
		}
		catch(Exception e) {
			e.printStackTrace();
		}
		finally {
			try{
				if (rs!= null) rs.close();
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception ex){}
		}
		return list;
	}
}
