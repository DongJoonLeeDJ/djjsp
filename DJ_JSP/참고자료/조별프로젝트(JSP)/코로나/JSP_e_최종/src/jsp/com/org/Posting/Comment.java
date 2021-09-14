package jsp.com.org.Posting;

public class Comment {
	private int PageNum;
	private int CommentNum;
	private String Context;
	private String ID;
	
	public int getPageNum() {
		return PageNum;
	}
	public void setPageNum(int pageNum) {
		PageNum = pageNum;
	}
	public int getCommentNum() {
		return CommentNum;
	}
	public void setCommentNum(int commentNum) {
		CommentNum = commentNum;
	}
	public String getContext() {
		return Context;
	}
	public void setContext(String context) {
		Context = context;
	}
	public String getID() {
		return ID;
	}
	public void setID(String iD) {
		ID = iD;
	}
	
	@Override
	public String toString() {
		return "Comment [PageNum=" + PageNum + ", CommentNum=" + CommentNum + ", Context=" + Context + ", ID=" + ID
				+ "]";
	}
}
