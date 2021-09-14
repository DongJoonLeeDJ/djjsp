package com.javatest.animal;

public class Animal {
	private String kinds;
	private String name;
	private int age;
	private String number;
	
	public String getKinds() {
		switch (kinds) {
		case "cat":
			return "고양이";
		case "dog":
			return "개";
		case "pig":
			return "돼지";
		case "cow":
			return "소";
		default:
			return "인간";
		}
		
	}
	public void setKinds(String kinds) {
		this.kinds = kinds;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getNumber() {
		return number;
	}
	public void setNumber(String number) {
		this.number = number;
	}
	
	
}
