package jsp.com.org.Covid_Data;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import jsp.com.org.DBInterface;

public class Covid_Data {
	
	public ArrayList<Covid_Data_Info> Addr_Select() {
		ArrayList<Covid_Data_Info> CData = new ArrayList<Covid_Data_Info>();
		
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		String ADDR;
		int ADDRCOUNT =0;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement(
					"select addr,count(*) as addrCount from Seoul_Covid19 group by addr order by addr asc");
			rs = pstmt.executeQuery();
			while(rs.next()){
				Covid_Data_Info CDI = new Covid_Data_Info();
				CDI.setAddr(rs.getString("addr"));
				CDI.setAddrcount(rs.getInt("addrCount"));
				CData.add(CDI);
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
		return CData;
	}
	
	public ArrayList<Covid_Data_Info> Week_Select() {
		ArrayList<Covid_Data_Info> CData = new ArrayList<Covid_Data_Info>();
		
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		String ADDR;
		int ADDRCOUNT =0;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement(
					"select addr ,count(addr) as count from Seoul_Covid19 WHERE Confirmed_Data BETWEEN DATE_ADD(NOW(),INTERVAL -1 WEEK ) AND NOW() Group by addr order by count desc");
			rs = pstmt.executeQuery();
			while(rs.next()){
				Covid_Data_Info CDI = new Covid_Data_Info();
				CDI.setAddr(rs.getString("addr"));
				CDI.setAddrcount(rs.getInt("count"));
				CData.add(CDI);
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
		return CData;
	}
	
}
