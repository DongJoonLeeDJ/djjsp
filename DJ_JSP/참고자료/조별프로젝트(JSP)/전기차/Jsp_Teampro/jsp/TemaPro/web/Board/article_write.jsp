<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%-- <%@ page import="user.Member_List"%> --%>
<%@ page import="Member.MemberInfo"%>
<%@ page import="board.Board_Info"%>
<%@ page import="board.DML_BoardInfo"%>
<!DOCTYPE html>
<html>
<head>
<style>
	.left{
		width:20%;
		float:left;
		text-align:right;
		font-size:20px;
		font-weight:bold;
	}
	.right{
		width:80%;
		float:right;
		text-align:left;
		padding-right:250px;
		padding-bottom:70px;
		padding-left:30px;
	}
</style>
<meta charset="UTF-8">
<%
	int BID = Integer.parseInt(request.getParameter("bid"));
	DML_BoardInfo info = new DML_BoardInfo();
	Board_Info this_board = null;
	this_board = info.get_board_info(BID);
	String bcode = this_board.getBcode();
	String board_name_kor = this_board.getBname_kor();
	
	MemberInfo user = (MemberInfo) session.getAttribute("userinfo");
%>
<title><%=board_name_kor%></title>
</head>
<body>
	<div class="container" style="padding-top:50px;">
		<!-- writer | title | content | timestamp(reg) -->
		<form name="form" id="form" role="form" method="post" action="Board/proc_write.jsp">
			<div class="mb-3" style="display: none;">
				<label for="bid">게시판 id</label> <input type="number"
					class="form-control" name="bid" id="bid" value="<%=BID%>"> <label
					for="mid">게시자 id</label> <input type="number" class="form-control"
					name="mid" id="mid" value="<%=user.getMid()%>">
			</div>
			<div class="left">
				<label for="title" style="margin-top:3px; margin-bottom:70px;">제목</label><br>
				<label for="content">내용</label>
			</div>
			<div class="right">
				<input type="text" class="form-control" name="title" id="title" placeholder="제목을 입력해 주세요" 
				style="margin-bottom:30px;">
				<textarea class="form-control" rows="5" name="content" id="content"
					placeholder="내용을 입력해 주세요"></textarea>
			</div>
			<div class="button_area" style="clear:both; padding-bottom:100px;">
				<input class="btn btn-dark" type="submit" value="작성완료" />
				<a class="" href="javascript:history.back();">
					<input class="btn btn-dark" type="button" value="뒤로가기" />
				</a>
			</div>
		</form>
	</div>
</body>
</html>