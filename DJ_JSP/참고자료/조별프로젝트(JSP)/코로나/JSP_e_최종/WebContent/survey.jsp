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
  <link rel="stylesheet" href="./css/Style.css"/>
<title>Covid-19 설문조사</title>
<script type="text/javascript">

    function oneCheckbox(a){
    	var obj = document.getElementsByName("question1");
        for(var i=0; i<obj.length; i++){
            if(obj[i] != a){
                obj[i].checked = false;
            }
        }
    }
    function oneCheckbox2(a){
    	var obj = document.getElementsByName("question2");
        for(var i=0; i<obj.length; i++){
            if(obj[i] != a){
                obj[i].checked = false;
            }
        }
    }

</script>
</head>
<body>
	<%
		String userID = null;
		if(session.getAttribute("ID")!=null){
			userID=(String)session.getAttribute("ID");
			
		}
		int pageNumber=1; //기본페이지
		if(request.getParameter("pageNumber")!=null){
			pageNumber=Integer.parseInt(request.getParameter("pageNumber"));
		}
	%>
	<nav class="navbar navbar-expand-sm">
  <!-- Brand -->

  	<a font-weight: bold;" class="navbar-brand" href="Main.jsp">COVID-19</a>

  <!-- Links -->
  		<ul class="navbar-nav">
  		<li class="nav-item">
      		<a class="nav-link" href="Main.jsp">메인</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="./Tab/graph.jsp">코로나 확진 현황</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="vaccineInfo.jsp">백신 예방 접종</a>
    	</li>
    	<li class="nav-item">
    		<a class="nav-link" href="./Tab/NoticeBoard.jsp">국민의 소리</a>
    	</li>
    	 <li class="nav-item">
      		<a class="nav-link" href="survey.jsp">설문조사</a>
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
        		<a class="dropdown-item" href="loginPage.jsp">로그인</a>
        		<a class="dropdown-item" href="memberInsert.jsp">회원가입</a>
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
        	<a class="dropdown-item" href="check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
  <%
  	}
   %>
</nav>

	<div class="container">
		<div class="jumbotron mt-5">
			<form method="post" action="./Action/surveyAction.jsp">
				<h3 Style="text-align: center;">코로나19로 바뀐 일상 요즘 어떻게 지내세요?</h3>
				<div class="form-group mt-5">
					<p>Q1. 코로나19 이후 제일 많은 시간을 보내는 활동은?</p>
					<input type="checkbox" name="question1" value="answer1" onclick="oneCheckbox(this)">영상시청(TV, 유튜브 등)<br> 
					<input type="checkbox" name="question1" value="answer2" onclick="oneCheckbox(this)">가족과 함께<br> 
					<input type="checkbox" name="question1" value="answer3" onclick="oneCheckbox(this)">독서<br> 
					<input type="checkbox" name="question1" value="answer4" onclick="oneCheckbox(this)">홈트레이닝<br> 
					<input type="checkbox" name="question1" value="answer5" onclick="oneCheckbox(this)">기타
				</div>
				<div class="form-group  mt-5">
					<p>Q2. 코로나19가 종식되면 가장 먼저 무엇을 하고 싶은가요?</p>
					<input type="checkbox" name="question2" value="answer1" onclick="oneCheckbox2(this)">국내여행<br> 
					<input type="checkbox" name="question2" value="answer2" onclick="oneCheckbox2(this)">국외여행<br> 
					<input type="checkbox" name="question2" value="answer3" onclick="oneCheckbox2(this)">지인모임<br> 
					<input type="checkbox" name="question2" value="answer4" onclick="oneCheckbox2(this)">영화, 공연 관람<br> 
					<input type="checkbox" name="question2" value="answer5" onclick="oneCheckbox2(this)">운동
				</div>
				<input type="submit" class="btn btn-primary form-control mt-5" value="제출">
			</form>
		</div>
	</div>
</body>
</html>