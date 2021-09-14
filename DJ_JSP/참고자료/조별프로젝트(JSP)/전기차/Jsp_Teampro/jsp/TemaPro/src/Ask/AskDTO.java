package Ask;

public class AskDTO {
	private String cartype;
	private String sido;
	private String city;
	private String dep;
	private String pn;
	public String getCartype() {
		return cartype;
	}
	public void setCartype(String cartype) {
		this.cartype = cartype;
	}
	public String getSido() {
		return sido;
	}
	public void setSido(String sido) {
		this.sido = sido;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public String getDep() {
		return dep;
	}
	public void setDep(String dep) {
		this.dep = dep;
	}
	public String getPn() {
		return pn;
	}
	public void setPn(String pn) {
		this.pn = pn;
	}
	
	@Override
	public String toString() {
		return "AskInfo [cartype=" + cartype + ", sido=" + sido + ", city=" + city + ", dep=" + dep + ", pn=" + pn
				+ "]";
	}	
}
