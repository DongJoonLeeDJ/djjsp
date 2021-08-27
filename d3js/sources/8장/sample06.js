var svgWidth = 320;
var svgHeight = 240;

var dataSet = [50,30,12,5,3];
var color = d3.scale.category10();
//원 그래프의 좌표값을 계산하는 메서드

var pie = d3.layout.pie()

var arc = d3.svg.arc().innerRadius(30).outerRadius(100)

var pieElements = d3.select("#myGraph")
    .selectAll("path")
    .data(pie(dataSet))

pieElements.enter()
    .append("path")
    .attr("class","pie")
    .attr("transform","translate("+svgWidth/2+","+svgHeight/2+")")
    .style("fill",function(d,i){
        return color(i);
    })
    .transition()
    .duration(200)
    .delay(function(d,i){
        return i*200;
    })
    .ease("linear")
    .attrTween("d",function(d,i){
        var interpolate = d3.interpolate(
        {startAngle:d.startAngle, endAngle:d.startAngle},
        {startAngle:d.startAngle, endAngle:d.endAngle}
        );
        return function(t){
            return arc(interpolate(t));
        }
    })

var textElements = d3.select("#myGraph")
    .append("text")
    .attr("class","total")
    .attr("transform","translate("+(svgWidth/2)+","+(svgHeight/2+5)+")")
    .text("합계" + d3.sum(dataSet));