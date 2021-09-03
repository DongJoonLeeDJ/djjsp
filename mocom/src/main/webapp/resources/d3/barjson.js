/**
 * 
 */
var dataSet = [];
var colormap = ["red","blue","yellow"];

d3.json('http://localhost:8282/mocom/selectmember',function(err,data){
	for(i=0; i<data.length; i++){
		dataSet.push(data[i].age*5);
		console.log(data[i].age*5);
	}
	d3.select("#myGraph1")
	.selectAll("rect")
	.data(dataSet)
	.enter()
	.append("rect")
	.attr("class", "bar")
	.style("fill",function(d,i){
		return colormap[i%3];
	})
	.attr("x", 10)
	.attr("y", function(d, i) {
		return i * 45 + 10;
	})
	.attr("width", function(d, i) {
		return d; 
	})
	.attr("height", 25)
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