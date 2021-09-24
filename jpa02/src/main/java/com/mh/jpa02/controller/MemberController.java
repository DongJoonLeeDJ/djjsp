package com.mh.jpa02.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("members")
public class MemberController {

    @GetMapping("/signup")
    public String signup(){
        return "members/memberForm";
    }
}
