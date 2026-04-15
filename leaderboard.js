fetch("http://localhost:5000/score")
.then(res => res.json())
.then(data => console.log(data));
