<%@page import="jsp.com.org.data.Vaccine"%>
<%@page import="jsp.com.org.data.VaccineDAO"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="java.io.PrintWriter" %>
<%@ page import="java.util.ArrayList" %>
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
<title>Covid-19 백신 예방 접종 센터</title>
<style>
nav{
		/*background-color:#DFEBF2;*/
		font-family: 'Black Han Sans', sans-serif;
	}
h1{
		font-family: 'Black Han Sans', sans-serif;
		font-weight: bold;
	}
h2{
		font-family: 'Black Han Sans', sans-serif;
		font-weight: bold;
	}
nav>a{
	color:#8878BF;
	font-weight: bold;
	}
nav>ul>li>a{
		color:#A3B5D9;
		font-weight: bold;
	}

nav>a:hover{color:#D8806C;}
nav>ul>li>a:hover{	color:#6CCED9;}
a{
		color:#435C73;
		font-weight: bold;
	}
	a:hover{color:#6CCED9;}
	.active {
    	color: #6CCED9;	
	}
a:hover{color:#6CCED9;}
table>thead>{background-color: #84A4BF;}
</style>
</head>
<body>
	<%
		// 메인 페이지로 이동했을 때 세션에 값이 담겨있는지 체크
		String userID = null;
		if(session.getAttribute("ID") != null){
			userID = (String)session.getAttribute("ID");
		}
		int pageNumber = 1; //기본은 1 페이지를 할당
		// 만약 파라미터로 넘어온 오브젝트 타입 'pageNumber'가 존재한다면
		// 'int'타입으로 캐스팅을 해주고 그 값을 'pageNumber'변수에 저장한다
		if(request.getParameter("pageNumber") != null){
			pageNumber = Integer.parseInt(request.getParameter("pageNumber"));
		}
	%>
<nav class="navbar navbar-expand-sm">
  <!-- Brand -->
  	<a class="navbar-brand" href="Main.jsp">COVID-19</a>

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
        	<a class="dropdown-item" href="./check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
  <%
  	}
   %>
  
</nav>
	<!-- 네비게이션 영역 끝 -->
	
	<!-- 게시판 메인 페이지 영역 시작 -->
	<div class="container mt-3">
	<h2 style="color: #F2B705">백신 예방 접종 센터</h2>
	<form method="get" action="vaccineInfo.jsp">
	<b>카테고리| 지역</b>
	<select name="addr">
		<option value="서울">서울</option>
		<option value="경기도">경기도</option>
		<option value="강원도">강원도</option>
		<option value="세종">세종</option>
		<option value="인천">인천</option>
		<option value="대전">대전</option>
		<option value="대구">대구</option>
		<option value="울산">울산</option>
		<option value="광주">광주</option>
		<option value="경상">경상도</option>
		<option value="전라">전라도</option>
		<option value="충청">충청도</option>
		<option value="제주">제주도</option>
		
	</select>
	<input class="btn btn-info ml-2" type="submit" value="선택">
	</form>
	<hr class="hr-style">
		<div class="row">
			<table class="table table-hover" style="text-align: center; border: 1px solid #dddddd">
				<thead>
					<tr style="background-color: #84A4BF; text-align: center;">
						<th>센터명</th>
						<th>시설명</th>
						<th>주소</th>
						<th>전화번호</th>
					</tr>
				</thead>
				<tbody>
					<%
						VaccineDAO vd = new VaccineDAO();
						String local = request.getParameter("addr");
						ArrayList<Vaccine> list= vd.select(local);
				
						for(int i=0; i< list.size();i++){ %>
					<tr>
						<td><%=list.get(i).getCenterName() %></td>
						<td><%=list.get(i).getFacility()%></td>
						<td><%=list.get(i).getAddr() %></td>
						<td><%=list.get(i).getTel() %></td>
					</tr>
					<%} %>
				</tbody>
			</table>
			
			<!-- 페이징 처리 영역 -->
		
			<!-- 글쓰기 버튼 생성 -->
			
		</div>
	</div>
	<!-- 게시판 메인 페이지 영역 끝 -->
	

</body>
</html>