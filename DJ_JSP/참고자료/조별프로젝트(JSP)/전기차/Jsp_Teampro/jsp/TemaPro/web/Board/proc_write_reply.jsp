<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="board.DML_Board"%>
<%
	request.setCharacterEncoding("UTF-8");

	/*
	parameters
	"board_title": board_title,
	"article_idx": article_idx,
	"mid": mid,
	"rp_context": rp_context,
	"rp_level": rp_level
	*/
	String board = request.getParameter("board_title");
	int article_idx = Integer.parseInt(request.getParameter("article_idx"));
	int mid = Integer.parseInt(request.getParameter("mid"));
	String rp_context = request.getParameter("rp_context");
	int rp_level = Integer.parseInt(request.getParameter("rp_level"));
	
	DML_Board dml = new DML_Board();
	int result = -1;
	result = dml.write_reply(article_idx, mid, rp_level, rp_context);
	// 바로 아래는 @ResponseBody 와 비슷한 역할을 하는 것
	out.print(result);
%>