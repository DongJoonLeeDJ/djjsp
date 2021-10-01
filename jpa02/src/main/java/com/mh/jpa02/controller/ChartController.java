package com.mh.jpa02.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class ChartController {

    @GetMapping("chart")
    public String chart(){
        return "chart";
    }
}
