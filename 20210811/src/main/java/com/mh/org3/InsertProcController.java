package com.mh.org3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.mh.org3.db.DBManager;

@Controller
public class InsertProcController {

	/*
	 * spring 객체 생성...
	 *  
	 * Spring IOC복습
	 * Commponent scan
	 * 
	 * mybatis 연결...
	 * spring 객체설정..
	 *  
	 */
	@Autowired
	DBManager dbm;

	@RequestMapping(value = "/insertproc", method = RequestMethod.POST)
	public String insertproc(Model model, String para1, String para2) {
		dbm.inserttest(para1, para2);
		return "insertproc";
	}
	
	
	
	
	
	
	
	
}
