<%@page import="java.util.Date"%>

<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<!-- <link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"> -->
<link rel="stylesheet" href="bootstrap4.css">
<title>Welcome</title>
</head>
<body>
	<%@ include file="menu.jsp"%>
	<%!String greeting = "전자관에 오신것을 환영합니다.";
	String tagLine = "Welcome to WEB Market";%>
	<div class="jumbotron2">
		<div class="container">
			<h1 class="display-32">
				<%=greeting%>
			</h1>
		</div>
	</div>



	<!-- digital_hongdae.jpg -->
	<div id="carouselExampleSlidesOnly" class="carousel slide"
		data-ride="carousel">
		<div class="carousel-inner">
			<div class="carousel-item active">
				<img class="d-block w-100" src="digital_hongdae.jpg"
					alt="First slide">
			</div>
		</div>
	</div>




	<div class="container">
		<div class="text-center">
			<br>
			<br>
			<h3><%=tagLine%></h3>
			<%
				Date day = new Date();
			String am_pm;
			int hour = day.getHours();
			int min = day.getMinutes();
			int sec = day.getSeconds();
			if (hour / 12 == 0) {
				am_pm = "AM";
			} else {
				am_pm = "PM";
				hour -= 12;
			}
			String nowTime = hour + " : " + min + " : " + sec + " " + am_pm;
			out.println("현재 접속 시각: " + nowTime + "\n");
			%>
		</div>
	</div>
	<%@ include file="footer.jsp"%>
</body>
</html>