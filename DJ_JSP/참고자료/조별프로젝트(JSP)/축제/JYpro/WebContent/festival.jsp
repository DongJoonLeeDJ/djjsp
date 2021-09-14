<!-- 박상준 -->
<%@ page import="example.Festival"%>
<%@ page import="java.util.ArrayList"%>
<%@ page import="example.Festival_DBManager"%>
<%-- <%@ page contentType = "text/html;charset=utf-8" %> --%>
<%@ page import="java.util.Calendar"%>

<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>

<%
request.setCharacterEncoding("UTF-8");
String fes_name = request.getParameter("fes_name");
Festival_DBManager fdbm = new Festival_DBManager();
Festival fest=fdbm.SelectFestivalByName(fes_name);
%>
<!doctype html>
<html class="no-js" lang="zxx">
<head>
<meta charset="utf-8">
<meta http-equiv="x-ua-compatible" content="ie=edge">
<title>2021 대구 축제</title>
<meta name="description" content="">
<meta name="viewport" content="width=device-width, initial-scale=1">

<link rel="apple-touch-icon" href="apple-touch-icon.png">
<!-- Place favicon.ico in the root directory -->

<!-- all css here -->
<link rel="stylesheet" href="css/bootstrap.min.css">
<link rel="stylesheet" href="css/font-awesome.min.css">
<link rel="stylesheet" href="css/pe-icon-7-stroke.css">
<link rel="stylesheet" href="css/owl.carousel.css">
<link rel="stylesheet" href="css/magnific-popup.css">
<link rel="stylesheet" href="css/meanmenu.css">
<link rel="stylesheet" href="style.css">
<link rel="stylesheet" href="css/responsive.css">
<script src="js/vendor/modernizr-2.8.3.min.js"></script>
<!-- 박상준 -->
<link rel="stylesheet" type="text/css" href="css/styles.css" />
<script type="text/javascript" src="d3/d3.js"></script>
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>



<style>
.map_wrap, .map_wrap * {
	margin: 0;
	padding: 0;
	font-family: 'Malgun Gothic', dotum, '돋움', sans-serif;
	font-size: 12px;
}

.map_wrap {
	width: 60%;
	height: 400px;
}

#category {
	position: relative;
	top: 10px;
	left: 10px;
	border-radius: 5px;
	border: 1px solid #909090;
	box-shadow: 0 1px 1px rgba(0, 0, 0, 0.4);
	background: #fff;
	overflow: hidden;
	z-index: 2;
}

#category li {
	float: left;
	list-style: none;
	width: 50px; px;
	border-right: 1px solid #acacac;
	padding: 6px 0;
	text-align: center;
	cursor: pointer;
}

#category li.on {
	background: #eee;
}

#category li:hover {
	background: #ffe6e6;
	border-left: 1px solid #acacac;
	margin-left: -1px;
}

#category li:last-child {
	margin-right: 0;
	border-right: 0;
}

#category li span {
	display: block;
	margin: 0 auto 3px;
	width: 27px;
	height: 28px;
}

#category li .category_bg {
	background:
		url(https://t1.daumcdn.net/localimg/localimages/07/mapapidoc/places_category.png)
		no-repeat;
}

#category li .bank {
	background-position: -10px 0;
}

#category li .mart {
	background-position: -10px -36px;
}

#category li .pharmacy {
	background-position: -10px -72px;
}

#category li .oil {
	background-position: -10px -108px;
}

#category li .cafe {
	background-position: -10px -144px;
}

#category li .store {
	background-position: -10px -180px;
}

#category li.on .category_bg {
	background-position-x: -46px;
}

.placeinfo_wrap {
	position: absolute;
	bottom: 28px;
	left: -150px;
	width: 300px;
}

.placeinfo {
	position: relative;
	width: 100%;
	border-radius: 6px;
	border: 1px solid #ccc;
	border-bottom: 2px solid #ddd;
	padding-bottom: 10px;
	background: #fff;
}

.placeinfo:nth-of-type(n) {
	border: 0;
	box-shadow: 0px 1px 2px #888;
}

.placeinfo_wrap .after {
	content: '';
	position: relative;
	margin-left: -12px;
	left: 50%;
	width: 22px;
	height: 12px;
	background:
		url('https://t1.daumcdn.net/localimg/localimages/07/mapapidoc/vertex_white.png')
}

.placeinfo a, .placeinfo a:hover, .placeinfo a:active {
	color: #fff;
	text-decoration: none;
}

.placeinfo a, .placeinfo span {
	display: block;
	text-overflow: ellipsis;
	overflow: hidden;
	white-space: nowrap;
}

.placeinfo span {
	margin: 5px 5px 0 5px;
	cursor: default;
	font-size: 13px;
}

.placeinfo .title {
	font-weight: bold;
	font-size: 14px;
	border-radius: 6px 6px 0 0;
	margin: -1px -1px 0 -1px;
	padding: 10px;
	color: #fff;
	background: #d95050;
	background: #d95050
		url(https://t1.daumcdn.net/localimg/localimages/07/mapapidoc/arrow_white.png)
		no-repeat right 14px center;
}

.placeinfo .tel {
	color: #0f7833;
}

.placeinfo .jibun {
	color: #999;
	font-size: 11px;
	margin-top: 0;
}

.main_container {
	width: 100%;
	height: 100%;
}

.main_title {
	width: 100%;
	height: 130px;
	background-color: green;
	float: left;
	border-bottom-width: thin;
	border-bottom-color: rgba(25, 80, 100, 0);
	border-bottom: solid;
}

.main_left_btn {
	width: 50%;
	height: 700px;
	background-color: red;
	float: left;
}

.main_right_btn {
	width: 50%;
	height: 280px;
	float: left;
}

.main_list {
	width: 100%;
	height: 150px;
}
</style>
<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script
	src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="css/mycss.css" />
</head>
<body>
	<!--[if lt IE 8]>
            <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->

	<!-- Add your site or application content here -->
	<!-- header start -->
	<header>
		<div class="header-top-area black-bg hidden-xs">
			<div class="container">
				<div class="row">
					<div class="col-md-6 col-sm-6">
					</div>
					<div class="col-md-6 col-sm-6 hidden-xs">
						<div class="header-icon floatright">
							<a href="https://github.com/dhw1009/JspTeamproject"><i
								class="fa fa-github"></i></a>
							<%
							Object id = (String) session.getAttribute("userID");
							if (id != null) {
							%>
							<a style="color: white;"><%=id%>님, 환영합니다!</a> <a class="nav-link"
								href="login/logout.jsp">Log Out</a>
							<%
							} else {
							%>
							<a href="./login/signin.jsp">Sign Up</a> <a
								href="./login/login.jsp">Log In</a>
							<%
							}
							%>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- header end -->
		<!-- main-menu-area-start -->
		<div class="main-menu-area">
			<div class="container">
				<div class="row">
					<div class="col-md-3 col-sm-2">
						<div class="logo">
							<a href="index.jsp"><img src="img/logo/1.png" alt="" /></a>
						</div>
					</div>
					<div class="col-md-9 col-sm-10">
						<div class="main-menu floatright">
							<nav>
								<ul>
									<li class="active"><a href="index.jsp">Home</a></li>
									<li><a href="bbs/bbs.jsp">community</a></li>
									<li><a href="team.jsp">team</a></li>
								</ul>
							</nav>
						</div>
						<div class="mobile-menu-area"></div>
					</div>
				</div>
			</div>
		</div>
		<!-- main-menu-area-end -->
	</header>
	<!-- header end -->
	<!-- What-wedo-area-start -->
	<div class="what-we-do-area pt-50 pb-70">
		<div class="container">
			<div class="row">
				<div class="col-md-offset-1 col-md-10">
					<div class="section-title text-center">
						<h1><%=fest.getFes_name()%></h1>
					</div>
					<div class="section-title text-center">
						<img style="border: 20px ridge wheat" src="img/festinfo/img<%=""+fest.getFes_idx()%>.jpg"
							alt="." >
					</div>
				</div>
			</div>
		</div>
		<div class="container">
			<div class="row">
				<div class="col-md-offset-1 col-md-10" style="height: 500px">
					<div class="section-title text-center">
						<div id="map2"
							style="width: 100%; height: 500px; overflow: hidden;"></div>
					</div>
				</div>
			</div>
		</div>
		<div class="container">
			<div class="row">
				<div class="col-md-offset-1 col-md-10">
					<div class="section-title text-center">
						<div>
							<ul id="category" style="width: 306px; position: relative; margin:0px auto;">
								<li id="BK9" data-order="0"><span class="category_bg bank"></span>은행</li>
								<li id="MT1" data-order="1"><span class="category_bg mart"></span>마트</li>
								<li id="PM9" data-order="2"><span class="category_bg pharmacy"></span>숙박</li>
								<li id="AD5" data-order="3"><span class="category_bg oil"></span>주유소</li>
								<li id="CE7" data-order="4"><span class="category_bg cafe"></span>카페</li>
								<li id="CS2" data-order="5"><span class="category_bg store"></span>편의점</li>
							</ul>
						</div>
					</div>
					<div  class="section-title text-center">
						<table style="margin:0px auto;">
						<tr>
							<td style="width:150px"><h2>축제 내용</h2></td>
							<td style="width:10px"></td>
							<td style="padding-bottom: 0px;    margin-bottom: 0px;"><h2><%=fest.getFes_content() %></h2></td>
						<tr>
						<tr>
							<td><h2>연락처</h2></td>
							<td></td>
							<td style="padding-bottom: 0px;    margin-bottom: 0px;"><h2><%=fest.getFes_tel()%></h2></td>
						</tr>
						<tr>
							<td><h2>홈페이지</h2></td>
							<td></td>
							<td style="padding-bottom: 0px;    margin-bottom: 0px;"><h2><%=fest.getFes_home()%></h2></td>
						</tr>
						<tr>
							<td><h2>주소</h2></td>
							<td></td>
							<td style="padding-bottom: 0px;    margin-bottom: 0px;"><h2><%=fest.getFes_addr()%></h2></td>
						</tr>
						</table>
					</div>
				</div>
			</div>
		</div>
		</div>
	<!-- What-wedo-area-end -->
	
	<!-- footer start -->
	<footer>
		<div class="footer-bottom-area">
			<div class="container">
				<div class="social-icons text-center">
					<label>Find Us:</label> <a href="#"><i class="fa fa-facebook"></i></a>
					<a href="#"><i class="fa fa-twitter"></i></a> <a href="#"><i
						class="fa fa-github"></i></a> <a href="#"><i
						class="fa fa-linkedin"></i></a> <a href="#"><i
						class="fa fa-tumblr"></i></a> <a href="#"><i class="fa fa-flickr"></i></a>
					<a href="#"><i class="fa fa-github"></i></a> <a href="#"><i
						class="fa fa-ge"></i></a> <a href="#"><i class="fa fa-pinterest"></i></a>
					<a href="#"><i class="fa fa-amazon"></i></a> <a href="#"><i
						class="fa fa-codepen"></i></a>
				</div>
				<div class="copyright text-center">
						<p>대굴대굴 - 축제 소개 페이지 - 2021 Made by</p>
						<a href="#">박상준,신용원,김두희</a>
				</div>
			</div>
		</div>
	</footer>
	<!-- footer end -->
	<!-- all js here -->
	<script src="js/vendor/jquery-1.12.0.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script src="js/owl.carousel.min.js"></script>
	<script src="js/jquery.meanmenu.js"></script>
	<script src="js/jquery.mixitup.min.js"></script>
	<script src="js/jquery.magnific-popup.min.js"></script>
	<script src="js/jquery.counterup.min.js"></script>
	<script src="js/waypoints.min.js"></script>
	<script src="js/plugins.js"></script>
	<script src="js/main.js"></script>

	<script type="text/javascript"
		src="//dapi.kakao.com/v2/maps/sdk.js?appkey=6aec230d2b24b46cf01eb03868da5536&libraries=services"></script>

	<script>
	var placeOverlay = new kakao.maps.CustomOverlay({zIndex:1}), 

    contentNode = document.createElement('div'), 
    markers = [], 
    currCategory = ''; 

		var mapContainer2 = document.getElementById('map2'), mapOption2 = {
			center : new kakao.maps.LatLng(
	<%=fest.getFes_x()%>
		,
	<%=fest.getFes_y()%>
		),
			draggable : false,
			level : 5
		};

		var map2 = new kakao.maps.Map(mapContainer2, mapOption2);

		var ps = new kakao.maps.services.Places(map2);

		kakao.maps.event.addListener(map2, 'idle', searchPlaces);

		contentNode.className = 'placeinfo_wrap';

		addEventHandle(contentNode, 'mousedown', kakao.maps.event.preventMap);
		addEventHandle(contentNode, 'touchstart', kakao.maps.event.preventMap);

		placeOverlay.setContent(contentNode);

		addCategoryClickEvent();

		function addEventHandle(target, type, callback) {
			if (target.addEventListener) {
				target.addEventListener(type, callback);
			} else {
				target.attachEvent('on' + type, callback);
			}
		}

		function searchPlaces() {
			if (!currCategory) {
				return;
			}

			placeOverlay.setMap(null);
			removeMarker();

			ps.categorySearch(currCategory, placesSearchCB, {
				useMapBounds : true
			});
		}

		function placesSearchCB(data, status, pagination) {
			if (status === kakao.maps.services.Status.OK) {
				displayPlaces(data);
			} else if (status === kakao.maps.services.Status.ZERO_RESULT) {

			} else if (status === kakao.maps.services.Status.ERROR) {

			}
		}

		function displayPlaces(places) {
			var order = document.getElementById(currCategory).getAttribute(
					'data-order');

			for (var i = 0; i < places.length; i++) {

				var marker = addMarker(new kakao.maps.LatLng(places[i].y,
						places[i].x), order);
				(function(marker, place) {
					kakao.maps.event.addListener(marker, 'click', function() {
						displayPlaceInfo(place);
					});
				})(marker, places[i]);
			}
		}

		function addMarker(position, order) {
			var imageSrc = 'https://t1.daumcdn.net/localimg/localimages/07/mapapidoc/places_category.png', imageSize = new kakao.maps.Size(
					27, 28), imgOptions = {
				spriteSize : new kakao.maps.Size(72, 208),
				spriteOrigin : new kakao.maps.Point(46, (order * 36)),
				offset : new kakao.maps.Point(11, 28)
			}, markerImage = new kakao.maps.MarkerImage(imageSrc, imageSize,
					imgOptions), marker = new kakao.maps.Marker({
				position : position,
				image : markerImage
			});

			marker.setMap(map2);
			markers.push(marker);

			return marker;
		}

		function removeMarker() {
			for (var i = 0; i < markers.length; i++) {
				markers[i].setMap(null);
			}
			markers = [];
		}

		function displayPlaceInfo(place) {
			var content = '<div class="placeinfo">'
					+ '   <a class="title" href="' + place.place_url + '" target="_blank" title="' + place.place_name + '">'
					+ place.place_name + '</a>';

			if (place.road_address_name) {
				content += '    <span title="' + place.road_address_name + '">'
						+ place.road_address_name
						+ '</span>'
						+ '  <span class="jibun" title="' + place.address_name + '">(지번 : '
						+ place.address_name + ')</span>';
			} else {
				content += '    <span title="' + place.address_name + '">'
						+ place.address_name + '</span>';
			}

			content += '    <span class="tel">' + place.phone + '</span>'
					+ '</div>' + '<div class="after"></div>';

			contentNode.innerHTML = content;
			placeOverlay.setPosition(new kakao.maps.LatLng(place.y, place.x));
			placeOverlay.setMap(map2);
		}

		function addCategoryClickEvent() {
			var category = document.getElementById('category'), children = category.children;

			for (var i = 0; i < children.length; i++) {
				children[i].onclick = onClickCategory;
			}
		}

		function onClickCategory() {
			var id = this.id, className = this.className;

			placeOverlay.setMap(null);

			if (className === 'on') {
				//     	alert(markers.length);
				currCategory = '';
				changeCategoryClass();
				removeMarker();
			} else {
				currCategory = id;
				changeCategoryClass(this);
				searchPlaces();
			}
		}

		function changeCategoryClass(el) {
			var category = document.getElementById('category'), children = category.children, i;

			for (i = 0; i < children.length; i++) {
				children[i].className = '';
			}

			if (el) {
				el.className = 'on';
			}
		}

		//마커가 표시될 위치입니다 
		var markerPosition = new kakao.maps.LatLng(
	<%=fest.getFes_x()%>,<%=fest.getFes_y() %>); 

//마커를 생성합니다
var mark = new kakao.maps.Marker({
position: markerPosition
});

mark.setMap(map2);


</script>
</body>
</html>
