package board;

/**
 * DATABASE: charge TABLE NAME: board_info COLUMNS: bid(PK, int), bname(String)
 * 
 * @author jaemoonnlee
 *
 */
public class Board_Info {
	/**
	 * 게시판 키
	 */
	private int bid;
	/**
	 * 게시판 이름
	 */
	private String bname;
	private String bcode;
	private String bname_kor;

	public String getBcode() {
		return bcode;
	}

	public void setBcode(String bcode) {
		this.bcode = bcode;
	}

	public String getBname_kor() {
		return bname_kor;
	}

	public void setBname_kor(String bname_kor) {
		this.bname_kor = bname_kor;
	}

	public Board_Info() {
	}

	public int getBid() {
		return bid;
	}

	public void setBid(int bid) {
		this.bid = bid;
	}

	public String getBname() {
		return bname;
	}

	public void setBname(String bname) {
		this.bname = bname;
	}
}
