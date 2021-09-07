package com.answer.question;

public class Student {
//name, age, number
	private String name;
	private int age;
	private String number;//넘버링이 0부터 시작할 수 있으므로
	
	public Student(String name, int age, String number) {
		super();
		this.name = name;
		this.age = age;
		this.number = number;
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
