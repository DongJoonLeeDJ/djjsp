<%@page import="java.util.Locale"%>
<%@page import="com.mk.web.dto.Product"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session" />

<%
	String id = request.getParameter("id");
	Product product = productDAO.getProductById(id);
	int price = product.getUnitPrice();
	String strPrice = "KR " + String.format(Locale.KOREAN, "%,d", price) + " ￦";
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

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title><%=product.getPname() %> Details</title>
</head>
<style>
	.pro-info{
		margin-top:100px;
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
	<jsp:include page="menu.jsp" />
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-3 jumbo-text"><%=product.getPname() %></h1>
		</div>
	</div>
	<div class="container">
		<div class="row">
		<div class="col-md-5">
				<img alt="" src=<%=imgSource %> style="width: 100%">
			</div>
			<div class="col-md-6 pro-info">
				<p><%=product.getDescription() %>
				<p><b>Product Code : </b> <span class="badge badge-danger"><%=product.getProductId() %></span> 
				<p><b>Manufacturer : </b><%=product.getManufacturer() %> 
				<p><b>Category : </b><%=product.getCategory() %> 
				<p><b>Stock : </b><%=product.getUnitInStock() %> 
				<h4><%=strPrice %></h4>
				<hr>
				<p><a href="#" class="btn btn-info">Product Order &raquo;</a>
				   <a href="products_list.jsp" class="btn btn-secondary">Product List &raquo;</a>
			</div>
		</div>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>