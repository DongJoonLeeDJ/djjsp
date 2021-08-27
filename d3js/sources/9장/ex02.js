var svgWidth = 320;
var svgHeight = 240;
var offsetX = 30;
var offsetY = 20;

var scale = 2.5;

var dataSet = [10,47,65,8,99,75,22,63,80];

var margin = svgWidth /(dataSet.length -1);

var line = d3.svg.line()
    .x(function(d,i){
        return offsetX + i*margin;
    })
    .y(function(d,i){
        return svgHeight - offsetY - (d*scale);
    })

var lineElements = d3.select("#myGraph")
    .append("path")
    .attr("class","line")       // CSS 클래스 지정
    .attr("d",line(dataSet));   // 연속선 지정

var yScale = d3.scale.linear() //scale 설정
    .domain([0,100])            // 원래크기
    .range([scale*100,0])       // 실제 표시 크기

d3.select("#myGraph")
    .append("g")
    .attr("class","axis")
    .attr("transform","translate("+offsetX+","+((100-(scale-1)*100)+offsetY)+")")
    .call(
        d3.svg.axis()
            .scale(yScale)
            .orient("left")
    )

d3.select("#myGraph")
  .append("rect")
  .attr("class","axis_x")
  .attr("width",svgWidth)
  .attr("height",1)
  .attr("transform","translate("+offsetX+","+(svgHeight-offsetY)+")");