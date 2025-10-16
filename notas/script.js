// Aguarda o DOM carregar completamente
document.addEventListener('DOMContentLoaded', function() {
    // Adiciona event listeners
    document.getElementById('calcularBtn').addEventListener('click', calcularMedia);
    
    // Adiciona listener para tecla Enter em qualquer input
    const inputs = document.querySelectorAll('input');
    inputs.forEach(input => {
        input.addEventListener('keypress', function(event) {
            if (event.key === 'Enter') {
                calcularMedia();
            }
        });
    });
});

function calcularMedia() {
    // Obter os valores dos inputs
    const p1 = parseFloat(document.getElementById('p1').value);
    const p2 = parseFloat(document.getElementById('p2').value);
    const p3 = parseFloat(document.getElementById('p3').value);
    
    const resultDiv = document.getElementById('result');
    let resultado = '';
    let calculo = '';

    // Validar entradas obrigatórias
    if (isNaN(p1) || isNaN(p2) || p1 < 0 || p1 > 10 || p2 < 0 || p2 > 10) {
        alert('Por favor, insira valores válidos para P1 e P2 (0-10)');
        return;
    }

    // Primeiro cálculo: M = (P1 + P2 * 2) / 3
    const primeiraMedia = (p1 + (p2 * 2)) / 3;
    
    calculo += `
        <div class="calculation-step">
            <strong>Primeiro cálculo:</strong><br>
            M = (P1 + P2 × 2) ÷ 3<br>
            M = (${p1.toFixed(1)} + ${p2.toFixed(1)} × 2) ÷ 3<br>
            M = (${p1.toFixed(1)} + ${(p2 * 2).toFixed(1)}) ÷ 3<br>
            <strong>M = ${primeiraMedia.toFixed(1)}</strong>
        </div>
    `;

    // Verificar primeira condição
    if (primeiraMedia >= 5.0) {
        resultado = `🎉 <strong>APROVADO!</strong><br>Média final: ${primeiraMedia.toFixed(1)}`;
        resultDiv.className = 'result aprovado';
    } else {
        calculo += `
            <div class="calculation-step">
                <strong>Primeira média insuficiente (${primeiraMedia.toFixed(1)} < 5.0)</strong><br>
                Iniciando segundo cálculo com P3...
            </div>
        `;

        // Validar P3 para o segundo cálculo
        if (isNaN(p3) || p3 < 0 || p3 > 10) {
            alert('Para o segundo cálculo, é necessário inserir uma nota válida para P3 (0-10)');
            return;
        }

        // Determinar P (maior nota entre P1 e P2)
        const P = p1 > p2 ? p1 : p2;
        const menorNota = p1 > p2 ? p2 : p1;
        
        calculo += `
            <div class="calculation-step">
                <strong>Maior nota entre P1 e P2:</strong><br>
                P1 = ${p1.toFixed(1)}, P2 = ${p2.toFixed(1)}<br>
                Maior nota (P) = ${P.toFixed(1)}<br>
                Menor nota = ${menorNota.toFixed(1)}
            </div>
        `;

        // Segundo cálculo: M = (P + P3 * 2) / 3
        const segundaMedia = (P + (p3 * 2)) / 3;
        
        calculo += `
            <div class="calculation-step">
                <strong>Segundo cálculo:</strong><br>
                M = (P + P3 × 2) ÷ 3<br>
                M = (${P.toFixed(1)} + ${p3.toFixed(1)} × 2) ÷ 3<br>
                M = (${P.toFixed(1)} + ${(p3 * 2).toFixed(1)}) ÷ 3<br>
                <strong>M = ${segundaMedia.toFixed(1)}</strong>
            </div>
        `;

        // Verificar segunda condição
        if (segundaMedia >= 5.0) {
            resultado = '<strong>APROVADO!</strong><br>Média final: ${segundaMedia.toFixed(1)}';
            resultDiv.className = 'result aprovado';
        } else {
            resultado = `<strong>REPROVADO</strong><br>Média final: ${segundaMedia.toFixed(1)}`;
            resultDiv.className = 'result reprovado';
        }
    }

    // Exibir resultado
    resultDiv.innerHTML = resultado + calculo;
    resultDiv.style.display = 'block';
    
    // Rolar suavemente para o resultado
    resultDiv.scrollIntoView({ behavior: 'smooth', block: 'nearest' });
}

// Função para limpar os campos (pode ser útil adicionar um botão de limpar)
function limparCampos() {
    document.getElementById('p1').value = '';
    document.getElementById('p2').value = '';
    document.getElementById('p3').value = '';
    document.getElementById('result').style.display = 'none';
}