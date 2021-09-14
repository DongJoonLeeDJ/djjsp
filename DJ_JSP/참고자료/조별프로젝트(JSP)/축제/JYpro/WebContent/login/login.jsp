<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
	<link rel="stylesheet" href="../css/bootstrap.min.css">
	<link rel="stylesheet" href="../css/font-awesome.min.css">
	<link rel="stylesheet" href="../css/pe-icon-7-stroke.css">
	<link rel="stylesheet" href="../css/owl.carousel.css">
	<link rel="stylesheet" href="../css/magnific-popup.css">
	<link rel="stylesheet" href="../css/meanmenu.css">
	<link rel="stylesheet" href="../style.css">
	<link rel="stylesheet" href="../css/responsive.css">
	<script src="../js/vendor/modernizr-2.8.3.min.js"></script>

<script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
</head>
<style>
h1 {
	color: #e6dc30;
	font-weight: bold;
}

.loginbox {
	width: 400px;
	height: 500px;
	border: 1px solid gray;
	margin: 0 auto;
	text-align: center;
}

h5 {
	display: inline;
	text-align: center;
}

#loginbottom {
	width: 400px;
	height: 100px;
	margin: 0 auto;
	text-align: right;
	color: gray;
}

input {
	width: 200px;
	height: 20px;
}

#logo {
	text-decoration: none
}
</style>

<body>
<!-- header start -->
		<header>
			<div class="header-top-area black-bg hidden-xs">
				<div class="container">
					<div class="row">
						<div class="col-md-6 col-sm-6">
						</div>
						<div class="col-md-6 col-sm-6 hidden-xs">
							<div class="header-icon floatright">
								<a href="https://github.com/dhw1009/JspTeamproject"><i class="fa fa-github"></i></a>
							</div>							
						</div>
					</div>
				</div>
			</div>
			<!-- header end -->
			<!-- main-menu-area-start -->
			<div class="main-menu-area">
				<div class="container">
					<div class="row">
						<div class="col-md-3 col-sm-2">
							<div class="logo">
								<a href="../index.jsp"><img src="../img/logo/1.png" alt="" /></a>
							</div>
						</div>
						<div class="col-md-9 col-sm-10">
							<div class="main-menu floatright">
								<nav>
									<ul>
										<li class="active"><a href="../index.jsp">Home</a>
										</li>
										<li><a href="bbs.jsp">community</a></li>
										<li><a href="../team.jsp">team</a></li>
									</ul>
								</nav>
							</div>
							<div class="mobile-menu-area"></div>
						</div>
					</div>
				</div>
			</div>
			<!-- main-menu-area-end -->
		</header>
		<!-- header end -->
	<div class=loginbox>
		<a href="../index.jsp" id="logo"><h1>DaeGul</h1></a>
		<input type="text" placeholder="아이디" id="userID"> <br>
		<br> <input type="password" placeholder="비밀번호" id="userPassword">
		<br>
		
		<button id="login" onclick="login()">로그인</button>
		<button id="signin" onclick="signup()">회원가입</button>

	</div>
	<div id="loginbottom">
		<h5>도움말</h5>
		<h5>개인정보처리방침</h5>
		<h5>약관</h5>
	</div>

<script type="text/javascript">
window.onload=function(){
	login = function(){
		var id = document.getElementById('userID');
		var pwd=document.getElementById('userPassword');
		location.href='loginAction.jsp?userID='+id.value+'&userPassword='+pwd.value;
	}
	signup = function(){
		location.href='signin.jsp';
	}

}

</script>
</body>
</html>

