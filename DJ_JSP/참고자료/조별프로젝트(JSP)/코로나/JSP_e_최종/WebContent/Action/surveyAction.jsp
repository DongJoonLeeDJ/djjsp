<%@page import="java.io.PrintWriter"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="jsp.com.org.survey.SurveyDAO" %>
<% request.setCharacterEncoding("UTF-8"); %>
<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="./css/Style.css"/>
  <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<title>Covid-19 Web 게시판</title>
</head>
<body>
	<%
		String userID = null;
		if(session.getAttribute("ID")!= null){
			userID= (String)session.getAttribute("ID");
		}
		String answer1 = (String)request.getParameter("question1");
		session.setAttribute("answer1", answer1);
		String answer2 = (String)request.getParameter("question2");
		session.setAttribute("answer2", answer2);
		
		if( answer1 == null || answer2 == null){
			System.out.print("입력안됨");
			PrintWriter script = response.getWriter();
			script.print("<script>alert('작성하지 않은 사항이 있습니다.')</script>");
			script.print("<script>location.href='../survey.jsp'");
			script.print("</script>");
		}else{
			SurveyDAO surveyDao = new SurveyDAO();
			String sql ="";
			int result=0;
			switch(answer1){
				case "answer1":
					sql="INSERT INTO `JSP`.`question1` (`answer1`) VALUES (?)";
					result = surveyDao.Submit(answer1, sql);
					break;
				case "answer2":
					sql="INSERT INTO `JSP`.`question1` (`answer2`) VALUES (?)";
					result = surveyDao.Submit(answer1, sql);
					break;
				case "answer3":
					sql="INSERT INTO `JSP`.`question1` (`answer3`) VALUES (?)";
					result = surveyDao.Submit(answer1, sql);
					break;
				case "answer4":
					sql="INSERT INTO `JSP`.`question1` (`answer4`) VALUES (?)";
					result = surveyDao.Submit(answer1, sql);
					break;
				case "answer5":
					sql="INSERT INTO `JSP`.`question1` (`answer5`) VALUES (?)";
					result = surveyDao.Submit(answer1, sql);
					break;
			}
			switch(answer2){
				case "answer1":
					sql="INSERT INTO `JSP`.`question2` (`answer1`) VALUES (?)";
					result = surveyDao.Submit(answer2, sql);
					break;
				case "answer2":
					sql="INSERT INTO `JSP`.`question2` (`answer2`) VALUES (?)";
					result = surveyDao.Submit(answer2, sql);
					break;
				case "answer3":
					sql="INSERT INTO `JSP`.`question2` (`answer3`) VALUES (?)";
					result = surveyDao.Submit(answer2, sql);
					break;
				case "answer4":
					sql="INSERT INTO `JSP`.`question2` (`answer4`) VALUES (?)";
					result = surveyDao.Submit(answer2, sql);
					break;
				case "answer5":
					sql="INSERT INTO `JSP`.`question2` (`answer5`) VALUES (?)";
					result = surveyDao.Submit(answer2, sql);
					break;
			}
			if(result == -1){
				PrintWriter scr = response.getWriter();
				scr.println("<script>alert('데이터베이스 오류.')");
				scr.println("history.back()");
				scr.println("</script>");
			}
			else{
				PrintWriter scr = response.getWriter();
				scr.println("<script>alert('소중한 의견 감사합니다.')");
				scr.println("location.href='../view/surveyView.jsp'");
				scr.println("</script>");
			}
		}
	%>

</body>
</html>