package example;

import java.sql.Timestamp;

public class Festival {

	@Override
	public String toString() {
		return "Festival [fes_idx=" + fes_idx + ", fes_name=" + fes_name + ", fes_start=" + fes_start + ", fes_end="
				+ fes_end + ", fes_content=" + fes_content + ", fes_tel=" + fes_tel + ", fes_home=" + fes_home
				+ ", fes_addr=" + fes_addr + ", fes_x=" + fes_x + ", fes_y=" + fes_y + ", toString()="
				+ super.toString() + "]";
	}

	private int fes_idx;
	private String fes_name;
	private Timestamp fes_start;
	private Timestamp fes_end;
	private String fes_content; 
	private String fes_tel;
	private String fes_home;
	private String fes_addr;

	private String fes_x;
	private String fes_y;
	public Festival() {
		
	}
	
	public Festival(int fes_idx, String fes_name, Timestamp fes_start, Timestamp fes_end, String fes_content,
			String fes_tel, String fes_home, String fes_addr,String fes_x,String fes_y) {
		super();
		this.fes_idx = fes_idx;
		this.fes_name = fes_name;
		this.fes_start = fes_start;
		this.fes_end = fes_end;
		this.fes_content = fes_content;
		this.fes_tel = fes_tel;
		this.fes_home = fes_home;
		this.fes_addr = fes_addr;
		this.fes_x = fes_x;
		this.fes_y = fes_y;
	}
	public int getFes_idx() {
		return fes_idx;
	}
	public void setFes_idx(int fes_idx) {
		this.fes_idx = fes_idx;
	}
	public String getFes_name() {
		return fes_name;
	}
	public void setFes_name(String fes_name) {
		this.fes_name = fes_name;
	}
	public Timestamp getFes_start() {
		return fes_start;
	}
	public void setFes_start(Timestamp fes_start) {
		this.fes_start = fes_start;
	}
	public Timestamp getFes_end() {
		return fes_end;
	}
	public void setFes_end(Timestamp fes_end) {
		this.fes_end = fes_end;
	}
	public String getFes_content() {
		return fes_content;
	}
	public void setFes_content(String fes_content) {
		this.fes_content = fes_content;
	}
	public String getFes_tel() {
		return fes_tel;
	}
	public void setFes_tel(String fes_tel) {
		this.fes_tel = fes_tel;
	}
	public String getFes_home() {
		return fes_home;
	}
	public void setFes_home(String fes_home) {
		this.fes_home = fes_home;
	}
	public String getFes_addr() {
		return fes_addr;
	}
	public void setFes_addr(String fes_addr) {
		this.fes_addr = fes_addr;
	}
	public String getFes_x() {
		return fes_x;
	}

	public void setFes_x(String fes_x) {
		this.fes_x = fes_x;
	}

	public String getFes_y() {
		return fes_y;
	}

	public void setFes_y(String fes_y) {
		this.fes_y = fes_y;
	}
}
