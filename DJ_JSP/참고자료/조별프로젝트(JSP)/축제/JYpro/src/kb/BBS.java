package kb;

public class BBS {

	private String idx;
	private String id;
	private String title;
	private String text;
	private String date;
	@Override
	public String toString() {
		return "BBS [idx=" + idx + ", id=" + id + ", title=" + title + ", text=" + text + ", date=" + date + "]";
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getText() {
		return text;
	}
	public void setText(String text) {
		this.text = text;
	}
	public String getDate() {
		return date;
	}
	public void setDate(String date) {
		this.date = date;
	}
	public String getIdx() {
		return idx;
	}
	public void setIdx(String idx) {
		this.idx = idx;
	}
	
	

}
