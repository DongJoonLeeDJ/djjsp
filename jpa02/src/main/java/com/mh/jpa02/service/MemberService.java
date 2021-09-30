package com.mh.jpa02.service;

import com.mh.jpa02.model.Member;
import com.mh.jpa02.repository.MemberRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

@Service
public class MemberService implements UserDetailsService {

    @Autowired
    MemberRepository memberRepository;

    @Override
    public UserDetails loadUserByUsername(String s) throws UsernameNotFoundException {
        return User.builder()
                .username("aa@naver.com")
                .password(new BCryptPasswordEncoder().encode("12341234"))
                .roles("USER")
                .build();

        // ADMIN USER
    }

    public void createMember(Member member) {
        memberRepository.save(member);  //insert 구문 실행되는부분
    }
}
