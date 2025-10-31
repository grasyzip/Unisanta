//a.
function contaOcorrencias(arr, elemento) {
    let contador = 0;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === elemento) {
            contador++;
        }
    }
    return contador;
}

//b.
function alteraElemento(arr, elemento, novoValor) {
    let modificou = false;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === elemento) {
            arr[i] = novoValor;
            modificou = true;
        }
    }
    return modificou;
}

//c.
function incluiElemento(arr, elemento, posicao) {
    if (!elemento || typeof elemento !== 'string' || elemento.trim() === '') {
        return false;
    }
    
    if (posicao < 0 || posicao >= arr.length) {
        return false;
    }
    
    arr.splice(posicao, 0, elemento);
    return true;
}

//d.
function contaOcorrencias(arr, elemento) {
    let contadorExato = 0;
    let contadorSimilar = 0;
    const elementoLower = elemento.toLowerCase();
    
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === elemento) {
            contadorExato++;
        }
        
        if (arr[i].toLowerCase() === elementoLower) {
            contadorSimilar++;
        }
    }
    
    return {
        exatas: contadorExato,
        similares: contadorSimilar
    };
}

//e.
function contaOcorrencias(arr, elemento) {
    let contadorExato = 0;
    let contadorSimilar = 0;
    let contadorComposto = 0;
    
    const elementoLower = elemento.toLowerCase();
    const elementoPalavras = elementoLower.split(' ');
    
    for (let i = 0; i < arr.length; i++) {
        const itemLower = arr[i].toLowerCase();
        
        if (arr[i] === elemento) {
            contadorExato++;
        }
        
        if (itemLower === elementoLower) {
            contadorSimilar++;
        }
        
        const itemPalavras = itemLower.split(' ');
        
        let encontrouPalavra = false;
        for (let palavra of elementoPalavras) {
            if (palavra.length > 0 && itemPalavras.includes(palavra)) {
                encontrouPalavra = true;
                break;
            }
        }
        
        if (encontrouPalavra) {
            contadorComposto++;
        }
    }
    
    return {
        exatas: contadorExato,
        similares: contadorSimilar,
        compostos: contadorComposto
    };
}

// Array de exemplo
let nomes = ["Alexandre", "alexandre", "ALEXANDRE", "Carlos Alexandre", "Maria", "Alex"];

// Teste das funções
console.log("a) Ocorrências exatas de 'Alexandre':", contaOcorrencias(nomes, "Alexandre").exatas);

console.log("b) Alterando 'Alexandre' para 'Alexandre Sobrino':", 
    alteraElemento(nomes, "Alexandre", "Alexandre Sobrino"));
console.log("Array após alteração:", nomes);

console.log("c) Incluindo 'João' na posição 2:", 
    incluiElemento(nomes, "João", 2));
console.log("Array após inclusão:", nomes);

console.log("d) Contagem completa:");
let resultado = contaOcorrencias(nomes, "Alexandre");
console.log("Exatas:", resultado.exatas);
console.log("Similares:", resultado.similares);
console.log("Compostos:", resultado.compostos);