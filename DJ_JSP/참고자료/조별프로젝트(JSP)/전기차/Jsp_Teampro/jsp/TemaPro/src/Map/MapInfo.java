package Map;

public class MapInfo {
	private String addr;
	private String type;
	private String spot;

	public String getAddr() {
		return addr;
	}
	public void setAddr(String addr) {
		this.addr = addr;
	}
	public String getType() {
		return type;
	}
	public void setType(String type) {
		this.type = type;
	}
	public String getSpot() {
		return spot;
	}
	public void setSpot(String spot) {
		this.spot = spot;
	}
	@Override
	public String toString() {
		return "MapInfo [addr=" + addr + ", type=" + type + ", spot=" + spot + "]";
	}
	
}