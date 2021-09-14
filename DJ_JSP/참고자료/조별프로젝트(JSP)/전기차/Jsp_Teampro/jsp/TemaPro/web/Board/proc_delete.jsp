<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="board.Board"%>
<%@ page import="board.DML_Board"%>
<%@ page import="Member.MemberInfo"%>
<%@ page import="java.io.PrintWriter"%>
<%
	request.setCharacterEncoding("UTF-8");
	PrintWriter script = response.getWriter();
	
	int article_idx = Integer.parseInt(request.getParameter("idx"));
	DML_Board dml = new DML_Board();
	int result = dml.delete_article(article_idx);
	
	script.println("<script>");
	if (result > 0) {
		// 글쓰기 성공
		script.println("alert('삭제 완료!')");
	} else if (result == 0) {
		// 실패
		script.println("alert('삭제 실패...')");
	} else {
		// 에러
		script.println("alert('에러.')");
	}
	script.println("location.href = 'index.jsp?contentPage=Board/notice_main.jsp'");
	script.println("</script>");
%>