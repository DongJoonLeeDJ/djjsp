package CarSearch;

public class CarS_DTO {
	private String div;
	private String company;
	private String cartype;
	private String price;
	
	public String getDiv() {
		return div;
	}

	public void setDiv(String div) {
		this.div = div;
	}

	public String getCompany() {
		return company;
	}

	public void setCompany(String company) {
		this.company = company;
	}

	public String getCartype() {
		return cartype;
	}

	public void setCartype(String cartype) {
		this.cartype = cartype;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}
	
	@Override
	public String toString() {
		return "CarS_DTO [div=" + div + ", company=" + company + ", cartype=" + cartype + ", price=" + price + "]";
	}
}
