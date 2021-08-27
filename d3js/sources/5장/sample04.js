var dataSet = [];

d3.csv("mydata.csv")
    .row(function (d) {
        return {
            나이: d["Age"],
            Weight: d["Weight"],
            Height: d["Height"],
        }
    })
    .get(function (error, data) {
        for (var i = 0; i < data.length; i++) {
            dataSet.push(data[i].나이);
        }
        d3.select("#myGraph")
            .selectAll("rect")
            .data(dataSet)
            .enter()
            .append("rect")
            .attr("class", "bar")
            .attr("width", function (d, i) {
                return d;
            })
            .attr("height", "20px")
            .attr("x", 0)
            .attr("y", function (d, i) {
                return i * 25;
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