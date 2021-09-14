package CarSupportFund;

public class CarSF_DTO {
	private String sido;
	private String elec;
	private String hydro;
	
	public String getSido() {
		return sido;
	}


	public void setSido(String sido) {
		this.sido = sido;
	}


	public String getElec() {
		return elec;
	}


	public void setElec(String elec) {
		this.elec = elec;
	}


	public String getHydro() {
		return hydro;
	}


	public void setHydro(String hydro) {
		this.hydro = hydro;
	}
	
	@Override
	public String toString() {
		return "CarDTO [sido=" + sido + ", elec=" + elec + ", hydro=" + hydro + "]";
	}
}
