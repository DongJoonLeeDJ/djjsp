package com.mh.jpa02.controller;

import com.mh.jpa02.constant.Role;
import com.mh.jpa02.model.Member;
import com.mh.jpa02.service.MemberService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("members")
public class MemberController {

    @Autowired
    MemberService memberService;

    // 로그인 페이지
    @GetMapping("/login")
    public String login(){
        return "members/memberLoginForm";
    }

    @GetMapping("/login/error")
    public String loginerror(Model model){
        model.addAttribute("loginErrorMsg","아이디 또는 비밀번호를 확인 하세요");
        return "members/memberLoginForm";
    }

    // 회원가입 페이지
    @GetMapping("/sign")
    public String signup(Model model){
        model.addAttribute("member",new Member());
        return "members/memberSignForm";
    }

    // 회원가입 페이지
    @PostMapping("/sign")
    public String signup(Model model,Member member){
        model.addAttribute("member",member);
        member.setPassword(new BCryptPasswordEncoder().encode(member.getPassword()));
        member.setRole(Role.USER);
        memberService.createMember(member);
        return "redirect:/";
    }
}
