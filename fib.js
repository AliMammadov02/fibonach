let a = 1, b = 1, i, n, reqem3;
let daxiledilen;
daxiledilen = prompt("reqem","bir eded daxil edin");
n = parseInt(daxiledilen);
console.log(a);
console.log(b); 
for(i = 2; i <= n; i++)
{
    reqem3 = a + b;
    console.log(reqem3);
    a = b;
    b = reqem3;


}