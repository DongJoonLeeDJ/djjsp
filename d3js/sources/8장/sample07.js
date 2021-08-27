var svgWidth = 320;
var svgHeight = 240;

var dataSet = [50,30,12,5,3];
var color = d3.scale.category10();

var pie = d3.layout.pie()
            .value(function(d,i){ return d;})   //데이터셋의 데이터 반환

var arc = d3.svg.arc().innerRadius(30).outerRadius(100)

var pieElements = d3.select("#myGraph")
    .selectAll("g")
    .data(pie(dataSet))
    .enter()
    .append("g")
    .attr("transform","translate("+svgWidth/2+","+svgHeight/2+")")

pieElements.append("path")
        .attr("class","pie")
        .style("fill",function(d,i){
            return color(i)
        })
        .transition()
        .duration(200)
        .delay(function(d,i){
            return i*200;
        })
        .ease("linear")
        .attrTween("d",function(d,i){
            var interpolate = d3.interpolate(
                //각 부분의 시작각도
                    {startAngle:d.startAngle, endAngle:d.startAngle},
                //각 부분의 종료 각도
                    {startAngle:d.startAngle, endAngle:d.endAngle}
            );
            return function(t){
                return arc(interpolate(t));
            }
        })

var TextElements = d3.select("#myGraph")
        .append("text")
        .attr("class","total")
        //중심에 표시
        .attr("transform","translate("+svgWidth/2+","+svgHeight/2+")")
        .text("합계"+d3.sum(dataSet))

pieElements.append("text")
           .attr("class","pieNum")
           .attr("transform",function(d,i){
               return "translate("+arc.centroid(d)+")";
           })
           .text(function(d,i){
               return d.value;
           })
