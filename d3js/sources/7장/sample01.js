var svgheight=240;
var barElements;
var dataSet=[120,70,175,80,220];

barElements = d3.select("#myGraph")
    .selectAll("rect")
    .data(dataSet)

barElements.enter()
    .append("rect")
    .attr("class","bar")
    .attr("height",function(d,i){
        return d;
    })
    .attr("width",20)
    .attr("x",function(d,i){
        return i*25;
    })
    .attr("y",function(d,i){
        return svgheight -d;
    });