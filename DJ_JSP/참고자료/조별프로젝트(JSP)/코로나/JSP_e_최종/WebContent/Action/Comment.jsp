<%@page import="jsp.com.org.Posting.Comment"%>
<%@page import="jsp.com.org.Posting.CommentDB"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%
String id = request.getParameter("id");
String num = request.getParameter("num");
String Comment = request.getParameter("Comment");

CommentDB CDB = new CommentDB();
CDB.Comment(id,num,Comment);
%>


