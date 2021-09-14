package com.javalec.ex;

import java.util.ArrayList;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public interface Service {
	public ArrayList<MemberDto> execute(HttpServletRequest request, HttpServletResponse response);
}
