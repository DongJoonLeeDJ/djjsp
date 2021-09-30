package com.mh.jpa02.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("members")
public class MemberController {

    // 로그인 페이지
    @GetMapping("/login")
    public String login(){
        return "members/memberLoginForm";
    }

    // 회원가입 페이지
    @GetMapping("/sign")
    public String signup(){
        return "members/memberSignForm";
    }
}
