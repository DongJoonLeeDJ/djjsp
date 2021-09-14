package jsp.com.org.Posting;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import jsp.com.org.DBInterface;

public class PostingRead {
	public List<PostingData> Read(String num) {
		ArrayList<PostingData> postData = new ArrayList<PostingData>();
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement(
					"select * from posting where num=?");
			pstmt.setString(1, num);
			
			rs = pstmt.executeQuery();
			while(rs.next()){
				PostingData postingdata = new PostingData();
				postingdata.setNum(rs.getInt("num"));
				postingdata.setTitle(rs.getString("title"));
				postingdata.setUserid(rs.getString("userid"));
				postingdata.setDate(rs.getString("date"));
				postingdata.setContent(rs.getString("content"));
				postData.add(postingdata);
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
		return postData;
	}
}
