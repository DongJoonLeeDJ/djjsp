package CarSupportFund;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import Member.DBinfo.DBInfo;

public class CarSF_DAO {
	public ArrayList<CarSF_DTO> carSF() {
			ArrayList<CarSF_DTO> list = new ArrayList<CarSF_DTO>();
			Connection conn =  null;
			PreparedStatement pstmt = null;
			ResultSet rs = null;
			
			try {
				Class.forName(DBInfo.mysql_class);
				
				conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
				pstmt = conn.prepareStatement(""
								+ "SELECT * FROM charge.subsidy_sido "
								+ "");
				rs = pstmt.executeQuery();
				while(rs.next()) {
					CarSF_DTO car = new CarSF_DTO();
					car.setSido(rs.getString("sido"));
					car.setElec(rs.getString("elec"));
					car.setHydro(rs.getString("hydro"));
					list.add(car);
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
