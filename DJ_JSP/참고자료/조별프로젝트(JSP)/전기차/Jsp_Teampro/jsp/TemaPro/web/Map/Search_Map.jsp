<%@page import="java.io.PrintWriter"%>
<%@page import="Member.MemberInfo"%>
<%@page import="Map.MapInfo"%>
<%@page import="Map.MapDBManage"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%	
	String addr = request.getParameter("addr");
	String addr2 = request.getParameter("addr2");
	boolean check = false;
	if(addr2!=null){
		check = true;
	}	
	if (addr == null){
		addr = "서울특별시 중구 세종대로 110 (태평로1가)";
	}	
	MapDBManage map = new MapDBManage();
	ArrayList<MapInfo> list = map.SearchMap(addr);
%>
	
<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
	<link href="CSS/styles.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <meta charset="utf-8">
    <title>주소로 장소 표시하기</title>
<style>
	.search{
		width:25%;
		height:675px;
		float:left;
		overflow:scroll;
		text-align:center;
	}
	#map{
		width:75%;
		height:675px;
		float:right;
	}
	#addr2{
		font-size : 13px;
	}
</style>
</head>
 <script>
function search(){
	var addr = $('#addr').val();
	// alert(addr);
	location.href='?contentPage=Map/Search_Map.jsp&&addr='+addr;
}
function addrsearch(addr2){
	location.href='?contentPage=Map/Search_Map.jsp&&addr2='+addr2+'&&addr='+'<%=addr%>';
}
</script>
<body>
    <div class="search">
        <input class="col-8 mb-sm-2" type="text" name="addr" id="addr" class="form-control" placeholder="검색" />
		<button type='button' class="btn btn-outline-info btn-sm" onclick='search()'>주소 검색</button><br>
				<%for(int i = 0;i < list.size();i++){%>	
 				<%if(i >0 && list.get(i).getAddr().equals(list.get(i-1).getAddr()))
					continue;
				%>
					<span style="font-size:20px; color:#0000CD; font-weight:bold;"><%=list.get(i).getSpot()%></span>
					<button class="btn btn-info btn-sm" onclick ="addrsearch('<%=list.get(i).getAddr()%>')">이동</button>
					<div id="addr2"><%=list.get(i).getAddr()%></div>
					<div id="addr2"><%=list.get(i).getType()%></div>
					<hr style="border:#767474 1px dashed">
					
				<%}
				%>
    </div>
    <div id="map"></div>
    <script type="text/javascript"
        src="//dapi.kakao.com/v2/maps/sdk.js?appkey=7f2742810f51fd185f367e60d19d4d07&libraries=services"></script>
    <script>
        var mapContainer = document.getElementById('map'), // 지도를 표시할 div 
            mapOption = {
                center: new kakao.maps.LatLng(37.565577, 126.978082), // 지도의 중심좌표
                level: 3 // 지도의 확대 레벨
            };
        // 지도를 생성합니다    
        var map = new kakao.maps.Map(mapContainer, mapOption);
        // 주소-좌표 변환 객체를 생성합니다   
        var geocoder = new kakao.maps.services.Geocoder();
        // 주소로 좌표를 검색합니다
        <%
        if(check){
        	ArrayList<MapInfo> Search_Addr = map.SearchMap(addr2);
         %>
                geocoder.addressSearch('<%=Search_Addr.get(0).getAddr()%>', function (result, status) {
                    // 정상적으로 검색이 완료됐으면 
                    if (status === kakao.maps.services.Status.OK) {
                        var coords = new kakao.maps.LatLng(result[0].y, result[0].x);
                        // 결과값으로 받은 위치를 마커로 표시합니다
                        var imageSize = new kakao.maps.Size(35, 35);
                        var marker = new kakao.maps.Marker({
                            clickable: true,
                            map: map,
                            position: coords
                        });
                        var iwContent = "<p style='font-size :5px'><%=Search_Addr.get(0).getSpot()%></p>",
                            iwRemoveable = true; // 인포윈도우에 표출될 내용으로 HTML 문자열이나 document element가 가능합니다
                        var iwContent2 = "<p style='font-size :5px'><%=Search_Addr.get(0).getAddr()%></p>"
                        var iwContent3 = "<p style='font-size :5px'><%=Search_Addr.get(0).getType()%></p>"
                        // 인포윈도우를 생성합니다
                        var infowindow = new kakao.maps.InfoWindow({
                            content: iwContent + iwContent2 + iwContent3,
                            removable: iwRemoveable
                        });
                        kakao.maps.event.addListener(marker, 'click', function () {
                            // 마커 위에 인포윈도우를 표시합니다
                            infowindow.open(map, marker);
                        });
                        map.setCenter(coords);
                    }
                }); <%
            }%>
    </script>
</body>
</html>