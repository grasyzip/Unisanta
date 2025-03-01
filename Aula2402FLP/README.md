explicação do código:

1. Declaração de variáveis: o código começa declarando as variáveis que serão usadas:
  - a, b e c: coeficientes da equação do segundo grau (ax² + bx + c = 0)
  - delta: discriminante da equação.
  - raiz, raiz1, raiz2: raízes da equação.

	*Entrada de dados no código 2:
		!double.TryParse(..., out a):

		usamos double.Parse() para converter as strings em números, se o usuário 
		digitar algo que não possa ser convertido em um número, o programa gera uma exceção.
		Para evitar, podemos usar o método double.TryParse(), que tenta converter a string 
		em um número e retorna um valor booleano indicando se a conversão foi bem-sucedida.

		!: Nega o resultado de double.TryParse(). 
		o loop continua enquanto double.TryParse() retornar false (ou seja, enquanto a entrada for inválida).

		o loop while continua solicitando a entrada do usuário até que um valor numérico válido seja fornecido.

		**Se a conversão for bem-sucedida, o valor convertido é armazenado na variável a (usando out a) e o método retorna true.
		**Se a conversão falhar, o método retorna false e a variável a não é modificada.


2. Cálculo do delta: o delta é calculado usando a fórmula delta = b^2 - 4 * a * c

3. Verificação do valor de delta: o código usa uma estrutura condicional if-else if-else para verificar o valor de delta:

if (delta < 0): Se delta for negativo, a equação não tem raízes reais.
else if (delta == 0): Se delta for igual a zero, a equação tem uma raiz real dupla.
else: Se delta for positivo, a equação tem duas raízes reais distintas.

4. Verificação das raízes:
  - if (delta < 0), a equação não tem raízes reais
  - else if (delta == 0), a equação tem duas raízes iguais (uma raiz real dupla) 
  - else [delta > 0], a equação tem duas raízes reais distintas

5. Cálculo das raízes: as raízes são calculadas usando as fórmulas:

  Raiz única (delta == 0): A raiz é calculada usando a fórmula:
  - raiz = -b / (2a).
  
  Duas raízes reais (delta > 0): As raízes são calculadas usando as fórmulas:
  - raiz1 = (-b + sqrt(delta)) / (2a)
  - raiz2 = (-b - sqrt(delta)) / (2a)

6. Saída de dados: o programa exibe as raízes da equação ou diz que não há raízes reais.

-------------------

*o programa exibirá as raízes da equação ou informará que não há raízes reais.
*o código não trata casos especiais como a = 0 (que não é uma equação do segundo grau).
