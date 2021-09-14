<%@page import="Member.MemberInfo"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>상단 영역</title>
<%
String id = null;
if((MemberInfo)session.getAttribute("userinfo") != null){
	MemberInfo userinfo  = (MemberInfo)session.getAttribute("userinfo");
	id = userinfo.getUserid();
}
%>
<link href="CSS/styles.css" rel="stylesheet" />
   <script type="text/javascript">       
   	$('document').ready(function(){
   		$('#login').on('click',function(){
   			location.href='index.jsp?contentPage=Member/Login.jsp';
   		})
   		$('#signup').on('click',function(){
   			location.href='index.jsp?contentPage=Member/SignUp.jsp';
   		})
   		$('#Logout').on('click',function(){
   			location.href='index.jsp?contentPage=Member/Logout.jsp';
   		})
   		$('#change').on('click',function(){
   			location.href='index.jsp?contentPage=Member/Change_Info.jsp';
   		})
   		$('#board_notice').on('click',function(){
   			location.href='index.jsp?contentPage=Board/notice_main.jsp';
   		})
   		$('#freeboard').on('click',function(){
   			location.href='index.jsp?contentPage=Board/fb_main.jsp';
   		})
   	})
   </script>    
</head>
<body>
	<%
        String contentPage;
    %>
	<div id="wrap">
		<div class="container px-4 bg-dark py-3" style="margin:0px; max-width: 1903px;">
	        <div class="text-center text-white">
	            <h1 class="display-4 fw-bolder">전기차 커뮤니티</h1>
	            <p class="lead fw-normal text-white-50 mb-0">With clean & new EC</p>
	        </div>
        </div>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container px-4 px-lg-5">
	            <ul class="navbar-nav me-auto mb-2 mb-lg-0 ms-lg-4">
	                <li class="nav-item ms-lg-2"><a class="nav-link active" aria-current="page" href="index.jsp">Home</a></li>
	                <li class="nav-item ms-lg-2"><a class="nav-link" href="?contentPage=Map/Search_Map.jsp">충전소 검색</a></li>
	                <li class="nav-item dropdown ms-lg-2">
	                    <a class="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">보조금</a>
	                    <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
	                        <li><a class="dropdown-item" href="?contentPage=SupportMain.jsp">보조금 조회</a></li>
	                        <li><a class="dropdown-item" href="?contentPage=SubMain.jsp">문의처 조회</a></li>
	                    </ul>
	                </li>
	                <li class="nav-item dropdown ms-lg-2">
	                    <a class="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">게시판</a>
	                    <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
	                        <li id="board_notice"><a class="dropdown-item" href="#">공지사항</a></li>
	                        <li id="freeboard"><a class="dropdown-item" href="#">자유게시판</a></li>
	                    </ul>
	                </li>
	            </ul>
                <%if(id == null){ %>
                <form class="d-flex">
                    <button id="login" class="btn btn-outline-dark" type="button">
                        	로그인
                    </button>
                </form>
                <form class="d-flex">
                    <button id="signup" class="btn btn-outline-dark ms-lg-2" type="button">
                        	회원가입
                    </button>
                </form>
                <%}else { %>
              	<div>안녕하세요 <%=id %>님    </div>
                <form class="d-flex">
                    <button id="Logout" class="btn btn-outline-dark ms-lg-4" type="button">
                        	로그아웃
                    </button>
                </form>
                <form class="d-flex">
                    <button id="change" class="btn btn-outline-dark ms-lg-2" type="button">
                        	회원정보 수정
                    </button>
                </form>
                <%} %>                   
        	</div>
        </nav>
	</div>
</body>
</html>