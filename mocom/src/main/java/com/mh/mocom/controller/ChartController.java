package com.mh.mocom.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class ChartController {

	@RequestMapping(value = "/testjson", method = RequestMethod.GET)
	@ResponseBody
	public String testjson() {
		int[] myages = {5,40,30,25,15,3}; 
		return "[\r\n"
				+ "  {\"name\": \"Tom\", \"age\": "+myages[0]+" },\r\n"
				+ "  {\"name\": \"Franz\", \"age\": "+myages[1]+" },\r\n"
				+ "  {\"name\": \"Chris Calip\", \"age\": "+myages[2]+" },\r\n"
				+ "  {\"name\": \"Maria\", \"age\": 30 },\r\n"
				+ "  {\"name\": \"Fred\", \"age\": 50 },\r\n"
				+ "  {\"name\": \"R Stallman\", \"age\": 60 }\r\n"
				+ "]";
	}
}
