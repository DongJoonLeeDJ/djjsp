<%@page import="java.util.Locale"%>
<%@page import="com.yjh.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<!-- 원화표시 라이브러리 사용 -->
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>

<%-- <jsp:useBean id="productDao" class="com.yjh.web.dao.ProductRepo"
	scope="session">
</jsp:useBean> --%>

<!-- 클래스 객체(com.yjh.web.dao.ProductRepo)가 id(객체생성 참조변수)로 생성됨 -->
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
				/* 자바에서 ￦원화 표시 처리, 선언 */
				String strPrice = String.format(Locale.KOREAN, "￦ %,d", price);
			%>
			<!-- jsp에서 ￦원화 표시 처리, 선언 -->
			<c:set var="price" value="<%=product.getUnitPrice() %>"/>
			<div class="col-md-4">
				<h3><%=product.getPname()%></h3>
				<p><%=product.getDescription()%></p>
				
				<!-- jsp에서 ￦원화 표시 처리, 사용 -->
				<p><fmt:setLocale value="ko_KR"/>
					<fmt:formatNumber type="currency" value="${price}"/>원
					
					<!-- 자바에서 ￦원화 표시 처리, 사용 -->
					<%-- <p><%=product.getUnitPrice()%>원 
						 <p><%=strPrice%>원 --%>
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