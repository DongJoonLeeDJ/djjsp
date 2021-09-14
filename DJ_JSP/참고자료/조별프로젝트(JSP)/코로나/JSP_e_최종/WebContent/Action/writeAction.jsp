<%@page import="jsp.com.org.Posting.PostingDB"%>
<%@page import="java.io.PrintWriter"%>
<%@page import="jsp.com.org.Posting.Posting"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	Posting post= new Posting();
    PrintWriter w = response.getWriter();
	out.println(post.toString());
    PrintWriter writer = response.getWriter();
	String userid= (String)session.getAttribute("ID");
	String title= (String)request.getParameter("title");
	String content=(String)request.getParameter("content");
	

	if(title==null || content==null){
		w.println("<script>alert('입력이 안 된 상황이 있습니다.'); location.href='../write.jsp'; </script>");
	}else{
		PostingDB pdb= new PostingDB();
		pdb.write(title,userid,content);
		w.println("<script>alert('글쓰기 성공하였습니다.'); location.href='../Tab/NoticeBoard.jsp'; </script>");
	}
	
%>
</body>
</html>