package board;

import java.sql.Timestamp;

/**
 * rp_idx(PK, AI, int), article_idx(FK, int), mid(FK, int), rp_level(int),
 * rp_context(varchar(200)), reg_date(timestamp)
 * 
 * @author jaemoonnlee
 *
 */
public class Reply {
	private int rp_idx;
	private int article_idx;
	private int mid;
	private int rp_level;
	private String rp_context;
	private Timestamp reg_date;

	public int getRp_idx() {
		return rp_idx;
	}

	public void setRp_idx(int rp_idx) {
		this.rp_idx = rp_idx;
	}

	public int getArticle_idx() {
		return article_idx;
	}

	public void setArticle_idx(int article_idx) {
		this.article_idx = article_idx;
	}

	public int getMid() {
		return mid;
	}

	public void setMid(int mid) {
		this.mid = mid;
	}

	public int getRp_level() {
		return rp_level;
	}

	public void setRp_level(int rp_level) {
		this.rp_level = rp_level;
	}

	public String getRp_context() {
		return rp_context;
	}

	public void setRp_context(String rp_context) {
		this.rp_context = rp_context;
	}

	public Timestamp getReg_date() {
		return reg_date;
	}

	public void setReg_date(Timestamp reg_date) {
		this.reg_date = reg_date;
	}
}