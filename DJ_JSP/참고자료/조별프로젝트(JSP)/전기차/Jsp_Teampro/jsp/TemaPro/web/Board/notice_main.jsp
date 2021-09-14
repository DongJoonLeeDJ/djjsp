<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="board.Board"%>
<%@ page import="board.DML_Board"%>
<%@ page import="board.Board_Info"%>
<%@ page import="board.DML_BoardInfo"%>
<%@ page import="Member.MemberInfo"%>
<%@ page import="java.util.ArrayList"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<%
	// TODO 게시판 별 바뀌어야 할 정보
	// 100 = 공지사항, 200 = 자유게시판
	int BID = 100;
	
	DML_BoardInfo info = new DML_BoardInfo();
	Board_Info this_board = null;
	this_board = info.get_board_info(BID);
	String bcode = this_board.getBcode();
	String board_name_kor = this_board.getBname_kor();
	
	int pg;
	if (request.getParameter("pg") != null)
		pg = Integer.parseInt(request.getParameter("pg"));
	else
		pg = 1;
	
	int ROW_CNT = 10;
	DML_Board dml = new DML_Board();
	int pagination = dml.select_pageCount(BID, ROW_CNT);
	ArrayList<Board> list = null;
%>
<link href="CSS/styles.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<title><%=board_name_kor%></title>
</head>
<script src="js/board.js"></script>
<body>
	<!-- article_id | title | writer | timestamp(reg) -->
	<div class="container" style="margin-top:20px;">
	<h4>[공지사항]</h4>
		<div id="board_table" class="">
		<%
			MemberInfo user = (MemberInfo) session.getAttribute("userinfo");
		if (user != null) {
			if (user.getRid() == 0) {
		%>
		<div id="submit" class="" style="text-align:right; padding-bottom:10px;">
			<a href="index.jsp?contentPage=Board/article_write.jsp?bid=<%=BID%>">
			<input type="button" class="btn btn-info" value="글쓰기"></a>
		</div>
		<%
			}
		}
		%>
			<table class="table table-hover" style="text-align:center;">
				<thead class="thead-light">
					<tr>
						<th width="10%" scope="col">번호</th>
						<th width="*" scope="col">제목</th>
						<th width="10%" scope="col">글쓴이</th>
						<th width="20%" scope="col">작성일</th>
					</tr>
				</thead>
				<%
					/* 조건 */
				if (pagination > 0) {
					// 글 있음
					list = dml.select_all(BID, pg, ROW_CNT);// default page = 1
					for (Board b : list) {
				%>
				<tbody>
					<tr id="<%=b.getArticle_idx()%>"
						onclick="readArticle('<%=bcode%>', <%=b.getArticle_idx()%>)">
						<th scope="row"><%=b.getArticle_idx()%></th>
						<td><%=b.getTitle()%></td>
						<td><%=b.getUname()%></td>
						<td><%=b.getReg_date()%></td>
					</tr>
				</tbody>
				<%
					}
				} else {
				// 글 없음
				%>
				<tbody>
					<tr>
						<td colspan="4">No result</td>
					</tr>
				</tbody>
				<%
					}
				%>
			</table>
		</div>
		<div id="pagination" class="pagination">
			<%
				/* 조건 */
			if (pagination > 0) {
				for (int i = 0; i < pagination; i++) {
			%>
			<%
				// TODO 페이지네이션(pre, next)?
			%>
			<div class="container" style="text-align: center;">
				<a class="btn btn-outline-info" href="index.jsp?contentPage=Board/<%=bcode%>_main.jsp?pg=<%=(i + 1)%>"><%=(i + 1)%></a>
			</div>
			<%
				}
			}
			%>
		</div>
	</div>
</body>
</html>