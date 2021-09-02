/**
 * 
 */
var dataSet = [];

d3.select("#myGraph2")
	.selectAll("rect")
	.data(dataSet)
	.enter()
	.append("rect")
	.attr("class", "bar")
	.attr("x", 10)
	.attr("y", function(d, i) {
		return i * 45 + 10;
	})
	.attr("width", function(ele, i) { return ele; })
	.attr("height", 30)

d3.select("#piebtn")
	.on("click", function() {
		alert('동그라미그래프바뀌는거구현예정');
	});