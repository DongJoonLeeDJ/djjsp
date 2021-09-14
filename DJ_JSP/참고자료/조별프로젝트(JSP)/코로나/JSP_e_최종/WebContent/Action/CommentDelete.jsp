<%@page import="jsp.com.org.Posting.CommentDB"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR" pageEncoding="EUC-KR"%>
<%
String CommentNum = request.getParameter("CommentNum");
String Num = request.getParameter("num");
CommentDB CDB = new CommentDB();
CDB.Delete(CommentNum,Num);
%>
