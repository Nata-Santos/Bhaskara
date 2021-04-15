# Bhaskara
Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.

Uma equação do segundo grau é dada pela expressão abaixo:

![image](https://user-images.githubusercontent.com/78987318/114805184-e6dfe000-9d78-11eb-8126-de9f2b7ee226.png)

Assim, devemos receber do usuário os valores de a, b e c, e aplicar a fórmula de Bhaskara:

![image](https://user-images.githubusercontent.com/78987318/114805191-eba49400-9d78-11eb-90be-b7adb65673a8.png)

Dicas:

Precisamos validar se o valor de a não é zero, porque nesse caso a equação não é do segundo grau.
Calculamos o discriminante Δ (delta):

![image](https://user-images.githubusercontent.com/78987318/114805252-0840cc00-9d79-11eb-95d2-b1b3ca652e41.png)

Como a raiz quadrada de um número negativo não é um número real, precisamos validar se Δ não é negativo.

Depois, é só calcular e exibir as duas raízes:


![image](https://user-images.githubusercontent.com/78987318/114805263-0bd45300-9d79-11eb-80f1-c1775a087fe1.png)

![image](https://user-images.githubusercontent.com/78987318/114805308-24dd0400-9d79-11eb-9cc5-dc86b5c5e690.png)


Exemplo 1 (a == 0):

```
-- Equação do segundo grau --
(a): 0
(b): 2
(c): 5

Não é uma equação de segundo grau!
```

Exemplo 2 (Δ < 0):

```
-- Equação do segundo grau --
(a): 1
(b): 2
(c): 3

Como delta = -8,00, a equação não possui raízes reais!
```

Exemplo 3:

```
-- Equação do segundo grau --
(a): 1
(b): 2
(c): -3

x1 = 1,00 e x2 = -3,00
```
