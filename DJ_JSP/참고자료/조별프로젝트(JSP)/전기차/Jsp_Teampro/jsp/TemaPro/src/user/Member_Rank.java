package user;

/**
 * DATABASE: charge TABLE NAME: member_rank COLUMNS: rid(PK, int), rname(NN)
 * 
 * @author jaemoonnlee
 *
 */
public class Member_Rank {
	private int rid;
	private String rname;

	public Member_Rank() {
	}

	public Member_Rank(int rid, String rname) {
		this.rid = rid;
		this.rname = rname;
	}

	public int getRid() {
		return rid;
	}

	public void setRid(int rid) {
		this.rid = rid;
	}

	public String getRname() {
		return rname;
	}

	public void setRname(String rname) {
		this.rname = rname;
	}

}
