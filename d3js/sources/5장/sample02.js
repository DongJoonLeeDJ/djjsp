d3.tsv("mydata.tsv",function(error,data){
    var dataSet = [];
    for(var i =0; i<data.length ;i++){
        dataSet.push(data[i].item1);
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
      d3.select("#testBtn").on("click",function(){
        dataSet.reverse();
        d3.selectAll("rect")
          .attr("width",function(d,i){
            return d;
          })
      });
});