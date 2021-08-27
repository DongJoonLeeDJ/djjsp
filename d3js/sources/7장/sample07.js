var svgWidth = 320;
var svgHeight = 240;
var offsetX = 30;
var offsetY = 20;
var barElements;
var dataSet = [120,70,175,80,220,40,180,70,90];
var dataMax = 300;
var barWidth = 20;
var barMagin = 5;

barElements = d3.select("#myGraph")
            .selectAll("rect")
            .data(dataSet)

// 바 그리기
barElements.enter()
    .append("rect")
    .attr("class","bar")
    .attr({
        "x": function(d,i){ return offsetX + (barWidth + barMagin)*i; },
        "y": function(d,i) { return svgHeight-offsetY},
        "width": function(d,i){ return barWidth; },
        "height": function(d,i){ return 0;},
    })
    .transition()
    .duration(2500)
    .delay(function(d,i){
        return 100* i;
    })
    .attr({
        "x": function(d,i){ return offsetX + (barWidth + barMagin)*i; },
        "y": function(d,i) { return svgHeight - d - offsetY},
        "width": function(d,i){ return barWidth; },
        "height": function(d,i){ return d;},
    })

// 바 수치 표시하기
barElements.enter()
    .append("text")
    .attr("class","barNum")
    .attr({
        "x":function(d,i){ return i*(barMagin+barWidth)+offsetX+10},
        "y":svgHeight-5-offsetY
    })
    .text(function(d,i){return d;})

//눈금 스케일 지정
var yScale = d3.scale.linear()
                .domain([0,dataMax])
                .range([dataMax,0])

// 세로 방향의 눈금을 설정하고 표시
d3.select("#myGraph")
    .append("g")
    .attr("class","axis")
    .attr("transform","translate("+offsetX+","+(svgHeight-300-offsetY)+")")
    .call(
        d3.svg.axis()
        .scale(yScale)
        .orient("left")
    )
// 가로항뱡의 선을표시
d3.select("#myGraph")
  .append("rect")
  .attr("class","axis_x")
  .attr("width",svgWidth)
  .attr("height",1)
  .attr("transform","translate("+offsetX+","+(svgHeight-offsetY)+")")

barElements.enter()
        .append("text")
        .attr({
            "x":function(d,i){ return i * (barWidth+barMagin) + offsetX+5},
            "y": svgHeight-offsetY+15,
        })
        .text(function(d,i){return ["A","B","C","D","E","F","G","H","I","J","K","L"][i];})