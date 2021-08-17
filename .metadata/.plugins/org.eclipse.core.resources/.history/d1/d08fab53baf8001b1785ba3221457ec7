package org20210809;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class AnnoMain {

	public static void main(String[] args) {
		/*
		 * AnnoMain -> 메인함수..
		 * AnnotationConfigApplicationContext 객체담는통
		 * AnnoConf 객체 설정정보 담은 클래스
		 * 
		 * A... 객체 담는통안에 들어갈 클래스
		 * B... 객체 담는통안에 들어갈 클래스
		 */
		AnnotationConfigApplicationContext acac
		= new AnnotationConfigApplicationContext(AnnoConf.class);
		
		// 싱글톤...
		A a1 = acac.getBean(A.class);
		A a2 = acac.getBean(A.class);
		B b = acac.getBean(B.class);
		
		System.out.println(a1);
		System.out.println(a2);
		System.out.println(b);
		
		acac.close();
		
	}
}












