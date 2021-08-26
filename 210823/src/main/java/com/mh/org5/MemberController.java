package com.mh.org5;

import java.util.List;

import org.apache.ibatis.session.SqlSession;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class MemberController {
	/*
	 * mybatis 설정
	 * 
	 * pom.xml 6가지 jar 가져오는거
	 * maven 
	 * 1. mybatis , 2. mybatis-spring, 3.spring-jdbc, 4.dbcp, 5.mysql-conner, 6.cglib
	 * 
	 * 2.servlet-context.xml
	 * 3가지 bean 객체 설정
	 * 1. dbcp(mysql커넥션설정정보)
	 * 2.sqlsessionfactory(xml파일을 읽어서 sql 설정) 
	 * 3.sqlsseion (sql구문실행)
	 * 
	 * controller requestmappeing
	 * memberlist	-> resultType 반환되는거
	 * memberinsert -> parameterType 매개변수 설정하는 방식
	 * 
	 * MemberController -> MemberService -> MemberDao -> MemberDto -> member.xml
	 * 
	 *  select
	 * 	insertform -> insert 
	 *  updateform -> update
	 *  delete
	 */
	@Autowired
	SqlSession sqlsession;
	
	@RequestMapping(value="memberlist")
	public String memberlist(Model model) {
		List<MemberDto> list = sqlsession.selectList("member.select");
		for(MemberDto dto : list) {
			System.out.println("dto = "+ dto);
		}
		
		model.addAttribute("aa","bb");
		model.addAttribute("alist",list);
		return "member/list";
	}
	/*
	 * request getParameter("id");
	 * String id, String pw
	 */
//	@RequestMapping(value="memberinsert")
//	public String memberinsert(String id, 
//							String pw, 
//							String age,
//							String gender,MemberDto dto) {
//		System.out.println("id = "+id);
//		System.out.println("pw = "+pw);
//		System.out.println("age = "+age);
//		System.out.println("gender = "+gender);
//		System.out.println("dto = "+ dto);
//		sqlsession.insert("member.insert");
//		return "member/insert";
//	}
	
	@RequestMapping(value="memberinsert")
	public String memberinsert(MemberDto dto) {
		sqlsession.insert("member.insert",dto);
		return "member/insert";
	}
	
	@RequestMapping(value="memberinsertform")
	public String memberinsertform() {
		return "member/insertform";
	}
	
	@RequestMapping(value="memberupdateform")
	public String memberupdateform(int idx,Model model) {
		System.out.println(idx);
		MemberDto dto = sqlsession.selectOne("member.selectone",idx);
		System.out.println(dto);
		model.addAttribute("member",dto);
		return "member/updateform";
	}
	
	@RequestMapping(value="memberupdate")
	public String memberupdate(MemberDto dto,Model model) {
		System.out.println("update ======\n"+dto);
		sqlsession.update("member.update",dto);
		return "redirect:memberlist";
	}
	
	
}









