package com.mh.org1.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import com.mh.org1.cls.AA;

@Configuration
public class AppConf {

	// import 자동 ctrl + shift + o
	@Bean
	public AA aa() {
		AA aa = new AA();
		return aa;
	}
}
