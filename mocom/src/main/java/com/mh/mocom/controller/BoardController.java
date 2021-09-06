package com.mh.mocom.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.mh.mocom.dao.BoardDao;

@Controller
@RequestMapping(value="board")
public class BoardController {
	
	@Autowired
	BoardDao dao;
	
	@RequestMapping(value="main")
	public String main(Model model) {
		model.addAttribute("list", dao.selectlist());
		model.addAttribute("title", "Qna");
		return "board/main";
	}
	
}
