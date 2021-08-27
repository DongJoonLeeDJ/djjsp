var dataSet = [];
d3.csv("mydata.csv",function(error,data){
    for(var i =0; i<data.length ;i++){
        dataSet.push(data[i].Age);
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
      .attr("height","20px")
      .attr("x",0)
      .attr("y",function(d,i){
          return i *25;
      })
      
});
d3.select("#testBtn").on("click",function(){
  dataSet.reverse();
  d3.selectAll("rect")
    .data(dataSet)
    .attr("width",function(d,i){
      return d;
    })
});