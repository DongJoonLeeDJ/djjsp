package org20210809;

public class B {

	private A a;

	//alt +shift + s -> o 생성자 자동만들기
	public B() {}
	public B(A a) {
		super();
		this.a = a;
	}

	public A getA() {
		return a;
	}

	public void setA(A a) {
		this.a = a;
	}
	
}
