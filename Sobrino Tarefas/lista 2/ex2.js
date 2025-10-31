function qualASaida(num1=0, num2=0, num3=true) {
 let exp=0;
    if (num3==true) {
        exp=num1+num2;
    } else {
        if (num1==num2) {
        exp=num1**2;
        } else if (num1>num2) {
            exp=num1-num2;
        } else { 
            exp=num2/2; 
        }
    }

    return exp;
}
qualASaida(3, 6, true); 
qualASaida(5, 1, false); 
qualASaida(2, 4, true); 
qualASaida(0, 5, true); 
qualASaida(false); 

/**
 * a: num3 = true = 3 + 6 = 9
 * b: num3 = false = 5 == 1 ? N = 5 > 1 ? S = 5 - 1 = 4
 * c: num3 = true = 2 + 4 = 6
 * d: num3 = true = 0 + 5 = 5
 * e: num1 = false, num2 = 0, num3 = true   // true == false ? N
 * num1 + num2 = num1 = false = 0, num2 = 0 = 0 + 0 = 0
 */