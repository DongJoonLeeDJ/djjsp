var svgWidth = 320;
var svgHeight = 240;

var dataSet = [50,30,12,5,3];
var color = d3.scale.category10();

var pie = d3.layout.pie()

var arc = d3.svg.arc().innerRadius(0).outerRadius(100)

var pieElements = d3.select("#myGraph")
    .selectAll("path")
    .data(pie(dataSet))

    pieElements.enter()
        .append("path")
        .attr("class","pie")
        //원 그래프 중심으로 함
        .attr("transform","translate("+svgWidth/2+","+svgHeight/2+")")
        .style("fill",function(d,i){
            return color(i)
        })
        .transition()
        .duration(1000)
        .delay(function(d,i){
            return i*1000;
        })
        .ease("linear")
        .attrTween("d",function(d,i){
            var interpolate = d3.interpolate(
                {startAngle : d.startAngle, endAngle:d.startAngle},
                {startAngle : d.startAngle, endAngle:d.endAngle}
            );
            return function(t){
                return arc(interpolate(t));
            }
        })