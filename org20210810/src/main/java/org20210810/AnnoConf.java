package org20210810;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class AnnoConf {

	@Bean
	@Qualifier("aa1")
	public AA aa1() {
		return new AA();
	}
	
	@Bean
	@Qualifier("aa2")
	public AA aa2() {
		return new AA();
	}
	
	@Bean
	public Lib lib() {
		return new Lib();
	}
}
