package jsp.com.org.Posting;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import jsp.com.org.DBInterface;

public class CommentDB {
	Connection conn=null;
	PreparedStatement pstmt =null;
	ResultSet rs =null;
	
	public void Comment(String id, String num, String Comment) {
		try {
			Class.forName(DBInterface.mysql_class);
			conn=DriverManager.getConnection(DBInterface.mysql_url,DBInterface.mysql_id,DBInterface.mysql_pw);
			pstmt= conn.prepareStatement("INSERT INTO comment(Pagenum,Context,ID) VALUES(?, ?, ?)");
			pstmt.setString(1,num);
			pstmt.setString(2,Comment);
			pstmt.setString(3,id);
			pstmt.executeUpdate();
		}catch(Exception e) {
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
	
	
	public List<Comment> Read(String num) {
		ArrayList<Comment> cmtd = new ArrayList<Comment>();
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement("select * from Comment where PageNum=?");
			pstmt.setString(1, num);
			rs = pstmt.executeQuery();
			while(rs.next()){
				Comment cmt = new Comment();
				cmt.setPageNum(rs.getInt("PageNum"));
				cmt.setCommentNum(rs.getInt("CommentNum"));
				cmt.setContext(rs.getString("Context"));
				cmt.setID(rs.getString("ID"));
				cmtd.add(cmt);
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
		return cmtd;
	}
	
	
	public void Delete(String CNum,String Page) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try{
			Class.forName(DBInterface.mysql_class);
			conn = DriverManager.getConnection(DBInterface.mysql_url, DBInterface.mysql_id, DBInterface.mysql_pw);
			pstmt = conn.prepareStatement("delete from Comment where PageNum=? and CommentNum=?");
			pstmt.setString(1, Page);
			pstmt.setString(2, CNum);
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
