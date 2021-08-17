<%@page import="java.util.Locale"%>
<%@page import="com.mk.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
    
<jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session" />

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title>Product List</title>
</head>
<style>
	div.card{
		border-radius: 30px;
	}
	div.des-wrap{
		height: 85px;
	}
	div.jumbotron{
		background-color: white;
		background-image: url(./img/back1.jpg);
		background-position: center;
		background-repeat: no-repeat;
		background-size: cover;
		height: 250px;
	}
	.jumbo-text{
		color: white;
		text-shadow: 4px 4px 4px #000000;
	}
</style>
<body>
	<jsp:include page="menu.jsp"/>
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-3 jumbo-text">Product List</h1>
		</div>
	</div>
	
	<%
	ArrayList<Product> list = productDAO.getAllProduct();
	%>
	<div class="container">
		<div class="row" align="center">
			<%
			
			for(int i = 0; i < list.size(); i++){
				Product product = list.get(i);
				int price = product.getUnitPrice();
				String strPrice = "KR " + String.format(Locale.KOREAN, "%,d", price) + " ￦";
			%>
			<c:set var="price" value="<%=product.getUnitPrice() %>" />
			<div class="col-md-4">
				<%
				String imgSource = null;
				if(product.getPname().equals("iPhone12")){
					imgSource = "./img/iphone12.jpg";
				}
				else if(product.getPname().equals("2021 LG Gram17")){
					imgSource = "./img/gram17.jpg";
				}
				else if(product.getPname().equals("Samsung GalaxyTab S7")){
					imgSource = "./img/tabS7.jpg";
				}
				%>
				<div class="card" style="width: 18rem; height: 550px;">
					<div class="img-wrap">
						<img class="card-img-top" src=<%=imgSource %> alt="Card image cap" style="padding: 10px;">
					</div>
					<div class="card-body">
						<h5 class="card-title"><%=product.getPname() %></h5>
						<div class="des-wrap">
							<p class="card-text"><%=product.getDescription() %></p>
						</div>
						<a href="product_detail.jsp?id=<%=product.getProductId() %>" class="btn btn-secondary" role="button">Detail Info &raquo;</a>
					</div>
				</div>
			</div>
			<% } %>
		</div>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>