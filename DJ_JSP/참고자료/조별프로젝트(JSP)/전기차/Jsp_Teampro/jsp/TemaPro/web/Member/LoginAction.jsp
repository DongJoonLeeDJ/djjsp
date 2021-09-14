<%@page import="Member.MemberInfo"%>
<%@page import="Member.MemberDBManage"%>
<%@page import="java.io.PrintWriter"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%
    	String id = request.getParameter("id");
    	String pw = request.getParameter("pw");
    	
		PrintWriter script = response.getWriter();
    	MemberDBManage mdb = new MemberDBManage();
    	MemberInfo mif = mdb.ckLogin(id,pw);
    	if(mif.getSuc()==1){
    		/*세션에 개인정보 저장  */
    		session.setAttribute("userinfo", mif);
    		script.println("<script>");
    		script.println("alert('로그인 성공.')");
    		script.println("location.href = '../index.jsp'");
    		script.println("</script>");
    	}
    	else if(mif.getSuc()==0){
    		out.print("비밀번호 틀림");
    		script.println("<script>");
    		script.println("alert('비밀번호가 틀립니다.')");
    		script.println("history.back()");
    		script.println("</script>");
    	}
    	else if(mif.getSuc()==-1){
    		out.print("없는 아이디");
    		script.println("<script>");
    		script.println("alert('존재하지 않는 아이디입니다.')");
    		script.println("history.back()");
    		script.println("window.close()");
    		script.println("</script>");
    	}
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
</body>
</html>