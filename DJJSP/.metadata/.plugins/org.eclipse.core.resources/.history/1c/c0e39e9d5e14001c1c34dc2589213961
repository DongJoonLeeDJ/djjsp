package com.t3.musicchart;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.t3.musicchart.dao.ChartDao;
import com.t3.musicchart.dto.ChartDto;

@Controller
public class ChartController {
	
	@Autowired
	ChartDao dao;
	
	@RequestMapping(value="June_page")
	public String june_insertform(Model model) {
		List<ChartDto> list = dao.JuneSelect();
		
		model.addAttribute("june_list", list);
		
		return "chartFolder/june";
	}
	
	@RequestMapping(value="July_page")
	public String july_insertform(Model model) {
		List<ChartDto> list = dao.JulySelect();
		
		model.addAttribute("july_list", list);
		
		return "chartFolder/july";
	}
	
	@RequestMapping(value="August_page")
	public String august_insertform(Model model) {
		List<ChartDto> list = dao.JulySelect();
		
		model.addAttribute("august_list", list);
		
		return "chartFolder/august";
	}
}
