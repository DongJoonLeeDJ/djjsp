<%@page import="java.util.Locale"%>
<%@page import="com.yjh.web.dto.Product"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<jsp:useBean id="productDao" class="com.yjh.web.dao.ProductRepo"
	scope="session" />
<link rel="stylesheet" href="bootstrap4.css">
<title>제품 상세 정보</title>
</head>
<body>
	<jsp:include page="./menu.jsp" />
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-32">제품 상세정보</h1>
		</div>
	</div>
	<%
	String id = request.getParameter("id");
	Product product = productDao.getProductById(id);
	
	/* 원 표시 */
	int price = product.getUnitPrice();
	String strPrice = String.format(Locale.KOREAN, "%,d", price);
	%>
	<div class="container">
		<div class="row">
			<div class="col-md-6">
			<h3> <%=product.getPname()%> </h3>
			<p><%=product.getDescription()%>
			<p><b>상품코드: </b><span class="badge badge-light2">
			<%=product.getProductId()%></span>
			<p><b>제조사</b> : <%=product.getManufacturer() %>
			<p><b>분류</b> : <%=product.getCategory() %>
			<p><b>재고 수량</b> : <%=product.getUnitInStock() %>
			
			<!-- 원 표시 -->
			<%-- <h4><%=product.getUnitPrice() %>원</h4> --%>
			<h4 class="price"><%=strPrice %>원</h4>
			<p><a href="#" class="btn btn-primary">상품 주문 &raquo;</a>
			<a href="./products.jsp" class="btn btn-secondary">
			제품 목록 &raquo;</a>
			</div>
		</div>
		<hr class="prod">
	</div>
<jsp:include page="./footer.jsp"/>
</body>
</html>