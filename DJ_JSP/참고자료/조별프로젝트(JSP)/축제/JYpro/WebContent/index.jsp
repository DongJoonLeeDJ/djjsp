<!-- 박상준 -->
<%@ page import="example.Festival"%>
<%@ page import="java.util.ArrayList"%>
<%@ page import="example.Festival_DBManager"%>
<%-- <%@ page contentType = "text/html;charset=utf-8" %> --%>
<%@ page import="java.util.Calendar"%>

<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
    
<!-- 달력용 박상준-->
<%
Festival_DBManager fsdb=new Festival_DBManager();
ArrayList<Festival> list = fsdb.SelectAllFestival();
ArrayList<Festival> list2;
Calendar cal = Calendar.getInstance();

int nowYear = cal.get(Calendar.YEAR);
int nowMonth = cal.get(Calendar.MONTH) + 1;//0~11월까지라 +1

String fyear = request.getParameter("year");
String fmonth = request.getParameter("month");
// String selectedFestival_s = request.getParameter("festival");
// int selectedFestival=0;
int year = nowYear;
int month = nowMonth;

if (fyear != null) {
	year = Integer.parseInt(fyear);
}

if (fmonth != null) {
	month = Integer.parseInt(fmonth);
}

// if(selectedFestival_s!=null)
// {
// 	selectedFestival=Integer.parseInt(selectedFestival_s);
// }
cal.set(year, month - 1, 1);

year = cal.get(Calendar.YEAR);
month = cal.get(Calendar.MONTH) + 1;

int endDay = cal.getActualMaximum(Calendar.DAY_OF_MONTH);
int week = cal.get(Calendar.DAY_OF_WEEK);
if(month<10)
{
	list2 = fsdb.SelectFestivalByMonth(year+"-0"+month);
}
else
	list2 = fsdb.SelectFestivalByMonth(year+"-"+month);


//축제 일자만 나오는거 (""+fst.getFes_end()).substring(8, 10)

%>
<!-- 로그인용 -->
<%

%>
<!doctype html>
<html class="no-js" lang="zxx">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>2021 대구 축제 </title>
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
    	<link rel="stylesheet" type="text/css" href="css/styles.css"/>
    	<script type="text/javascript" src="d3/d3.js"></script>
    	<script	src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        	<style>
				table{
		    		border-spacing: 0px;
				}
        		td{
        			padding:0px;
            		width:120px;
            		height:120px;
        		}
    		</style>
		<!-- 박상준 달력 클릭하면 팝업-->
    	<script type="text/javascript">
		$('document').ready(function(){
			$("#myTable td").click(function(){
				var value = $(this).text();
				if(value>0){
					//년 월 일 넘겨줌
					popup=window.open("SelectedDay.jsp?day="+value+"&month="+<%=month%>+"&year="+<%=year%>, "ppu", "width=300, height=500, left=500, top=50");		    
				}
			});
		})
		</script>
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
<!-- 							<ul class="top-right"> -->
<!-- 								<li> -->
<!-- 									<i class="fa fa-envelope"></i> -->
<!-- 									<span id="userId">qkr03210@gmail.com</span> -->
<!-- 								</li> -->
<!-- 								<li> -->
<!-- 									<i class="fa fa-phone"></i> -->
<!-- 									<span>+82 10 9774 5263</span> -->
<!-- 								</li> -->
<!-- 							</ul> -->
						</div>
						<div class="col-md-6 col-sm-6 hidden-xs">
							<div class="header-icon floatright">
								<a href="https://github.com/dhw1009/JspTeamproject"><i class="fa fa-github"></i></a>
								<%
									Object id = (String) session.getAttribute("userID");
									if (id != null) {
								%>
									<a style="color:white;"><%=id%>님, 환영합니다!</a>
									<a class="nav-link" href="login/logoutAction.jsp">Log Out</a>
                        		<%}else{ %>
                                    <a href="./login/signin.jsp">Sign Up</a>
                        			<a href="./login/login.jsp">Log In</a>
                          		<%} %>
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
										<li class="active"><a href="index.jsp">Home</a>
										</li>
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
		<!-- slider-area-start -->
				<div class="slider-area">
			<div class="slider-active owl-carousel">
				<div class="single-slider ptb-150 bg-opacity" style="background-image:url(img/slider/2.jpg)">
					<div class="container">
						<div class="slider-text">
							<h1>신천음악버스킹<br>2021-07-06(화) ~ 14(수)</h1>
							<p>시간・공간・세대를 초월한 다양한 뮤직과 모든 문화장르를 아우른 버스킹 <br>  다양한 음악 장르를 아우른 버스킹, 아이스이벤트, 체험부스</p>
							<a class="active" href="festival.jsp?fes_name=신천 음악버스킹">바로 가기</a>
						</div>					
					</div>
				</div>
				<div class="single-slider ptb-150 bg-opacity" style="background-image:url(img/slider/3.jpg)">
					<div class="container">
						<div class="slider-text">
							<h1>대구국제바디페인팅페스티벌 <br>  2021-08-01(일) ~ 07(토)</h1>
							<p>세계 정상급 아티스트들이 보여주는 색채예술의 극치!
							<br>페인팅을 체험할 수 있는 다양한 체험 프로그램까지!</p>
							<a class="active" href="festival.jsp?fes_name=대구국제바디페인팅페스티벌">바로 가기</a>
						</div>					
					</div>
				</div>
				<div class="single-slider ptb-150 bg-opacity" style="background-image:url(img/slider/1.jpg)">
					<div class="container">
						<div class="slider-text">
							<h1>치맥 페스티벌 <br>  2021-07-01(목) ~ 09(금)</h1>
							<p>대한민국 치킨산업의 중심 대구! <br> </p>
							<a class="active" href="festival.jsp?fes_name=대구치맥페스티벌">바로 가기</a>
						</div>					
					</div>
				</div>
			</div>
		</div>
		<!-- slider-area-end -->
		<!-- What-wedo-area-start -->
		<div class="what-we-do-area pt-100 pb-70">
			<div class="container">
				<div class="row">
					<div class="col-md-offset-1 col-md-10">
						<div class="section-title text-center">
							<div align="center">
								<h2>축제 달력</h2>
								    <div>
        <a href = "index.jsp?year=<%=year %>&month=<%=month -1 %>">이전달</a>&nbsp;
        <b><%=year%>년&nbsp;&nbsp;<%=month%>월</b>
		<a href = "index.jsp?year=<%=year %>&month=<%=month +1 %>">&nbsp;다음달</a>
    </div>
    <div>
    	<%
    		int listCount=list2.size();
    		if(listCount>5)
    		{
    			listCount=5;
    		}
    	%>

    </div>
		<table border="1" id="myTable">
			<tr>
				<td style="color: red;">일</td>
				<td>월</td>
				<td>화</td>
				<td>수</td>
				<td>목</td>
				<td>금</td>
				<td style="color: blue">토</td>
			</tr>
			<tr>
				<%
				for (int i = 1; i < week; i++) {
				%>
				<td>&nbsp;</td>
				<%
				}
				%>
				<!-- 			끝나는 날까지 for문을 통해서 숫자를 출력한 것이다. week는 1일 제외하고 계산된다. -->
				<%
				for (int j = 1; j <= endDay; j++) {
					week++;
					if (week % 7 == 2) {
				%>
			</tr>
			<tr>
				<%
				}
				if (week % 7 == 2) {
				%>
				<td style="color: red" id="day<%=j%>"><%=j%></td>
				<%
				} else if (week % 7 == 1) {
				%>
				<td style="color: blue" id="day<%=j%>"><%=j%></td>
				<%
				} else {
				%>
				<td style="color: black" id="day<%=j%>"><%=j%></td>
				<%
				}

				}
				%>
			</tr>
		</table>
	</div>
  	<script type="text/javascript"> 
			function addBar(day) { 
		          // Enter
		   		<%for(int i =0;i<listCount;i++){%>
	            	d3.select(day) // <-
	                	.append("div") // <- F
	                      	.attr("class", "h-bar<%=i%>")
	                	.append("span"); // <- G
				<%}%>
			}
			
			<% for(int i =1;i<=endDay;i++){%>
				addBar("<%="#day"+i%>");
			<%}%>
			
			<%
			int start=0;
			int finish=0;
			
			if(list2.size()!=0)
			{
				int k;
				for( k= 0; k<listCount;k++){
					start=0;
					finish=0;
				
					Festival fst= list2.get(k);
					start=Integer.parseInt((""+fst.getFes_start()).substring(8, 10));	
					finish=Integer.parseInt((""+fst.getFes_end()).substring(8, 10));
					
					if(Integer.parseInt((""+fst.getFes_start()).substring(5, 7))!=month)
					{	//축제 시작일(day)이 끝나는날(day)보다 많으면 이전달임
						//FIXME 생각해보니 시작일 4/19 종료일 5/20이면 19~20으로 계산될듯 비교를 월로 해야할듯
						start=1;
					}
					if(Integer.parseInt((""+fst.getFes_end()).substring(5, 7))!=month)
					{
						finish=endDay;
					}
					String[] calColor=new String[5];
					calColor[0]="yellow";calColor[1]="orange";calColor[2]="red";calColor[3]="#c7ed9c";calColor[4]="#abf3ee";
					for(int i =start;i<=finish;i++){
						%>
						d3.select("<%="#day"+i%>")
							.select("div.<%="h-bar"+k%>")
								.style("background-color","<%=calColor[k]%>")
					<%
					}
				 }
			}%>
    </script> 
							</div>
						</div>				
					</div>
				</div>
				<div class="row">
					<table>

					</table>
				</div>
			</div>
		<!-- What-wedo-area-end -->

		<!-- footer start -->
		<footer>
			<div class="footer-bottom-area">
				<div class="container">
					<div class="social-icons text-center">
						<label>Find Us:</label>
						<a href="#"><i class="fa fa-facebook"></i></a>
						<a href="#"><i class="fa fa-twitter"></i></a>
						<a href="#"><i class="fa fa-github"></i></a>
						<a href="#"><i class="fa fa-linkedin"></i></a>
						<a href="#"><i class="fa fa-tumblr"></i></a>
						<a href="#"><i class="fa fa-flickr"></i></a>
						<a href="#"><i class="fa fa-github"></i></a>
						<a href="#"><i class="fa fa-ge"></i></a>
						<a href="#"><i class="fa fa-pinterest"></i></a>
						<a href="#"><i class="fa fa-amazon"></i></a>
						<a href="#"><i class="fa fa-codepen"></i></a>
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
    </body>
</html>
