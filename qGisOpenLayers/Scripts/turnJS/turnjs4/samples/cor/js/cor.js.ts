/*
class Greeter {
    greeting: string;
    constructor(message: string) {
        this.greeting = message;
    }
    greet() {
        return "Hello, " + this.greeting;
    }
}

let greeter = new Greeter("world");

let button = document.createElement('button');
button.textContent = "Say Hello";
button.onclick = function() {
    alert(greeter.greet());
}
*/
// document.body.appendChild(button);




interface size_t {
    width: any;
    height: any;
}


function outputResult()
{
	var size:size_t = { width: 756, height: 1070};
	var cssText = getDynamicPageStyle("sj-book", size);
	
	var cssTextNode = document.createTextNode(cssText);
	document.body.appendChild(cssTextNode);	
}


function getDynamicPageStyle(className:string, size:size_t):string
{
	var style = `
	#canvas
	{
		width: ` + (parseInt(size.width, 10)*2).toString() + "px" + `;
		height: ` + 1070 + `px;
		margin: 0px auto;
	}
	
	.` + className + `
	{
		width: ` + (parseInt(size.width, 10)*2).toString() + "px" + `;
		height: ` + parseInt(size.height, 10).toString() + "px" + `;
	}
	
	.` + className + `-viewport .` + className + `
	{
		width: ` + (parseInt(size.width, 10)*2).toString() + "px" + `;
		height: ` + parseInt(size.height, 10).toString() + "px" + `;
		width: -` + parseInt(size.width, 10).toString() + "px" + `;
		top: -` + parseInt((size.height/2.0).toString()).toString() + "px" + `;
	}
	
	.` + className + `-viewport .page
	{
		width: ` + parseInt(size.width, 10).toString() + "px" + `;
		height: ` + parseInt(size.height, 10).toString() + "px" + `;
		background-color: white;
		background-repeat: no-repeat;
		background-size: 100% 100%;
	}
	
	`;
	
	var rules:string[] = style.split('}');
	rules.pop();
	
	for (var i = 0; i < rules.length; ++i)
	{
		rules[i]= rules[i] + " } ";
	}
	
	return rules;
}


// outputResult();
