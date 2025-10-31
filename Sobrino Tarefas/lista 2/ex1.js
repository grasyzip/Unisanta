//a.
function senha (x, y) {
    return x === y;
}

console.log("a.");
console.log(senha("1234", "1234"));         // true
console.log(senha("Mauricio", "Asenjo"));   // false
console.log(" ");

//b.
function nota (p1, p2) {
    return p1 >= 0 && p1 <= 10&& p2 >= 0 && p2 <=10;
}

console.log("b.");
console.log(nota(5, 6.5));                      // true
console.log(nota(10, 10));                     // true
console.log(nota("Alo galera", "de cauboi")); // false
console.log(" ");

//c.
function tipos (z) {
    return typeof tipos;
}

console.log("c.");
console.log(tipos(21));                      // number
console.log(tipos("Mathias"));               // string
console.log(tipos(true));                    // bool
console.log(tipos(21 + "2"));
console.log(" ");

//d.
function conceito (media) {
    if (media >= 9) return "a";
    if (media >= 7.5) return "b";
    if (media >= 6.5) return "c";
    if (media >= 5) return "d";
    return "e";
}

console.log("d.");
console.log(conceito(9.5));
console.log(conceito(8));
console.log(conceito(7));
console.log(conceito(5));
console.log(conceito(2));
console.log(" ");

//e.
function reais (dolar,preco) {
    return dolar * preco;
}

console.log("e.");
console.log(reais(5.38, 150));                     // 807
console.log(reais(5.30, 300));                     // 1590
console.log(" ");

//f.
function maior(num1, num2, num3) {
    return Math.max(num1, num2, num3);

    /**
     * sem biblioteca:
     * if (a >= b && a >= c) {
     *     return a;
     * } else if (b >= a && b >= c) {
     *     return b;
     * } else {
     *     return c;
     * }
     * 
     * operador ternario:
     * (a>= b && a >= c) ? a : (b >= a && b >= c) ? a : c;
     * 
     * em cascata:
     * let maior = a;
     * if (b > maior) maior = b;
     * if (c > maior) maior = c;
     * return maior;
     * 
     */
}

console.log(maiorDeTres(10, 20, 30)); // 25
console.log(maiorDeTres(-1, 0, 1));   // 5

//