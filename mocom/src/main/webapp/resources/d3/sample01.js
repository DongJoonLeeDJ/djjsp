var dataSet = [100, 10, 120, 200, 90];

d3.select("#myGraph")
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

d3.select("#testBtn")
	.on("click", function() {
		d3.selectAll("rect")
			.transition()
			.duration(1000)
			.attr("width", function() {
				return (Math.random() * 300) + 1;
			})
	});