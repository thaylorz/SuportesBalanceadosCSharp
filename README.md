## **Desafio: Verificar se uma string de colchetes é válida**

### **Descrição do problema**

Escreva uma função que receba uma string de colchetes como entrada e determine se a ordem dos colchetes é válida. Um colchete é considerado qualquer um dos seguintes caracteres: **`(`**, **`)`**, **`{`**, **`}`**, **`[`**, ou **`]`**.

Dizemos que uma sequência de colchetes é válida se as seguintes condições forem atendidas:

- Não contém colchetes sem correspondência.
- O subconjunto de colchetes dentro dos limites de um par de colchetes correspondente também é um par de colchetes correspondentes.

### Exemplos

- **`(){}[]`** é válido
- **`[{()}](){} é válido`**
- **`[]{()`** não é válido
- **`[{)]`** não é válido

### **Como funciona**

A classe ValidaColchetes é responsável por validar a ordem dos colchetes em uma string de entrada. A validação é realizada seguindo duas condições:

1. Não deve haver colchetes sem correspondência.
2. O subconjunto de colchetes dentro dos limites de um par de colchetes correspondente também é um par de colchetes correspondentes.

A validação é feita empilhando os caracteres de abertura de colchetes em uma pilha e, em seguida, verificando se cada caractere de fechamento de colchete corresponde ao topo da pilha. Se a pilha estiver vazia, não há correspondência de abertura para o caractere de fechamento atual. Se o caractere de fechamento não corresponder ao topo da pilha, a sequência de colchetes não é válida.

No final do processo, se todos os caracteres foram percorridos e a pilha estiver vazia, a sequência de colchetes é considerada válida.

Para testar o desafio, siga os passos abaixo:

1. Clone o repositório em sua máquina local 
    
    ```powershell
    git clone https://github.com/thaylorz/suportes-balanceados-csharp.git
    ```
    
2. Execute a aplicação.
    
    ```powershell
    dotnet run --project .\SuportesBalanceados.Application\
    ```
    
3. Insira a string de entrada para validar. Certifique-se de que a string contenha apenas colchetes ( ), { }, [ ].
4. Verifique o resultado da validação.

Você tambem pode executar os testes unitarios com o comando 

```powershell
dotnet test
```
