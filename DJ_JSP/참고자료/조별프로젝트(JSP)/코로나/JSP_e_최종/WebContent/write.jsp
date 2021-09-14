<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>게시글 작성</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<!-- style 적용 css 파일 생성했습니다 -->
<link rel="stylesheet" href="/JSP/css/Style.css"/>

</head>
<body>
<header>
	<% String ID= (String)session.getAttribute("ID");%>
	<%if(ID==null){ %>
<script>
swal("오류!","로그인을 해야 합니다.","error").then((value) => {
	(location.href="loginPage.jsp")
});
</script>
<%}else{ %>	
<nav class="navbar navbar-expand-sm">
  <!-- Brand -->
  	<a style="font-weight: bold;" class="navbar-brand" href="./Main.jsp">COVID-19</a>

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
        		<a class="dropdown-item" href="../login.jsp">로그인</a>
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
        	<a class="dropdown-item" href= "./check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
  <%
  	}
   %>
</nav>
	</header>
	<div class="container">
			<form method="get" action="./Action/writeAction.jsp">
				<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
					<thead>
						<tr>
							<th colspan="2" style="background-color:#9BDAF2; color:#0468BF text-align: center;" >게시글 작성하기</th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td><input type="text" class="form-control" placeholder="글 제목" name="title" maxlength="50"></td>
						</tr>
						<tr>
							<td id = "text">
							<textarea class="form-control" placeholder="글 내용" name="content" id ="content" style=" width:100%; resize: none;"></textarea>
							</td>
						</tr>
					</tbody>
				</table>
				<input type="submit" class="btn btn-info pull-right" value="작성완료">
			</form>
		</div>
	</div>
	<%} %>
</body>
<script type="text/javascript">
//텍스트영역의 스크롤바를 없애고 자동으로 늘려주는 역할
	$('#content').keydown(function(key){
		var txtArea = $('#content');
		if(key.keyCode == 13){
		if (txtArea) {
		    txtArea.each(function(){
		        $(this).height(this.scrollHeight);
		    });
		}
		}
	})
	
</script>

</html>