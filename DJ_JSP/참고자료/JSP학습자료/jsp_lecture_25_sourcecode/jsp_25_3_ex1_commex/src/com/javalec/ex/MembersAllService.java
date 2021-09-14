package com.javalec.ex;

import java.util.ArrayList;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class MembersAllService implements Service {
	
	public MembersAllService() {
		// TODO Auto-generated constructor stub
	}

	@Override
	public ArrayList<MemberDto> execute(HttpServletRequest request, HttpServletResponse response) {
		// TODO Auto-generated method stub
		
		MemberDao dao = MemberDao.getInstance();
		return dao.membersAll();
	}

}
