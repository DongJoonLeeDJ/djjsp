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
    public UserDetails loadUserByUsername(String email) throws UsernameNotFoundException {
//        System.out.println(email);
        Member member = memberRepository.findByEmail(email);
//        System.out.println(member);
        if ( member == null)
            throw new UsernameNotFoundException(email);
        return User.builder()
                .username(member.getEmail())
                .password(member.getPassword())
//                .password(new BCryptPasswordEncoder().encode("12341234"))
                .roles(member.getRole().toString())
                .build();
        // ADMIN USER
    }

    public void createMember(Member member) {
        memberRepository.save(member);  //insert 구문 실행되는부분
    }
}
