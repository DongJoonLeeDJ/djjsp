<%@page import="jsp.com.org.Posting.CommentDB"%>
<%@page import="jsp.com.org.Posting.Comment"%>
<%@page import="jsp.com.org.Posting.PostingDelete"%>
<%@page import="jsp.com.org.Posting.PostingData"%>
<%@page import="java.util.List"%>
<%@page import="jsp.com.org.Posting.PostingRead"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
    <% PostingRead PRD = new PostingRead();
    	String num = (String)request.getParameter("num");
    	List<PostingData> content = PRD.Read(num);
    	CommentDB CDB = new CommentDB();
    	List<Comment> cmt =CDB.Read(num);
    %>
 <%String ID = (String)session.getAttribute("ID"); %>  
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<!-- style 적용 css 파일 생성했습니다 -->
<link rel="stylesheet" href="./css/Style.css"/>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<header>
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

  <ul class="navbar-nav navbar-right">
  	<li class="nav-item dropdown">
    	<a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">회원관리</a>
      	<div class="dropdown-menu">
        	<a class="dropdown-item" href="check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
</nav>
	</header>
	<div class="container">
	<%PostingData Pdata = content.get(0); %>
	<h2 style="color:#F2B705;"><%out.print(Pdata.getTitle());%></h2>
	<hr>
	<form action="./Action/UpdateContent.jsp">
				
				<input type = "hidden" value="<%=num%>" id = "num" name = "num">
				<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
      						<tr>
        						<td  style="background-color:#1AD9D9; color:#142273; text-align: center;">제목</td>
        						<td><%out.print(Pdata.getTitle());%></td>
        					</tr>
        					<tr>
        						<td  style="background-color:#B6ECF2; color:#142273; text-align: center;">작성일</td>
        						<td><%out.print(Pdata.getDate());%></td>
        					</tr>
        					<tr>
        						<td  style="background-color:#62CDD9; color:#142273; text-align: center;">작성자</td>
        						<td><%out.print(Pdata.getUserid());%></td>
      						</tr>
						<tr>
							<td  style="background-color:#B6ECF2; color:#142273; vertical-align : middle;">내용</td>
							<td><textarea id ="content" name = "content" style="width:100%; resize: none;" disabled="disabled"><%out.print(Pdata.getContent());%></textarea></td>
						</tr>
				</table>
						<div class="float-right mb-3">
						<%if(ID.equals(Pdata.getUserid())){%>
							<input type="button" class = "btn btn-warning" id = "update" value="수정">
							<button class = "btn btn-success" id = "submit" style="display:none">완료</button>
							<input type="button" class = "btn btn-danger" id = "delete" value="삭제">
						<%} %>
						</div>
				
		</form>
		
			<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
						<tr>
							<td  style="background-color:#B6ECF2; color:#142273; vertical-align : middle;">댓글</td>
							<td><textarea id ="Comment" name = "content" style="width:100%; resize: none;" placeholder="댓글을 여기에 입력하세요"></textarea></td>
						</tr>
			</table>
				<input type="button" value="등록" class="float-right mb-1" id="CommentBtn"></input>
			
			
			<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
      						<%for(int i=0;i<cmt.size();i++){ %>
      						<%Comment cmtdata = cmt.get(i); %>
      						<tr id="CommentTable" style="text-align:left;">
        						<td><%out.print(cmtdata.getID());%></td>
        						<td><%out.print(cmtdata.getContext());%>
        						<%if(cmtdata.getID().equals(ID)){ %>
        							<a type="button" onclick="CommentDelete($(this).attr('id'))" class="float-right text-danger" id="<%=cmtdata.getCommentNum()%>">삭제</a>
        						<%} %>
        						</td>
        						
        					</tr>
        					<%} %>
				</table>
			
		</div>
    					
</body>

<script type="text/javascript">
	//텍스트영역의 스크롤바를 없애고 자동으로 늘려주는 역할
	var txtArea = $('#content');
	   if (txtArea) {
	       txtArea.each(function(){
	           $(this).height(this.scrollHeight);
	       });
	   }
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
   
    //삭제버튼 이벤트
    $('#delete').click(function(){
		  location.href="./Action/DeleteContent.jsp?num="+<%=num%>
	});
    
    //수정버튼 이벤트
	     $('#update').click(function(){
    	 $("#content").removeAttr("disabled");
    	 $("#update").html('완료');
    	 $("#update").hide();
    	 $("#submit").attr("style","display:inline")
     }); 
	
    $('#CommentBtn').click(function(){
		var id = "<%=ID%>"
		var Comment = $('#Comment').val()
		var num = "<%=num%>"
		if(Comment!=null){
			$.ajax({
                url: './Action/Comment.jsp',
                type: 'GET',
                dataType: 'text',
                data: {
                	id:id,
                	num:num,
                	Comment:Comment
                	},
                success: function(ret) {
                    swal("댓글입력 성공!","","success").then((value) => {
                    	location.reload()
                	});
                },
                error: function(){
                	swal("통신실패", "다시실행해주세요", "error").then((value) => {
                		location.reload()
            		});
                }
    		})
		}
    })
   	
   function CommentDelete(CommentNum){
	    var num = "<%=num%>"
	    $.ajax({
            url: './Action/CommentDelete.jsp',
            type: 'POST',
            dataType: 'text',
            data: {
            	num:num,
            	CommentNum:CommentNum
            	},
            success: function(ret) {
            	swal("댓글삭제 성공!","","success").then((value) => {
            		location.reload()
        		});
            },
            error: function(){
            	swal("통신실패", "다시실행해주세요", "error").then((value) => {
            		location.reload()
        		});
            }
   		 })
  }
    
</script>
</html>

