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
		imgSource = "./img/gram17.jpg";
	}
	else if(product.getPname().equals("2021 LG Gram17")){
		imgSource = "./img/gram17.jpg";
	}
	else if(product.getPname().equals("Samsung GalaxyTab S7")){
		imgSource = "./img/gram17.jpg";
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
	div.jumbotron{
		background-color: white;
		background-image: url(./img/iphone12.jpg);
		background-position: center;
		background-repeat: no-repeat;
  		filter: blur(2px);
		height: 250px;
	}
	
	div.jumbo-text{
		background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0, 0.1); /* Black w/opacity/see-through */
        color: white;
        text-align: center;
        font-weight: bold;
        border: 3px solid #f1f1f1;
        position: absolute;
	    top: 19%;
	    left: 50%;
	    transform: translate(-50%, -50%);
	    z-index: 2;
	    width: 80%;
	    padding: 20px;
	}
</style>

<body>
	<jsp:include page="menu.jsp" />
	<div class="jumbotron">
		
	</div>
	<div class="container jumbo-text">
		<h1 class="display-3"><%=product.getPname() %></h1>
	</div>
	<div class="container">
		<div class="row">
			<div class="col-md-5">
				<img alt="" src=<%=imgSource %> style="width: 100%">
			</div>
			<div class="col-md-6">
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