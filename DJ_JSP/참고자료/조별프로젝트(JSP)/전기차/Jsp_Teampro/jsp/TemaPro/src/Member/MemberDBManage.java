package Member;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import Member.DBinfo.DBInfo;

public class MemberDBManage {
	
	public int IdCheck(String userid) {
		int result = 1;
		Connection conn =  null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(""
							+ "SELECT count(userid) as cnt FROM charge.member_list " 
							+ " WHERE userid= ? "
							+ "");
			pstmt.setString(1, userid);
			rs = pstmt.executeQuery();
			if(rs.next()) {
				// �븘�씠�뵒 媛��닔 �솗�씤 
				if(rs.getInt("cnt") == 0) {
					// 1�씠 �굹�삤硫� �븘�씠�뵒媛� �엳怨� 0�씠硫� �뾾�쓬
					result = 0;
				}
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
		return result;
		
		
	}
	public boolean SignUp(String userid,String upasswd,String uname,String uaddr,
			String umail,String regdate) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		boolean result = false;
		
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(
					"INSERT INTO "+ 
					"member_list "+
					"(userid,upasswd,uname,uaddr,umail,regdate)"+
					"VALUES "+
					"(?,?,?,?,?,?)");
			

			pstmt.setString(1,userid);
			pstmt.setString(2,upasswd);
			pstmt.setString(3,uname);
			pstmt.setString(4,uaddr);
			pstmt.setString(5,umail);
			pstmt.setString(6,regdate);
			pstmt.executeUpdate();
			result = true;
			return result;
		}catch (Exception e) {
			e.printStackTrace();
			
		}finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception e) {
				
			}
		}
		return result;
	}
	public MemberInfo ckLogin(String userid,String upasswd) {
		MemberInfo member = new MemberInfo();
		member.setSuc(-1);
		Connection conn =  null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(""
							+ "SELECT * FROM charge.member_list " 
							+ " WHERE userid= ?"
							+ "");
			pstmt.setString(1, userid);
			rs = pstmt.executeQuery();
			if(rs.next()) {
				// DB 鍮꾨�踰덊샇 鍮꾧탳
				if(rs.getString("upasswd").equals(upasswd)) {
					//鍮꾨�踰덊샇 �씪移섑븯硫�
					member.setUserid(userid);
					member.setUpasswd(upasswd);
					member.setUmail(rs.getString("umail"));
					member.setUname(rs.getString("uname"));
					member.setUaddr(rs.getString("uaddr"));
					member.setRid(rs.getInt("rid"));
					member.setMid(rs.getString("mid"));
					member.setRegdate(rs.getString("regdate"));
					member.setSuc(1);
				}
				else {
					//鍮꾨�踰덊샇 遺덉씪移�
					member.setSuc(0);
				}
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
		return member;

	}
	public boolean ChangeInfo(String userid,String uname,String uaddr,String umail) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		boolean result = false;
		
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(
					"UPDATE charge.member_list "+ 
					"SET uname = ? ,"+
					"uaddr = ? ,"+
					"umail = ? "+
					"WHERE userid = ? "
					);
			

			pstmt.setString(1,uname);
			pstmt.setString(2,uaddr);
			pstmt.setString(3,umail);
			pstmt.setString(4,userid);
			pstmt.executeUpdate();
			result = true;
			return result;
		}catch (Exception e) {
			e.printStackTrace();
			
		}finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception e) {
				
			}
		}
		return result;
	}
	public boolean ChangePw(String wpw, String userid, String nowpw ) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		boolean result = false;
		
		try {
			Class.forName(DBInfo.mysql_class);
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(
					"UPDATE charge.member_list SET upasswd = ? WHERE userid = ? and upasswd = ? "
					);
			

			pstmt.setString(1, wpw);
			pstmt.setString(2, userid);
			pstmt.setString(3, nowpw);
			if(pstmt.executeUpdate() == 1) {
				result = true;
				return result;
			}
		}catch (Exception e) {
			e.printStackTrace();
			
		}finally {
			try {
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception e) {
				
			}
		}
		return result;
	}
	public MemberInfo FindID(String uname,String umail) {
		MemberInfo member = new MemberInfo();
		Connection conn =  null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(""
							+ "SELECT userid FROM charge.member_list " 
							+ " WHERE uname = ? and umail = ? "
							+ "");

			pstmt.setString(1, uname);
			pstmt.setString(2, umail);
			rs = pstmt.executeQuery();
			if(rs.next()) {
					//�엯�젰�븳 �젙蹂닿� 留욎쑝硫� ID由ы꽩
					member.setUserid(rs.getString("userid"));
					member.setSuc(1);
					return member;
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
		//�엯�젰�븳 �젙蹂닿� ��由щ㈃
		member.setSuc(0);
		return member;
	}
	public MemberInfo FindPw(String userid,String uname,String umail) {
		
		MemberInfo member = new MemberInfo();
		member.setSuc(0);
		Connection conn =  null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			Class.forName(DBInfo.mysql_class);
			
			conn = DriverManager.getConnection(DBInfo.mysql_url, DBInfo.mysql_id, DBInfo.mysql_pw);
			pstmt = conn.prepareStatement(""
							+ "SELECT upasswd FROM charge.member_list " 
							+ "WHERE userid = ? and uname = ? and umail = ? "
							+ "");

			pstmt.setString(1, userid);
			pstmt.setString(2, uname);
			pstmt.setString(3, umail);
			rs = pstmt.executeQuery();
			if(rs.next()) {
					//�엯�젰�븳 �젙蹂닿� 留욎쑝硫� ID由ы꽩
					member.setUpasswd(rs.getString("upasswd"));
					member.setSuc(1);
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
		return member;
	}

}
