package org20210810;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;

public class Lib {

	@Autowired
	@Qualifier("aa1")
	AA aa;
	
	@Autowired(required = false)
	BB bb;
	
	public void print() {
		aa.doAA();
	}
}
