/**
 * 
 */
var dataSet = [];

d3.csv('http://localhost:8282/mocom/resources/csv/mydata.csv',function(err,data){
	console.log(data.length);
	for(i=0; i<data.length; i= i+20){
		console.log("i = "+i);
		console.log("data[i].Weight = "+data[i].Weight);
	}
	d3.select("#myGraph1")
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
});


d3.select("#barbtn")
	.on("click", function() {
		d3.selectAll("rect")
			.transition()
			.duration(1000)
			.attr("width", function() {
				return (Math.random() * 300) + 1;
			})
	});