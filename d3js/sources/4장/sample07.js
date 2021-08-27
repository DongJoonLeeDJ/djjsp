d3.selectAll(".mybar")	// ID 이름 myGraph를 지정
    .attr("style",function(d,i){
        // console.log("i = "+i)
        if(i%2==0){
            return "fill:red";
        }else{
            return "fill:blue";
        }
    })
    .transition()
    .duration(2500)
    .delay(function(d,i){
        return i*1000;
    })
    .attr({
        width:250,
        height:30
    })
    .style("fill","orange")
