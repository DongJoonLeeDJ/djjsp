package org20210809;

public class A {
	
	private int aa;
	
	public A() {}
	public A(int aa) {
		super();
		this.aa = aa;
	}

	//alt + shift + s -> r getter setter 자동만들기
	public int getAa() {
		return aa;
	}

	public void setAa(int aa) {
		this.aa = aa;
	}

}
