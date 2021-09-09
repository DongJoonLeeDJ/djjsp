<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" href="/mocom/resources/board.css">
</head>
<body>
	<div id="root">
		<div>
			<div class="header">
				<h2>${title}</h2>
				<div>
					<ul>
						<li>메뉴</li>
						<li>메뉴</li>
						<li>메뉴</li>
					</ul>
				</div>
			</div>
			<div class="container">
				<div>
					<table>
						<thead>
							<tr><th>글번호</th><th>제목</th><th>작성날짜</th><th>작성자</th></tr>
						</thead>
						<tbody>
							<c:forEach items="${list}" var="dto">
								<tr>
									<td>${dto.idx}</td>
									<td>${dto.title}</td>
									<td>${dto.wdate}</td>
									<td>${dto.name}</td>
								</tr>
							</c:forEach>
						</tbody>
					</table>
				</div>
			</div>
			<div class="footer">
				copy right
			</div>
		</div>
	</div>
</body>
</html>