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
</nav>

	<div class="img">
        <div class="content">
            <h1>Good Bye! COVID!</h1>
        </div>
        <div class="img-cover"></div>
    </div>
		<div class="container float-middle">
			<form class="col-6 mt-3" style="padding-left:70px" action="./check/login.jsp">
					<label for="ID">ID:</label>
					<input type="id" class="form-control" id="id" placeholder="아이디를 입력하세요" name="id">
					<label for="PWD">Password:</label> 
					<input type="password" class="form-control" id="pwd" placeholder="비밀번호를 입력하세요" name="pwd">
					<button type="button" class="btn mt-2" id = "member" style="padding-left:0px"><img src="./res/회원가입.JPG" width="30" height="30" class = "mr-2 img-thumbnail">회원가입</button>
					<button type="submit" class="btn btn-success mt-2" id ="login">로그인</button>
			</form>
		</div>
</body>
<script type="text/javascript">
$('#member').click(function(){
	location.href="memberInsert.jsp"
})

</script>
</html>
