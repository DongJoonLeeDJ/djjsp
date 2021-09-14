<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
		<meta charset="UTF-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Smoth | Corporate HTML Template</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <link rel="apple-touch-icon" href="apple-touch-icon.png">
        <!-- Place favicon.ico in the root directory -->

        <!-- all css here -->
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <link rel="stylesheet" href="css/font-awesome.min.css">
        <link rel="stylesheet" href="css/pe-icon-7-stroke.css">
        <link rel="stylesheet" href="css/owl.carousel.css">
		<link rel="stylesheet" href="css/magnific-popup.css">
		<link rel="stylesheet" href="css/meanmenu.css">
        <link rel="stylesheet" href="style.css">
        <link rel="stylesheet" href="css/responsive.css">
        <script src="js/vendor/modernizr-2.8.3.min.js"></script>
</head>
    <body>
        <!--[if lt IE 8]>
            <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
		<!-- header start -->
		<header>
			<div class="header-top-area black-bg hidden-xs">
				<div class="container">
					<div class="row">
						<div class="col-md-6 col-sm-6">
<!-- 							<ul class="top-right"> -->
<!-- 								<li> -->
<!-- 									<i class="fa fa-envelope"></i> -->
<!-- 									<span id="userId">qkr03210@gmail.com</span> -->
<!-- 								</li> -->
<!-- 								<li> -->
<!-- 									<i class="fa fa-phone"></i> -->
<!-- 									<span>+82 10 9774 5263</span> -->
<!-- 								</li> -->
<!-- 							</ul> -->
						</div>
						<div class="col-md-6 col-sm-6 hidden-xs">
							<div class="header-icon floatright">
								<a href="https://github.com/dhw1009/JspTeamproject"><i class="fa fa-github"></i></a>
								<%
									Object id = (String) session.getAttribute("userID");
									if (id != null) {
								%>
									<a style="color:white;"><%=id%>님, 환영합니다!</a>
									<a class="nav-link" href="login/logout.jsp">Log Out</a>
                        		<%}else{ %>
                                    <a href="./login/signin.jsp">Sign Up</a>
                        			<a href="./login/login.jsp">Log In</a>
                          		<%} %>
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
								<a href="index.jsp"><img src="img/logo/1.png" alt="" /></a>
							</div>
						</div>
						<div class="col-md-9 col-sm-10">
							<div class="main-menu floatright">
								<nav>
									<ul>
										<li class="active"><a href="index.jsp">Home</a>
										</li>
										<li><a href="bbs/bbs.jsp">community</a></li>
										<li><a href="team.jsp">team</a></li>
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
		<!-- breadcrumb-area-start -->
		<div class="breadcrumb-area bg-color ptb-100">
			<div class="container">
				<div class="row">
					<div class="col-md-12">
						<div class="breadcrumb-title text-center">
							<h1>team</h1>
							<div class="breadcrumb-menu">
							<ul>
								<li><a href="index.jsp">home</a></li>
								<li>team</li>
							</ul>
						</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- breadcrumb-area-end --> 
		<!-- team-area-start -->
		<div class="team-area pt-100 pb-70">
			<div class="container">
				<div class="row">
					<!--공백 -->
					<div class="col-md-2 col-sm-2"></div>
					
					<div class="col-md-2 col-sm-2">
						<div class="single-team mb-30">
							<div class="team-item">
								<div class="team-img">
									<a href="#"><img src="img/team/1.jpg" alt="" /></a>
								</div>
								<div class="team-social">
									<a href="https://github.com/kimduhee7524"><i class="fa fa-github"></i></a>
								</div>
							</div>
							<div class="team-inner text-center">
								<h6>김두희</h6>
								<span>Programmer</span>
							</div>							
						</div>
					</div>
					<!--공백 -->
					<div class="col-md-1 col-sm-1"></div>
					
					<div class="col-md-2 col-sm-2">
						<div class="single-team mb-30">
							<div class="team-item">
								<div class="team-img">
									<a href="#"><img src="img/team/2.jpg" alt="" /></a>
								</div>
								<div class="team-social">
									<a href="https://github.com/qkr03210"><i class="fa fa-github"></i></a>
								</div>
							</div>
							<div class="team-inner text-center">
								<h6>박상준</h6>
								<span>Programmer</span>
							</div>							
						</div>
					</div>
					<!--공백 -->
					<div class="col-md-1 col-sm-1"></div>
					<div class="col-md-2 col-sm-2">
						<div class="single-team mb-30">
							<div class="team-item">
								<div class="team-img">
									<a href="#"><img src="img/team/3.PNG" alt="" /></a>
								</div>
								<div class="team-social">
									<a href="https://github.com/sinyong1"><i class="fa fa-github"></i></a>
								</div>
							</div>
							<div class="team-inner text-center">
								<h6>신용원</h6>
								<span>Programmer</span>
							</div>							
						</div>
					</div>
					<!--공백 -->
					<div class="col-md-1 col-sm-1"></div>
				</div>	
			</div>
		</div>
		<!-- testimonial-area-start -->
		<div class="testimonial-area ptb-80 gray-bg">
			<div class="container">
				<div class="row">
					<div class="col-md-offset-3 col-md-6">
						<div class="section-title text-center">
							<h2>개발 후기</h2>
						</div>					
					</div>
					<div class="col-md-8 col-md-offset-2">
						<div class="testimonial-active owl-carousel">
							<div class="testimonial-wrapper">
								<div class="testimonial-img text-center">
									<img src="img/testimonial/1_60.jpg" alt="" />
								</div>
								<div class="testimonial-info text-center">
									<p>회원가입 페이지에서 중복체크 비밀번호 확인등 여러가지 기능들을 활용하여 편리하게 가입할 수 있도록 만들었다.</p>
									<span>김두희</span>
								</div>
							</div>
							<div class="testimonial-wrapper">
								<div class="testimonial-img text-center">
									<img src="img/testimonial/2_60.jpg" alt="" />
								</div>
								<div class="testimonial-info text-center">
									<p>이번 프로젝트를 진행하면서 jsp 화면간 값의 전달과 화면의 이동에 대해 많은 공부를 할수있었습니다.</p>
									<span>박상준</span>
								</div>
							</div>
							<div class="testimonial-wrapper">
								<div class="testimonial-img text-center">
									<img src="img/testimonial/3_60.PNG" alt="" />
								</div>
								<div class="testimonial-info text-center">
									<p>공공데이터를 활용하여</p>
									<span>신용원</span>
								</div>
							</div>
						</div> 
					</div>
				</div>
			</div>
		</div>
		<!-- testimonial-area-end -->		
		<!-- footer start -->
		<footer>
			<div class="footer-bottom-area">
				<div class="container">
					<div class="social-icons text-center">
						<label>Find Us:</label>
						<a href="#"><i class="fa fa-facebook"></i></a>
						<a href="#"><i class="fa fa-twitter"></i></a>
						<a href="#"><i class="fa fa-github"></i></a>
						<a href="#"><i class="fa fa-linkedin"></i></a>
						<a href="#"><i class="fa fa-tumblr"></i></a>
						<a href="#"><i class="fa fa-flickr"></i></a>
						<a href="#"><i class="fa fa-github"></i></a>
						<a href="#"><i class="fa fa-ge"></i></a>
						<a href="#"><i class="fa fa-pinterest"></i></a>
						<a href="#"><i class="fa fa-amazon"></i></a>
						<a href="#"><i class="fa fa-codepen"></i></a>
					</div>
					<div class="copyright text-center">
						<p>대굴대굴 - 축제 소개 페이지 - 2021 Made by</p>
						<a href="#">박상준,신용원,김두희</a>
					</div>
				</div>
			</div>
		</footer>
		<!-- footer end -->
		<!-- all js here -->
        <script src="js/vendor/jquery-1.12.0.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/owl.carousel.min.js"></script>
        <script src="js/jquery.meanmenu.js"></script>
        <script src="js/jquery.mixitup.min.js"></script>
        <script src="js/jquery.magnific-popup.min.js"></script>
        <script src="js/jquery.counterup.min.js"></script>
        <script src="js/waypoints.min.js"></script>
        <script src="js/plugins.js"></script>
        <script src="js/main.js"></script>
    </body>
</html>