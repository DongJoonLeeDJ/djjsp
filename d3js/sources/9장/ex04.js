var svgWidth = 320;
var svgHeight = 240;
var offsetX = 30;
var offsetY = 20;

var scale = 2.0;

var dataSet1 = [10,47,65,8,99,75,22,63,80];
var dataSet2 = [90,60,50,77,22,33,44,88,99];
var dataSet3 = [50,55,27,22,11,99,55,44,33];

var margin = svgWidth /(dataSet1.length -1);

drawGraph(dataSet1, "itemA","linear");
drawGraph(dataSet2, "itemB","basis");
drawGraph(dataSet3, "itemC","step");

drawScale();        //눈금표시

function drawGraph(dataSet,cssClassName,type){

    var line = d3.svg.line()
        .x(function(d,i){
            return offsetX + (i * margin);
        })
        .y(function(d,i){
            // 데이터로 부터 Y 좌표 빼기
            return svgHeight - (d * scale) - offsetY;
        })
        .interpolate(type)
        var lineElements = d3.select("#myGraph")
            .append("path")
            .attr("class","line "+cssClassName)
            .attr("d", line(dataSet))
}

function drawScale(){
    var yScale = d3.scale.linear()  //스케일 설정
                .domain([0,100])    // 원래크기
                .range([scale*100,0])   //실제 표시 크기

    d3.select("#myGraph")
      .append("g")
      .attr("class","axis")
      .attr("transform","translate("+offsetX+","+offsetY+")")
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
      .attr("transform","translate("+offsetX+","+(svgHeight- offsetY)+")")
}