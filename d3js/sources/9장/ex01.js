var svgWidth = 320;
var svgHeight = 240;

var dataSet = [10,47,65,8,64,99,75,22,63,80];
var margin = svgWidth/(dataSet.length - 1);

var line = d3.svg.line()
    .x(function(d,i){
        return i* margin;
    })
    .y(function(d,i){
        return svgHeight - d;
    })

var lineElements = d3.select("#myGraph")
    .append("path")
    .attr("class","line")
    .attr("d",line(dataSet))