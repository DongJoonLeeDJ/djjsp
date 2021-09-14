package board;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import DB.DBConnect;

/**
 * DML: SELECT || INSERT || UPDATE || DELETE row(s)
 * 
 * @author jaemoonnlee
 *
 */
public class DML_BoardInfo {
	private Connection conn = null;
	private PreparedStatement pstmt = null;
//	private Statement stmt = null;
//	private CallableStatement cs = null;
	private ResultSet rs = null;
//	private Board article = null;
	private Board_Info info = null;
	private List<Board_Info> list = null;

	/**
	 * 게시판 정보 입력. 게시판 아이디, 게시판 이름.
	 * 
	 * @param input_bid   PK, int
	 * @param input_bname varchar(20)
	 * @return > 0 QUERY OK || == 0 QUERY DOESNT WORK || == -1 ERROR
	 */
	public int insert_board_info(int input_bid, String input_bname) {
		int result = -1;
		String sql = "INSERT INTO board_info (bid, bname) VALUES (?, ?)";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setInt(1, input_bid);
			pstmt.setString(2, input_bname);
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
	 * 게시판 이름 수정.
	 * 
	 * @param input_bid   PK, int
	 * @param input_bname varchar(20)
	 * @return > 0 QUERY OK || == 0 QUERY DOESNT WORK || == -1 ERROR
	 */
	public int update_board_info(int input_bid, String input_bname) {
		int result = -1;
		String sql = "UPDATE board_info SET bname = ? WHERE bid = ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, input_bname);
			pstmt.setInt(2, input_bid);
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
	 * 게시판 삭제. (주의. 게시판 삭제시 하위 게시글 모두 삭제)
	 * 
	 * @param input_bid PK, int
	 * @return > 0 QUERY OK || == 0 QUERY DOESNT WORK || == -1 ERROR
	 */
	public int delete_board_info(int input_bid) {
		int result = -1;
		String sql = "DELETE FROM charge.board_info WHERE bid = ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setInt(1, input_bid);
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
	 * 전체 게시판 목록 보기
	 * 
	 * @return
	 */
	public ArrayList<Board_Info> select_board_info() {
		list = new ArrayList<>();
		String sql = "SELECT bid, bname FROM board_info";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			rs = pstmt.executeQuery();
			while (rs.next()) {
				info = new Board_Info();
				info.setBid(rs.getInt("bid"));
				info.setBname(rs.getString("bname"));
				list.add(info);
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
		return (ArrayList<Board_Info>) list;
	}
	
	public Board_Info get_board_info(int bid) {
		String sql = "SELECT * FROM board_info WHERE bid = ?";
		try {
			if (conn == null)
				conn = DBConnect.getInstance();
			pstmt = conn.prepareStatement(sql);
			pstmt.setInt(1, bid);
			rs = pstmt.executeQuery();
			while (rs.next()) {
				info = new Board_Info();
				info.setBid(bid);
				info.setBname(rs.getString("bname"));
				info.setBcode(rs.getString("bcode"));
				info.setBname_kor(rs.getString("bname_kor"));
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
		return info;
	}
}