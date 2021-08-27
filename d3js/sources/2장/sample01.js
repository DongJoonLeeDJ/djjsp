
$(document).ready(function(){
// 막대그래프 데이터(데이터 세트)
var dataSet = [300, 130, 5, 60, 240];
// 데이터를 기반으로 그리기
d3.select("#myGraph")	// SVG 요소를 지정
	.append("rect")	// SVG 사각형 생성
	.attr("x", 0)	// 가로형 막대그래프이므로 X 좌표를 0으로 설정
	.attr("y", 0)	// Y 좌표를 0으로 설정
	.attr("width", dataSet[0])	// 최초 데이터를 기반으로 넓이 설정
	.attr("height", "20px")	// 막대그래프의 높이는 20px로 지정
});

