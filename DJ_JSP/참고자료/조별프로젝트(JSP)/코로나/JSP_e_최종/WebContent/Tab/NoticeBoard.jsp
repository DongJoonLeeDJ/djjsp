<%@page import="jsp.com.org.Posting.Posting"%>
<%@page import="java.util.List"%>
<%@page import="java.util.ArrayList"%>
<%@page import="jsp.com.org.Posting.PostingDB"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>국민의 소리</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<!-- style 적용 css 파일 생성했습니다 -->
<link rel="stylesheet" href="/JSP/css/Style.css"/>
<%String ID = (String)session.getAttribute("ID");%>
  <%
    int num = 0;
    String PageNum;
    PageNum=request.getParameter("num");
    PostingDB PDB = new PostingDB();
    List<Posting> list;
    if(PageNum==null){
    list = PDB.select(num);
    }else{
    list = PDB.select_reload(Integer.parseInt(PageNum));
    }
    int Page = PDB.PageNum();
    %>
</head>
<body>
	<header>
<nav class="navbar navbar-expand-sm">
  <!-- Brand -->
  	<a font-weight: bold;" class="navbar-brand" href="../Main.jsp">COVID-19</a>

  <!-- Links -->
  	<ul class="navbar-nav">
  		<li class="nav-item">
      		<a class="nav-link" href="../Main.jsp">메인</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="graph.jsp">코로나 확진 현황</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="../vaccineInfo.jsp">백신 예방 접종</a>
    	</li>
    	<li class="nav-item">
    		<a class="nav-link" href="NoticeBoard.jsp">국민의 소리</a>
    	</li>
    	 <li class="nav-item">
      		<a class="nav-link" href="../survey.jsp">설문조사</a>
    	</li>
    </ul>
	<!-- 로그인 안될시에 보이는 화면 -->
    <%
    	if(ID == null ){
    %>
   			 <script>
			swal("오류!","로그인을 해야 합니다.","error").then((value) => {
				location.href="../loginPage.jsp"
			});
			</script>
    <!-- Dropdown -->
    <ul class="navbar-nav navbar-right">
    	<li class="nav-item dropdown">
      		<a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">접속하기</a>
      		<div class="dropdown-menu">
        		<a class="dropdown-item" href="../check/login.jsp">로그인</a>
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
	</header>
			
			<div class="container" id = "reload">
				<div class="row">
					<table class="table table-hover" style="margin-top:50px;">
						 <thead style="background-color:#6CCED9; color:#F2F2F2;">
      						<tr>
        						<th>번호</th>
        						<th>제목</th>
        						<th>작성자</th>
        						<th>작성일</th>
      						</tr>
    					</thead>
    					<tbody>
    					<%for(int i=0; i<list.size();i++){
    						Posting Pdata = list.get(i);%>
    						<tr id = "click" onclick="location.href='../BoardRead.jsp?num='+$(this).find('td:eq(0)').text().replace(/ /g, '');" style="cursor:pointer;">
    							<td style="cursor:pointer;">
    							<%out.print(Pdata.getNum());%></td>
    							
    							<td style="cursor:pointer;">
    							<%out.print(Pdata.getTitle());%></td>
    							
    							<td  style="cursor:pointer;">
    							<%out.print(Pdata.getUserid());%></td>
    							
    							<td style="cursor:pointer;">
    							<%out.print(Pdata.getDate());%></td>
    						</tr>
    						<%} %>
    					</tbody>
					</table>
					
					<%for(int i = 0; i<Page+1;i++){ %>
						
						<a class = "col-1" id = "PageNumber" onclick="location.href='NoticeBoard.jsp?num='+$(this).text().replace(/ /g, '');" style="cursor:pointer;"><%out.print(i+1);%></a>
						<%} %>
					
				</div>
				<div class="form-row float-right"><a href="../write.jsp" class="btn btn-primary pull-right" style="float: right;">글쓰기</a></div>
			</div>
			</div>
		    
</body>
</html>