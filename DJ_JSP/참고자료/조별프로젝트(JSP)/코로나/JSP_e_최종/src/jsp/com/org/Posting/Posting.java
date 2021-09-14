package jsp.com.org.Posting;

public class Posting {
	private int num;
	private String title;
	private String userid;
	private String date;
	private String content;
	public Posting() {}
	public int getNum() {
		return num;
	}
	public void setNum(int num) {
		this.num = num;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getUserid() {
		return userid;
	}
	public void setUserid(String userid) {
		this.userid = userid;
	}
	public String getDate() {
		return date;
	}
	public void setDate(String date) {
		this.date = date;
	}
	public String getContent() {
		return content;
	}
	public void setContent(String content) {
		this.content = content;
	}
	@Override
	public String toString() {
		return "Posting [num=" + num + ", title=" + title + ", userid=" + userid + ", date=" + date + ", content="
				+ content + "]";
	}

	
}
