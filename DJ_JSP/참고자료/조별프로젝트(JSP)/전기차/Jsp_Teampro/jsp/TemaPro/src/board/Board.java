package board;

import java.sql.Timestamp;

/**
 * DATABASE: charge TABLE NAME: board COLUMNS: article_idx(PK, AI, int), bid(FK,
 * int), mid(int), title(varchar(30)), content(text), reg_date(date),
 * mod_date(date)
 * 
 * @author jaemoonnlee
 *
 */
public class Board {
	/**
	 * 회원 이름(need to JOIN member_list)
	 */
	private String uname;

	public String getUname() {
		return uname;
	}

	public void setUname(String uname) {
		this.uname = uname;
	}

	/**
	 * 게시글 키
	 */
	private int article_idx;
	/**
	 * 게시판 키(FK)
	 */
	private int bid;
	/**
	 * 회원 키(FK)
	 */
	private int mid;
	/**
	 * 게시글 제목
	 */
	private String title;
	/**
	 * 게시글 내용
	 */
	private String content;
	/**
	 * 게시글 작성일자
	 */
	private Timestamp reg_date;
	/**
	 * 게시글 수정일자
	 */
	private Timestamp mod_date;

	public Board() {
	}

	public Board(int bid, int mid, String title, String content) {
		this.bid = bid;
		this.mid = mid;
		this.title = title;
		this.content = content;
	}

	public int getArticle_idx() {
		return article_idx;
	}

	public void setArticle_idx(int article_idx) {
		this.article_idx = article_idx;
	}

	public int getBid() {
		return bid;
	}

	public void setBid(int bid) {
		this.bid = bid;
	}

	public int getMid() {
		return mid;
	}

	public void setMid(int mid) {
		this.mid = mid;
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public String getContent() {
		return content;
	}

	public void setContent(String content) {
		this.content = content;
	}

	public Timestamp getReg_date() {
		return reg_date;
	}

	public void setReg_date(Timestamp reg_date) {
		this.reg_date = reg_date;
	}

	public Timestamp getMod_date() {
		return mod_date;
	}

	public void setMod_date(Timestamp mod_date) {
		this.mod_date = mod_date;
	}

	@Override
	public String toString() {
		return "Board [uname=" + uname + ", article_idx=" + article_idx + ", bid=" + bid + ", mid=" + mid + ", title="
				+ title + ", content=" + content + ", reg_date=" + reg_date + ", mod_date=" + mod_date + "]";
	}

}
