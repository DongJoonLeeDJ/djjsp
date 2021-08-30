package com.mh.mocom.dao;

import org.apache.ibatis.session.SqlSession;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.mh.mocom.dto.MemberDto;

@Repository
public class MemberDao {

	@Autowired
	SqlSession sqlsession;
	
	public MemberDto chklogin(MemberDto dto) {
		dto = sqlsession.selectOne("member.loginchk",dto);
		return dto;
	}

}
