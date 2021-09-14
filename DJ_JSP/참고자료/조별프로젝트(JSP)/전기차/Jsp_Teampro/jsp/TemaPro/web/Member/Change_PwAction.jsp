<%@page import="Member.MemberInfo"%>
<%@page import="java.io.PrintWriter"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@page import="Member.MemberDBManage"%>
<%
	MemberInfo userinfo  = (MemberInfo)session.getAttribute("userinfo");
	String userid = userinfo.getUserid();
	String nowpw = request.getParameter("nowpw");
	String wpw = request.getParameter("upasswd");
	
	MemberDBManage mdb = new MemberDBManage();
	PrintWriter script = response.getWriter();

	if(mdb.ChangePw(wpw, userid, nowpw)){

		script.println("<script>");
		script.println("alert('성공')");
		script.println("location.href = '../index.jsp'");
		script.println("</script>");
		
	}else{
		
		script.println("<script>");
		script.println("alert('실패')");
		script.println("history.back()");
		script.println("</script>");
		
	}
%>