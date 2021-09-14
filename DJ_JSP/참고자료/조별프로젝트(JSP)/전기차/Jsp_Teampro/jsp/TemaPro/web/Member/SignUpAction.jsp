<%@page import="java.util.Date"%>
<%@page import="java.text.SimpleDateFormat"%>
<%@page import="java.io.PrintWriter"%>
<%@page import="Member.MemberDBManage"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
        <%
        	MemberDBManage su = new MemberDBManage();
        	String sucValue = "";
        	//한글
			SimpleDateFormat format1 = new SimpleDateFormat ( "yyyy-MM-dd HH:mm:ss");
			Date time = new Date();
			String time1 = format1.format(time);
        	request.setCharacterEncoding("utf-8");
        	
        	String userid = (String)request.getParameter("userid");
        	String upasswd = (String)request.getParameter("upasswd");
        	String uname = (String)request.getParameter("uname");
        	String uaddr = (String)request.getParameter("uaddr");
        	String umail = (String)request.getParameter("umail");
        	
        	
        	PrintWriter script = response.getWriter();
        	if(su.SignUp(userid,upasswd,uname,uaddr,umail,time1)){
    		script.println("<script>");
    		script.println("alert('회원가입 성공! 로그인 해주세요')");
    		script.println("location.href = '../index.jsp'");
    		script.println("</script>");
        	}else{
        		script.println("<script>");
        		script.println("alert('회원가입 실패! 잠시 후 다시 시도해주세요')");
        		script.println("history.back()");
        		script.println("</script>");
        	}
        %>