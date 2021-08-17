package com.mh.org4.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class BController {

	@RequestMapping(value = "/b")
	public String b() {
		System.out.println("B b");
		return "b";
	}
}
