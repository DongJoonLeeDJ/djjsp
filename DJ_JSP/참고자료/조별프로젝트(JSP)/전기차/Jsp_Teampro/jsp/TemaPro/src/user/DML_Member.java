package user;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Timestamp;
import java.text.SimpleDateFormat;
import java.util.List;
import java.util.TimeZone;

import DB.DBConnect;
import DB.MySQL;
import Member.MemberInfo;

/**
 * DML: SELECT || INSERT || UPDATE || DELETE row(s)
 * 
 * @author jaemoonnlee
 *
 */
public class DML_Member {
	private Connection conn = null;
	private PreparedStatement pstmt = null;
//	private Statement stmt = null;
//	private CallableStatement cs = null;
	private ResultSet rs = null;
	private MemberInfo user = null;
	private Member_Rank rank = null;
	private List<MemberInfo> list = null;
	private Timestamp ts = null;
	private SimpleDateFormat sdf = null;
	private final int MANAGER = 0;
	private final int USER_NORMAL = 1;

	/**
	 * 회원 가입
	 * 
	 * @param isManager T: 관리자 | F: 일반회원
	 * @param userid    유저 아이디
	 * @param upasswd   비밀번호
	 * @param uname     유저 닉네임
	 * @return > 0 QUERY OK || == 0 QUERY DOESNT WORK || == -1 ERROR
	 */
	public int insert_member(boolean isManager, String userid, String upasswd, String uname) {
		int result = -1;
		String encrypted = Sha256.ecrypt(upasswd);
		String sql = "INSERT INTO member_list (rid, userid, upasswd, uname, regdate) VALUES (?,?,?,?,?)";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			if (isManager)
				pstmt.setInt(1, MANAGER);
			else
				pstmt.setInt(1, USER_NORMAL);
			pstmt.setString(2, userid);
			pstmt.setString(3, encrypted);
			pstmt.setString(4, uname);
			ts = new Timestamp(System.currentTimeMillis());
			sdf = new SimpleDateFormat(MySQL.FORM_TIME24HOURS);
			sdf.setTimeZone(TimeZone.getTimeZone("Asia/Seoul"));
			pstmt.setTimestamp(5, Timestamp.valueOf(sdf.format(ts)));
			result = pstmt.executeUpdate();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs = null;
				if (pstmt != null)
					pstmt = null;
				if (conn != null)
					conn = null;
			} catch (Exception ef) {
				ef.printStackTrace();
			}
		}
		return result;
	}

	public int update_member(int mid) {
		int result = -1;
		StringBuilder sb = new StringBuilder();
		sb.append("UPDATE member_list SET ");
		sb.append("rid = ?");
		sb.append("userid = ?");
		sb.append("upasswd = ?");
		sb.append("uname = ?");
		sb.append("uaddr = ?");
		sb.append("umail = ?");
		sb.append("WHERE mid = ?");
		String sql = "";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			sql = sb.toString();
			pstmt = conn.prepareStatement(sql);
//			pstmt.setString(1, title);
//			pstmt.setString(2, content);
//			ts = new Timestamp(System.currentTimeMillis());
//			sdf = new SimpleDateFormat(MySQL.FORM_TIME24HOURS);
//			sdf.setTimeZone(TimeZone.getTimeZone("Asia/Seoul"));
//			pstmt.setTimestamp(3, Timestamp.valueOf(sdf.format(ts)));
//			pstmt.setInt(4, article_idx);
			result = pstmt.executeUpdate();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs = null;
				if (pstmt != null)
					pstmt = null;
				if (conn != null)
					conn = null;
			} catch (Exception ef) {
				ef.printStackTrace();
			}
		}
		return result;
	}

	/**
	 * 회원 탈퇴
	 * 
	 * @param mid 회원 번호
	 * @return > 0 QUERY OK || == 0 QUERY DOESNT WORK || == -1 ERROR
	 */
	public int delete_member(int mid) {
		int result = -1;
		String sql = "DELETE FROM member_list WHERE ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setInt(1, mid);
			result = pstmt.executeUpdate();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs = null;
				if (pstmt != null)
					pstmt = null;
				if (conn != null)
					conn = null;
			} catch (Exception ef) {
				ef.printStackTrace();
			}
		}
		return result;
	}

	/**
	 * 아이디 중복 확인
	 * 
	 * @param input_id
	 * @return == 1 중복 | == 0 고유 | == -1 에러
	 */
	public int check_id_dup(String input_id) {
		int result = -1;
		String sql = "SELECT * FROM member_list WHERE userid = ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, input_id);
			rs = pstmt.executeQuery();
			if (rs.next())
				result = 1;
			else
				result = 0;
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs = null;
				if (pstmt != null)
					pstmt = null;
				if (conn != null)
					conn = null;
			} catch (Exception ef) {
				ef.printStackTrace();
			}
		}
		return result;
	}

	/**
	 * 비밀번호 확인 | 로그인
	 * 
	 * @param inpur_id
	 * @param input_pwd
	 * @return == 1 일치 | == 0 불일치 | == -1 에러
	 */
	public int check_pwd(String inpur_id, String input_pwd) {
		int result = -1;
		String encrypted = Sha256.ecrypt(input_pwd);
		String sql = "SELECT * FROM member_list WHERE userid = ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, inpur_id);
			rs = pstmt.executeQuery();
			if (rs.next()) {
				if (encrypted.equals(rs.getString("upasswd")))
					result = 1;
				else
					result = 0;
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs = null;
				if (pstmt != null)
					pstmt = null;
				if (conn != null)
					conn = null;
			} catch (Exception ef) {
				ef.printStackTrace();
			}
		}
		return result;
	}

	/**
	 * 회원 정보 보기
	 * 
	 * @param mid 회원 번호
	 * @return Member_List 객체
	 */
	public MemberInfo getUser(int mid) {
		String sql = "SELECT * FROM member_list WHERE mid = ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setInt(1, mid);
			rs = pstmt.executeQuery();
			if (rs.next()) {
				user = new MemberInfo();
//				user.setMid(mid);
				user.setMid("" + mid);
				user.setRid(rs.getInt("rid"));
				user.setUserid(rs.getString("userid"));
				user.setUname(rs.getString("uname"));
				user.setUpasswd(rs.getString("upasswd"));
				user.setUaddr(rs.getString("uaddr"));
				user.setUmail(rs.getString("umail"));
//				user.setRegdate(rs.getTimestamp("regdate"));
				user.setRegdate(rs.getString("regdate"));
			} else
				user = null;
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				if (rs != null)
					rs = null;
				if (pstmt != null)
					pstmt = null;
				if (conn != null)
					conn = null;
			} catch (Exception ef) {
				ef.printStackTrace();
			}
		}
		return user;
	}
}