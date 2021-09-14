<%@page import="java.io.PrintWriter"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
	session.invalidate();
	PrintWriter script = response.getWriter();
	script.println("<script>");
	script.println("location.href = './index.jsp'");
	script.println("</script>");
	// 세션 정보 삭제	
%>