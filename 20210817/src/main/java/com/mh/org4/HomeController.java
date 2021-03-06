package com.mh.org4;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	@Autowired
	private DBM dbm;
	
	
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home() {
		dbm.doA();
		return "home";
	}
	/*
	 * requestMapping 으로 등록된 주소로만..
	 * 브라우저 요청이 가능하다..
	 * 등록된 메서드 안에서.. 작업을 수행한다...
	 * home.jsp a.jsp b.jsp
	 */
}
