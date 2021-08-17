<%@page import="java.util.Locale"%>
<%@page import="com.yjh.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%-- <jsp:useBean id="productDao" class="com.yjh.web.dao.ProductRepo"
	scope="session">
</jsp:useBean> --%>

<!-- 클래스 객체(com.yjh.web.dao.ProductRepo)가 id로 생성됨 객체생성 참조변수-->
<jsp:useBean id="productDao" class="com.yjh.web.dao.ProductRepo"
	scope="session" />

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">

<!-- <link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"> -->
<link rel="stylesheet" href="bootstrap4.css">
<title>제품 목록</title>
</head>
<body>
	<jsp:include page="menu.jsp" />
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-32">제품 리스트</h1>
		</div>
	</div>
	<%
		ArrayList<Product> list = productDao.getAllProduct();
	%>
	<div class="container">
		<div class="row" align="center">
			<%
				for (int i = 0; i < list.size(); i++) {
				Product product = list.get(i);

				/* 원 표시 */
				int price = product.getUnitPrice();
				String strPrice = String.format(Locale.KOREAN, "￦ %,d", price);
			%>
			<div class="col-md-4">
				<h3><%=product.getPname()%></h3>
				<p><%=product.getDescription()%>

					<!-- 원 표시 -->
					<%-- <p><%=product.getUnitPrice()%>원 --%>
				<p><%=strPrice%>원
				</p>

				<p>
					<a href="product_detail.jsp?id=<%=product.getProductId()%>"
						class="btn btn-secondary" role="button">상세정보 &raquo;</a>
			</div>
			<%
				}
			%>
		</div>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>