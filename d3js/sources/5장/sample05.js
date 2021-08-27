var dataSet = [];

d3.json("mydata.json",function(e,d){

    for(var i =0; i<d.length ; i++){
        dataSet.push(d[i].age);
    }

    d3.select("#myGraph")
      .selectAll("rect")
      .data(dataSet)
      .enter()
      .append("rect")
      .attr("class","bar")
      .attr("width",function(d,i){
          return d;
      })
      .attr("height",20)
      .attr("x",10)
      .attr("y",function(d,i){
          return i*25;
      })

})
    
d3.select("#testBtn").on("click", function () {
    dataSet.reverse();
    console.log("aaa" + dataSet);
    d3.selectAll("rect")
      .data(dataSet)
      .transition()
      .duration(1000)
      .attr("width", function (d, i) {
          return d;
      })
});