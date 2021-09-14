package jsp.com.org.Covid_Data;

public class Covid_Data_Info {
	private String addr;
	private	int addrcount;
	
	public Covid_Data_Info(){}
	
	public String getAddr() {
		return addr;
	}
	public void setAddr(String addr) {
		this.addr = addr;
	}
	public int getAddrcount() {
		return addrcount;
	}
	public void setAddrcount(int addrcount) {
		this.addrcount = addrcount;
	}
	@Override
	public String toString() {
		return "["+addr+","+addrcount+"]";
	}
}
