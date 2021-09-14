<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.io.PrintWriter" %>
<%@ page import="bbs.BbsDAO" %>
<%@ page import="bbs.Bbs" %>
<%@ page import="java.util.ArrayList" %>
<!DOCTYPE html>
<html>
	<%
		int pageNumber = 1; //기본은 1 페이지를 할당
		// 만약 파라미터로 넘어온 오브젝트 타입 'pageNumber'가 존재한다면
		// 'int'타입으로 캐스팅을 해주고 그 값을 'pageNumber'변수에 저장한다
		if(request.getParameter("pageNumber") != null){
			pageNumber = Integer.parseInt(request.getParameter("pageNumber"));
		}
	%>
<head>
<meta charset="UTF-8">
<!-- 화면 최적화 -->
<meta name="viewport" content="width-device-width", initial-scale="1">
<!-- 루트 폴더에 부트스트랩을 참조하는 링크 -->
<link rel="stylesheet" href="../css/bootstrap.css">
<link rel="stylesheet" href="../css/bootstrap.min.css">
<link rel="stylesheet" href="../css/font-awesome.min.css">
<link rel="stylesheet" href="../css/pe-icon-7-stroke.css">
<link rel="stylesheet" href="../css/owl.carousel.css">
<link rel="stylesheet" href="../css/magnific-popup.css">
<link rel="stylesheet" href="../css/meanmenu.css">
<link rel="stylesheet" href="../style.css">
<link rel="stylesheet" href="../css/responsive.css">
<script src="../js/vendor/modernizr-2.8.3.min.js"></script>

<title>JSP 게시판 웹 사이트</title>
<style type="text/css">
	a, a:hover{
		color: #000000;
		text-decoration: none;
	}
</style>
</head>
<body>
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
									<a class="nav-link" href="../login/logoutAction.jsp">Log Out</a>
                        		<%}else{ %>
                                    <a href="../login/signin.jsp">Sign Up</a>
                        			<a href="../login/login.jsp">Log In</a>
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
	<!-- 게시판 메인 페이지 영역 시작 -->
	<div class="container">
		<div class="row">
			<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
				<thead>
					<tr>
						<th style="background-color: #eeeeee; text-align: center;">번호</th>
						<th style="background-color: #eeeeee; text-align: center;">제목</th>
						<th style="background-color: #eeeeee; text-align: center;">작성자</th>
						<th style="background-color: #eeeeee; text-align: center;">작성일</th>
					</tr>
				</thead>
				<tbody>
					<%
						BbsDAO bbsDAO = new BbsDAO(); // 인스턴스 생성
						ArrayList<Bbs> list = bbsDAO.getList(pageNumber);
						for(int i = 0; i < list.size(); i++){
					%>
					<tr>
						<td><%= list.get(i).getBbsID() %></td>
						<!-- 게시글 제목을 누르면 해당 글을 볼 수 있도록 링크를 걸어둔다 -->
						<td><a href="view.jsp?bbsID=<%= list.get(i).getBbsID() %>">
							<%= list.get(i).getBbsTitle() %></a></td>
						<td><%= list.get(i).getUserID() %></td>
						<td><%= list.get(i).getBbsDate().substring(0, 11) + list.get(i).getBbsDate().substring(11, 13) + "시"
							+ list.get(i).getBbsDate().substring(14, 16) + "분" %></td>
					</tr>
					<%
						}
					%>
				</tbody>
			</table>
			
			<!-- 페이징 처리 영역 -->
			<%
				if(pageNumber != 1){
			%>
				<a href="bbs.jsp?pageNumber=<%=pageNumber - 1 %>"
					class="btn btn-success btn-arraw-left">이전</a>
		
				<a href="bbs.jsp?pageNumber=<%=pageNumber + 1 %>"
					class="btn btn-success btn-arraw-left">다음</a>
			<%
				}
			%>
			
			<!-- 글쓰기 버튼 생성 -->
			<a href="write.jsp" class="btn btn-primary pull-right">글쓰기</a>
		</div>
	</div>
	<!-- 게시판 메인 페이지 영역 끝 -->
	
	<!-- 부트스트랩 참조 영역 -->
	<script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
	<script src="../js/bootstrap.js"></script>
</body>
</html>