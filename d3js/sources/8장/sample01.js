var svgWidth = 320;
var svgHeight = 240;
var dataSet = [50,30,12,5,3];

//원 그래프의 좌표값을 계산하는 메서드
var pie = d3.layout.pie()   // 원 그래프 레이아웃
// 원 그래프의 안쪽 반지름, 바깥쪽 반지름 설정
var arc = d3.svg.arc().innerRadius(0).outerRadius(100);

var pieElements = d3.select("#myGraph")
                    .selectAll("path")
                    .data(pie(dataSet))
//데이터 추가
pieElements.enter()
    .append("path")
    .attr("class","pie")
    .attr("d",arc)
    .attr("transform","translate("+svgWidth/2+","+svgHeight/2+")")
                        
