package jsp.com.org.Posting;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import jsp.com.org.DBInterface;

public class PostingDB {
	Connection conn=null;
	PreparedStatement pstmt =null;
	ResultSet rs =null;

	public void write(String title, String userid, String content) {
		Date date_now = new Date(System.currentTimeMillis()); // 현재시간을 가져와 Date형으로 저장한다
		// 년월일시분초 14자리 포멧
		SimpleDateFormat fourteen_format = new SimpleDateFormat("yyyy-MM-dd-HH:mm:ss"); 
		System.out.println(fourteen_format.format(date_now)); // 14자리 포멧으로 출력한다
		try {
			Class.forName(DBInterface.mysql_class);
			conn=DriverManager.getConnection(DBInterface.mysql_url,DBInterface.mysql_id,DBInterface.mysql_pw);
			pstmt= conn.prepareStatement("INSERT INTO posting(title,userid,date,content) VALUES(?, ?, ?, ?)");
			pstmt.setString(1,title);
			pstmt.setString(2, userid);
			System.out.println(userid);
			pstmt.setString(3, fourteen_format.format(date_now) );
			pstmt.setString(4,content);
			int ret= pstmt.executeUpdate();
			if(ret >0) {
				System.out.println("정상적으로 insert 되었습니다");
			}
		}catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	
	public List<Posting> select(int pageNum) {
		ArrayList<Posting> PData = new ArrayList<Posting>();
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement(
					"select num,title,userid,date from posting order by num desc limit "+pageNum+","+(pageNum+10)+"");
			
			rs = pstmt.executeQuery();
			while(rs.next()){
				Posting posting = new Posting();
				posting.setNum(rs.getInt("num"));
				posting.setTitle(rs.getString("title"));
				posting.setUserid(rs.getString("userid"));
				posting.setDate(rs.getString("date"));
				
				PData.add(posting);
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
		return PData;
	}
	
	public List<Posting> select_reload(int pageNum) {
		ArrayList<Posting> PData = new ArrayList<Posting>();
		pageNum=pageNum*10;
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement(
					"select num,title,userid,date from posting order by num desc limit "+(pageNum-10)+","+pageNum+"");
			
			rs = pstmt.executeQuery();
			while(rs.next()){
				Posting posting = new Posting();
				posting.setNum(rs.getInt("num"));
				posting.setTitle(rs.getString("title"));
				posting.setUserid(rs.getString("userid"));
				posting.setDate(rs.getString("date"));
				
				PData.add(posting);
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
		return PData;
	}
	
	public int PageNum() {
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		int page = 0;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement(
					"select count(*) as page from posting");
			
			rs = pstmt.executeQuery();
			while(rs.next()){
				page = rs.getInt("page");
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
		return page/10;
	}

}
