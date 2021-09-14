<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="board.Board"%>
<%@ page import="board.Reply"%>
<%@ page import="java.util.ArrayList"%>
<%@ page import="Member.MemberInfo"%>
<%@ page import="board.DML_Board"%>
<%@ page import="user.DML_Member"%>
<%@ page import="board.Board_Info"%>
<%@ page import="board.DML_BoardInfo"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<%
	DML_BoardInfo info = new DML_BoardInfo();
	Board_Info this_board = null;
	
	MemberInfo user = (MemberInfo) session.getAttribute("userinfo");
	
	int article_idx = Integer.parseInt(request.getParameter("idx"));
	DML_Board dml = new DML_Board();
	DML_Member dml_user = new DML_Member();
	Board article = null;
	ArrayList<Reply> rp_list = null;
	rp_list = dml.show_rp(article_idx);
	article = dml.getArticle(article_idx);
	
	this_board = info.get_board_info(article.getBid());
	String bcode = this_board.getBcode();
	String board_name_kor = this_board.getBname_kor();
%>
<title><%=board_name_kor%></title>
<link href="CSS/styles.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<style>
	.tit_cont{
		padding : 0 0 15px 0;
		border-bottom : 1px solid #bcbcbc;
		border-top : 2px solid #1999d5;
	}
	.tit_cont h3{
		font-size : 26px;
		display : block;
		padding: 20px 40px;
		border-bottom : 1px solid #f2f2f2;
		text-align : left;
	}
	.tit_cont .info{
		font-size : 14px;
		display:block;
		text-align:right;
		padding:0 30px;
	}
	.tit_cont .info span{
		margin-right:10px;
	}
	.tit_cont .info em{
		margin-right : 20px;
		color:#666;
	}
	.view_cont{
		padding:20px;
		border-bottom : 1px solid #bcbcbc;
		line-height:24px;
		min-height:300px;
		text-align : left;
	}
	.reply_area{
		margin-top:10px;
		border-top : 2px solid #1999d5;
		padding-top:10px;
	}
	#reply_veiw td{
		padding: 3px 10px 3px 10px;
	}
</style>
</head>
<script src="js/board.js"></script>
<body class="">
	<!-- article_id | title | content | writer | timestamp(reg) -->
	<!-- article title: title -->
	<div id="board_body" class="container" style="margin-top:10px;">
		<div class="tit_cont">
			<h3><%=article.getTitle()%><br></h3>
			<div class="info">
				<span>글쓴이</span>
				<em><%=article.getUname()%></em>
				<span>등록일</span>
				<%
					if (article.getMod_date() != null) {
				%>
					<em><%=article.getMod_date()%></em>
				<%
					} else {
				%>
					<em><%=article.getReg_date()%></em>
				<%
					}
				%>
			</div>
		</div>
		<div class="view_cont">
			<%=article.getContent()%>
		</div>	
		<div class="btn_area" style="margin-top : 10px;">
			<a href="index.jsp?contentPage=Board/<%=bcode%>_main.jsp"><input
				class="btn btn-dark" type="button" value="목록가기" /></a>
			<%
				if (user != null) {
				int check = Integer.parseInt(user.getMid());
				if (check == article.getMid()) {
			%>
			<a href="index.jsp?contentPage=Board/article_update.jsp?idx=<%=article.getArticle_idx()%>">
			<input class="btn btn-dark" type="button" value="수정" /></a> 
			<input class="btn btn-dark" onclick="deleteArticle('<%=bcode%>', <%=article_idx%>)" type="button" value="삭제" />
			<%
				}
			}
			%>
		</div>
		<div class="reply_area">
			<%
				if (user != null) {
			// 				System.out.printf(user.getMid());
			%>
			<div id="reply_write_container">
				<textarea id="rp_context" class="form-control" rows="3" cols="50" style="resize:none; margin-bottom:5px;"
					placeholder="댓글 내용을 작성하세요. 댓글은 삭제할 수 없으니 신중하게 작성해주세요."></textarea>
				<input type="button" id="rp_btn" value="댓글 등록" class="btn btn-outline-secondary" style="display:inline-block;"
					onclick="writeReply('<%=bcode%>', <%=article_idx%>, <%=user.getMid()%>, 0)" />
			</div>
			<%
				}
			%>
			<div id="reply_view" class="container" style="margin-top:5px;">
				<!-- 댓글 뷰어 -->
				<table class="table">
					<%
						if (rp_list != null) {
						MemberInfo temp = null;
						for (Reply rp : rp_list) {
							temp = dml_user.getUser(rp.getMid());
					%>
					<tbody>
						<tr>
							<td width="10%" style="font-size:26px; padding:0 0 0 0;">↳</td>
							<td width="*" style="text-align:left; padding-left:10px;"><%=rp.getRp_context()%></td>
							<td width="20%" style="font-weight:bold; font-size:15px; text-align:right;"><%=temp.getUname()%></td>
							<td width="20%"><%=rp.getReg_date()%></td>
						</tr>
					</tbody>
					<%
						}
					}
					%>
				</table>
			</div>
		</div>
	</div>
</body>
</html>