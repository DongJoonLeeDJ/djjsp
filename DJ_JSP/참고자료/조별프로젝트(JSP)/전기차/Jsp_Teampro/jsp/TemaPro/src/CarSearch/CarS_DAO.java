package CarSearch;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import Member.DBinfo.DBInfo;

public class CarS_DAO {
	public ArrayList<CarS_DTO> carS() {
		ArrayList<CarS_DTO> list = new ArrayList<CarS_DTO>();
		Connection conn =  null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		
		try {
			Class.forName(DBInfo.mysql_class);
			
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(""
							+ "SELECT * FROM charge.subsidy_car "
							+ "");
			rs = pstmt.executeQuery();
			while(rs.next()) {
				CarS_DTO cars = new CarS_DTO();
				cars.setDiv(rs.getString("div"));
				cars.setCompany(rs.getString("company"));
				cars.setCartype(rs.getString("cartype"));
				cars.setPrice(rs.getString("price"));
				list.add(cars);
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
		return list;
	}
}
