// 막대 그래프 데이터(데이터셋)
var dataSet = [300, 130, 5, 60, 240];
// 데이터를 기반으로 그리기
d3.select("#myGraph")				// SVG 요소 지정
	.selectAll("rect")					// SVG로 사각형을 표시할 요소를 지정
	.data(dataSet)						// 데이터 설정
	.enter()									// 데이터 수에 따라 rect 요소 생성
	.append("rect")						// SVG 사각형 생성
	.attr("x", 0)							// 가로형 막대그래프이므로 X좌표를 0으로 함
	.attr("y", function(d,i){			// Y 좌표를 배열의 순서에 따라 계산
		return i * 25;					// 막대그래프의 높이를 25px 단위로 계산
	})
	.attr("width", function(d, i){	// 넓이를 배열의 내용에 따라 계산
		return d +"px";					// 데이터의 값을 그대로 넓이로 함
	})
	.attr("height", "20px")			// 막대그래프의 높이를 20px로 지정

// 버튼 클릭 시의 처리
d3.select("#updateButton")
	.on("click", function(){
		dataSet = [20, 230, 150, 10, 20];		// 새로운 데이터로 변경
		d3.select("#myGraph")						// SVG 요소 지정
			.selectAll("rect")							// SVG로 사각형을 표시할 요소를 지정
			.data(dataSet)								// 데이터 설정
			.attr("width", function(d, i){			// 넓이를 배열의 내용에 따라 계산
				return d +"px";							// 데이터의 값을 그대로 넓이로 함
			})
})
