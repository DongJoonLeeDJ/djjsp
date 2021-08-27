// 데이터를 저장할 배열 준비
var dataSet = [ ];
// CSV 파일을 불러와 그래프 그리기
d3.csv("mydata.csv", function(error, data){
	for(var i=0; i<data.length; i++){	// 데이터 줄 수만큼 반복
		dataSet.push(data[i].item1);	// item1 레이블의 데이터만 추출
	}
	// 데이터를 이용하여 그래프 그리기
	d3.select("#myGraph")	// SVG 요소 지정
		.selectAll("rect")	// SVG에서 사각형을 나타낼 요소를 지정
		.data(dataSet)	// 데이터 설정
		.enter()	// 데이터 개수에 따라 Rect 요소 생성
		.append("rect")	// SVG 사각형 생성
		.attr("x", 10)	// 가로형 막대그래프이므로 X 좌표를 10으로 조정
		.attr("y", function(d,i){	// Y 좌표를 배열 순서에 따라 계산
			return i * 25;	// 막대그래프의 Y 좌표를 25px 단위로 계산
		})
		.on("click", function(){
			d3.select(this)	// 클릭한 요소를 지정
				.style("fill", "cyan")	// 채우기 스타일을 하늘색으로 지정
		})
		.attr("height", "20px")	// 막대그래프의 높이를 20px로 지정
		.attr("width", "0px")	// 처음에는 막대그래프의 넓이를 0px로 지정
		.transition()	// 그래프에 애니메이션 적용
		.delay(function(d, i){
			return i * 500;	// 0.5초마다 그리도록 대기 시간을 설정
		})
		.duration(2500)	// 2.5초 동안 애니메이션이 진행되도록 함
		.attr("width", function(d, i){	// 넓이를 배열의 내용에 따라 계산
			return d +"px";	// 데이터의 값을 그대로 넓이로 함
		})
	// 눈금을 표시하기 위한 선형 스케일 설정
	var xScale = d3.scale.linear()  // 선형 스케일 설정
		.domain([0, 300])   // 원래 데이터 범위
		.range([0, 300]);  // 실제 출력 크기
	// 눈금을 설정하고 표시함
	d3.select("#myGraph")
		.append("g")	// 그룹화함
		.attr("class", "axis")	// 스타일시트 클래스를 설정
		.attr("transform", "translate(10, "+((1+dataSet.length) * 20+5)+")")	// 표시 위치 조정
		.call(d3.svg.axis()	// call()로 눈금을 표시할 함수를 호출
			.scale(xScale)  // 스케일을 적용
			.orient("bottom")   // 눈금의 표시 위치를 아래쪽으로 지정
		)
});
// 버튼을 클릭했을 때의 처리
d3.select("#updateButton").on("click", function(){
	for(var i=0; i<dataSet.length; i++){
		dataSet[i] = Math.floor(Math.random() * 320);	// 0〜320미만의 값을 생성
	}
	d3.select("#myGraph")	// SVG 요소 지정
		.selectAll("rect")	// SVG에서 사각형을 나타낼 요소를 지정
		.data(dataSet)	// 데이터 설정
		.transition()	// 변환 표시
		.attr("width", function(d, i){	// 넓이를 배열의 내용에 따라 계산
			return d +"px";	// 데이터의 값을 그대로 넓이로 함
		})
})
