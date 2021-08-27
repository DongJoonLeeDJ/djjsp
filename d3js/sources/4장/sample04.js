// d3.select("#mybar")	// ID 이름 myGraph를 지정
//     .attr("x",10)
//     .attr("y",50)
//     .attr("width","200px")
//     .attr("height","30px")
//     .attr("fill","orange")

d3.select("#mybar")	// ID 이름 myGraph를 지정
    .attr(
        {
            x:50,
            y:10,
            width:150,
            height:200
        }
    )

d3.select("#mybar")
    .transition()
    .duration(2000)
    .attr({ x:10, y:100, width:200, height:10 })
    .style("fill","red")
    .style("stroke","blue")