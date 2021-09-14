package com.javatest.ldjgood;

public class Customer {
	private String name;
	private String id;
	private String pw;
	private String major;
	private String gender;
	private String protocol;

	public String getMajor() {
		return major;
	}

	public void setMajor(String major) {
		this.major = major;
	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public String getProtocol() {
		return protocol;
	}

	public void setProtocol(String protocol) {
		this.protocol = protocol;
	}

	public String[] getHobbys() {
		return hobbys;
	}

	public void setHobbys(String[] hobbys) {
		// this.hobbys = hobbys;
		this.hobbys = new String[hobbys.length];
		System.arraycopy(hobbys, 0, this.hobbys, 0, hobbys.length);
		for (int i = 0; i < this.hobbys.length; i++) {
			switch (this.hobbys[i]) {
			case "cook":
				this.hobbys[i] = "요리";
				break;
			case "run":
				this.hobbys[i] = "달리기";
				break;
			case "swim":
				this.hobbys[i] = "수영";
				break;
			case "sleep":
				this.hobbys[i] = "수면";
				break;
			case "read":
				this.hobbys[i] = "독서";
				break;
			default:
			}
		}
	}

	private String[] hobbys;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getPw() {
		return pw;
	}

	public void setPw(String pw) {
		this.pw = pw;
	}
}
