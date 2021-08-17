package com.mh.org4.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.mh.org4.dao.TestDao;
import com.mh.org4.dto.TestDto;

@Controller
public class ListController {

	@Autowired
	TestDao dao;
	
	@RequestMapping(value="list")
	public String list(Model model) {
		List<TestDto> rvalue = dao.doList();
		model.addAttribute("a",rvalue);
		return "list";
	}
	
}
