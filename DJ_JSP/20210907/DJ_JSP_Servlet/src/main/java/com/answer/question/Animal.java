package com.answer.question;

public class Animal {
 //Kinds  //name  	//age 	//number
	private String Kinds;
	private String name;
	private int age;
	private String number;
	
	//Animal 선언시 아무 것도 입력하지 않아도 됨
	public Animal()
	{
		
	}
	
	//이게 무슨 동물인지 모르고 몇 번인지도 모르는 경우 
	public Animal(String name, int age)
	{
		this.name = name;
		this.age = age;
		this.number = null;
		this.Kinds = "Unknown";
	}
	
	public Animal(String kinds, String name, int age, String number) {
		super();
		Kinds = kinds;
		this.name = name;
		this.age = age;
		this.number = number;
	}
	
	public String getKinds() {
	//	return Kinds;
		switch (this.Kinds) {
		case "cat":
			return "고양이";
		case "dog":
			return "개";
		case "pig":
			return "돼지";
		case "cow":
			return "소";
		default:
			return "즘생";
		}
	}
	public void setKinds(String kinds) {
		Kinds = kinds;
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
