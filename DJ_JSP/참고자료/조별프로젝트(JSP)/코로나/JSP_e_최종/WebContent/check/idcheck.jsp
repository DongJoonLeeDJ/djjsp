<%@page import="jsp.com.org.MemberCheck"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    
    <%
   String ID = request.getParameter("user_id");
    MemberCheck Mcheck = new MemberCheck();
	int ret = Mcheck.check(ID);
	out.println(ret);
    %>
    

