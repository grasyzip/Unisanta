"use strict";

//1)
let m = 0, n = 1, p = 2, o = 3;

const q = 3;
if (m == 0) {
    let n = 0;
    n = n + 3;

    const q = 5;

    console.log("a:", n);       // 3

    m += 2; 
    o = o + 4; 
    p = q;
}

console.log("b:", m);           // 2 m = 0 + 2
console.log("c:", n);           // 1 n = 1
console.log("d:", o);           // 7 o = 3 + 4
console.log("e:", p);           // 5 p = 3
console.log("f:", q);           // 3 q = 3

