<%@page import="jsp.com.org.survey.SurveyDAO"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="../css/Style.css"/>
<title>Covid-19 설문조사</title>
</head>
<body>
	<%
		String userID = null;
		if(session.getAttribute("ID")!=null){
			userID=(String)session.getAttribute("ID");
		}
	%>
	<nav class="navbar navbar-expand-sm">
  <!-- Brand -->
  	<a font-weight: bold;" class="navbar-brand" href="../Main.jsp">COVID-19</a>
  <!-- Links -->
  	<ul class="navbar-nav">
  		<li class="nav-item">
      		<a class="nav-link" href="../Main.jsp">메인</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="../Tab/graph.jsp">코로나 확진 현황</a>
    	</li>
    	<li class="nav-item">
    		<a class="nav-link" href="../Tab/NoticeBoard.jsp">국민의 소리</a>
    	</li>
    	 <li class="nav-item">
      		<a class="nav-link" href="../survey.jsp">설문조사</a>
    	</li>
    </ul>
	<!-- 로그인 안될시에 보이는 화면 -->
    <%
    	if(userID == null ){
    %>
    <!-- Dropdown -->
    <ul class="navbar-nav navbar-right">
    	<li class="nav-item dropdown">
      		<a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">접속하기</a>
      		<div class="dropdown-menu">
        		<a class="dropdown-item" href="../loginPage.jsp">로그인</a>
        		<a class="dropdown-item" href="../memberInsert.jsp">회원가입</a>
      		</div>
    	</li>
  	</ul>
  <%
  	}else{
  %>
  <ul class="navbar-nav navbar-right">
  	<li class="nav-item dropdown">
    	<a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">회원관리</a>
      	<div class="dropdown-menu">
        	<a class="dropdown-item" href="../check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
  <%
  	}
   %>
  
</nav>
<%
	//String answer1 = (String)session.getAttribute("answer1");
	//String answer2 = (String)session.getAttribute("answer2");
	SurveyDAO sd = new SurveyDAO();
	double total= sd.allCount();
	double answer1= sd.result("answer1", "question1");
	double answer2= sd.result("answer2", "question1");
	double answer3= sd.result("answer3", "question1");
	double answer4= sd.result("answer4", "question1");
	double answer5= sd.result("answer5", "question1");
	double answer2_1= sd.result("answer1", "question2");
	double answer2_2= sd.result("answer2", "question2");
	double answer2_3= sd.result("answer3", "question2");
	double answer2_4= sd.result("answer4", "question2");
	double answer2_5= sd.result("answer5", "question2");
%>
<!-- <div class="cantainer-fluid"><img src="./res/main.jpg" class="mx-auto d-block"></div>-->
	<div class="img-2">
        <div class="content">
            <h1>코로나19로 바뀐 일상, 요즘 어떻게 지내세요?</h1>
        </div>
        <div class="img-cover"></div>
    </div>
	<div class="container">
	<p style="color:#5662A6; font-size:24px; font-weight: bold;">현재 응답: <%=sd.allCount()%>(명)</p>
		<div class="media border p-3 mt-3">
			<img src="../res/hobby2.jpg" alt="John Doe"
				class="mr-3 mt-3 rounded-circle" style="width: 200px;">
			<div class="media-body ml-5">
				<h4 style="color:#233A59;">
					Q <small><b>코로나19 이후 제일 많은 시간을 보내는 활동은 무엇인가요?</b></small>
				</h4>
				<br>
				<p style="color:#5662A6;"><b>영상시청(TV, 유튜브 등) <% double p1 = Math.round((answer1/ total) * 100); out.print(p1 + "%"); %></b></p>
				<p style="color:#4F698C;"><b>가족과 함께 <% double p2 = Math.round((answer2/ total) * 100); out.print(p2 + "%"); %></b></p>
				<p style="color:#5662A6;"><b>독서 <% double p3 = Math.round((answer3/ total) * 100); out.print(p3 + "%"); %></b></p>
				<p style="color:#4F698C;"><b>홈트레이닝 <% double p4 = Math.round((answer4/ total) * 100); out.print(p4 + "%"); %></b></p>
				<p style="color:#5662A6;"><b>기타 <% double p5 = Math.round((answer5/ total) * 100); out.print(p5 + "%"); %></b></p>
			</div>
		</div>
		<div class="media border p-3 mt-3">
			<div class="media-body ml-5">
				<h4 style="color:#233A59;">
					Q <small><b>코로나19가 종식되면 가장 먼저 무엇을 하고 싶은가요?</b></small>
				</h4>
				<br>
				<p style="color:#4F698C;"><b>국내 여행 <% double p6 = Math.round((answer2_1/ total) * 100); out.print(p6 + "%"); %></b></p>
				<p style="color:#5662A6;"><b>해외 여행 <% double p7 = Math.round((answer2_2/ total) * 100); out.print(p7 + "%"); %></b></p>
				<p style="color:#4F698C;"><b>지인 모임 <% double p8 = Math.round((answer2_3/ total) * 100); out.print(p8 + "%"); %></b></p>
				<p style="color:#5662A6;"><b>영화, 공연 관람 <% double p9 = Math.round((answer2_4/ total) * 100); out.print(p9 + "%"); %></b></p>
				<p style="color:#4F698C;"><b>운동 <% double p10 = Math.round((answer2_5/ total) * 100); out.print(p10 + "%"); %></b></p>
			</div>
			<img src="../res/daily.jpg" alt="John Doe"
				class="ml-3 mt-3 rounded-circle" style="width: 230px;">
		</div>
	</div>
	<footer>
		<div class= "container mt-5"></div>
	</footer>
</body>
</html>