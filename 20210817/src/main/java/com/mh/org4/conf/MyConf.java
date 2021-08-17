package com.mh.org4.conf;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class MyConf {

	@Bean
	@Qualifier(value = "aaa")
	public A a1() {
		A a = new A();
		return a;
	}
	
	@Bean
	@Qualifier(value = "bbb")
	public A a2() {
		A a = new A();
		return a;
	}
}
