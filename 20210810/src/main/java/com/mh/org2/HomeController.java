package com.mh.org2;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

import com.mh.org2.cls.AA;
import com.mh.org2.cls.BB;

@Controller
//@Component
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	@Autowired
	AA aa;
	
	@Autowired
	BB bb;
	
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Model model) {
		System.out.println("aa.getAa() = "+aa.getAa());
		return "home";
	}
	
//	@RequestMapping(value = "/bb", method = RequestMethod.GET)
//	public String bb(Model model,HttpServletRequest req) {
//		
//		String number = (String) req.getParameter("bb");
//		bb.setAa(Integer.parseInt(number));
//		
//		System.out.println("bb.getAa() = "+bb.getAa());
//		model.addAttribute("bb",bb);
//		return "bb";
//	}
	
	@RequestMapping(value = "/bb", method = RequestMethod.GET)
	public String bb(Model model,String cc) {
		
		/*
		 * null 은 ... 숫자형으로 변경시.. Exception 발생
		 * NumberformatException...
		 */
		System.out.println("cc = "+cc);
		System.out.println("bb.getAa() = "+bb.getAa());
		
		model.addAttribute("aoao",bb);
		return "bb";
	}
	
	
}





