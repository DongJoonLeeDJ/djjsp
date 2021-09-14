<%@page import="Member.MemberInfo"%>
<%@page import="java.io.PrintWriter"%>
<%@page import="Member.MemberDBManage"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
MemberInfo userinfo  = (MemberInfo)session.getAttribute("userinfo");

String userid = userinfo.getUserid();
String uname = (String)request.getParameter("uname");
String uaddr = (String)request.getParameter("uaddr");
String umail = (String)request.getParameter("umail");
PrintWriter script = response.getWriter();
MemberDBManage mdb = new MemberDBManage();

if(uname.equals("")){
	uname = userinfo.getUname();
}
if(uaddr.equals("")){
	uaddr = userinfo.getUaddr();
}
if(umail.equals("")){
	umail = userinfo.getUmail();
}


if(mdb.ChangeInfo(userid, uname, uaddr, umail)){
	
	userinfo.setUname(uname);
	userinfo.setUaddr(uaddr);
	userinfo.setUmail(umail);
	session.setAttribute("userinfo", userinfo);
	
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
