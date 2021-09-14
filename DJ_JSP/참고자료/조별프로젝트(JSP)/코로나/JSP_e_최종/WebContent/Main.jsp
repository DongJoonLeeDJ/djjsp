<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@page import="oneday.com.org.Accumulate"%>
<%@page import="oneday.com.org.OneDay1" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>코로나19 현황</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="./css/Style.css"/>
<link rel="stylesheet" href="./css/StatusBoard.css" />



<script type="text/javascript">
	<%String ID = (String)session.getAttribute("ID");%>
	history.replaceState({}, null, location.pathname); //넘겨받은 파라메터를 숨기는 구문
</script>
</head>
<body>

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
    	if(ID == null ){
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
        	<a class="dropdown-item" href="./check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
  <%
  	}
   %>
</nav>
	<div class="img">
        <div class="content">
            <h1>Good Bye! COVID!</h1>
        </div>
        <div class="img-cover"></div>
    </div>
<div class="img_action2" style="margin-left: auto;margin-right:auto;">
	<div class="liveNumOuter ml-5 mr-5">
			<div class="liveNum_today_new">
				<strong class="tit">일일확진자</strong>
				<div class="datalist">
					<ul class = "mt-3">
						<li><span class="subtit">국내발생</span>
						<span class="data">
						<%OneDay1 day = new OneDay1();%>
						<%= day.OneDay1() %>
						</li>
						<li><span class="subtit">해외유입</span>
						<span class="data">
						<%= day.OneDay2() %>
						</span>
						</li>
					</ul>
				</div>
			</div>
			<div class="liveNum">
				<ul class="liveNum" style="padding:0px">
					<li><strong class="tit">확진환자</strong> 
					<span class="num">
					<span class="mini">(누적)</span>
					<%Accumulate ac1= new Accumulate();	ac1.Accumulate1();%>
					<%=ac1.Accumulate1()%></span>
					<span class="before">전일대비 
					<%=ac1.Accumulate5() %>
					</span></li>
					<li><em class="sign">=</em> <strong class="tit">격리해제</strong> <span class="num">
					<%=ac1.Accumulate2()%></span> <span class="before">
					<%=ac1.Accumulate6() %>
					</span></li>
					<li><em class="sign">+</em> <strong class="tit">치료 중<br>
						<span class="mini_tit">(격리 중)</span></strong> <span class="num">
					<%=ac1.Accumulate3() %></span>
						<span class="before">
					<%=ac1.Accumulate7() %>
					</span> </li>
					<li><em class="sign">+</em> <strong class="tit">사망</strong> <span class="num">
					<%=ac1.Accumulate4() %>
					</span> <span class="before">
					<%=ac1.Accumulate8() %>
					</span></li>
				</ul>
			</div>
	</div>
</div>

<div class="img_action" style="margin-left: 0px;">
	<img style="margin-left: auto; margin-right: auto; display: block;" alt="행동수칙" src="./res/행동수칙.jpg">
	</div>
</body>
</html>