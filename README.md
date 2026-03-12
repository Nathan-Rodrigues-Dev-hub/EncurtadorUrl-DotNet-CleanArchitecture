# 🔗 Encurtador de URL (.NET 8)

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)]()
[![Architecture](https://img.shields.io/badge/Architecture-Clean-blue)]()

Este projeto é uma implementação robusta de um serviço de encurtamento de URLs, focada em demonstrar o domínio de arquiteturas de software modernas e princípios de design escaláveis.

---

## 🏗️ Arquitetura do Projeto

A solução segue os princípios da **Clean Architecture**, garantindo que a lógica de negócio esteja protegida de mudanças externas (bancos de dados, frameworks, interfaces).



### Organização das Camadas:

| Camada | Responsabilidade |
| :--- | :--- |
| **`TECH.CORE`** | Contém Entidades, Value Objects e Interfaces de Domínio. É o coração do sistema, sem dependências externas. |
| **`TECH.APPLICATION`** | Implementa o padrão **CQRS** via **MediatR**. Orquestra as regras de negócio e casos de uso. |
| **`TECH.INFRASTRUCTURE`** | Camada de persistência, comunicação com bancos de dados e serviços externos. |
| **`TECH.WEBAPI`** | Ponto de entrada da aplicação. Exposição de endpoints HTTP e injeção de dependências. |

---

## 🚀 Tecnologias e Padrões

* **Linguagem:** C# (.NET 8)
* **Arquitetura:** Clean Architecture, DDD, CQRS
* **Comunicação:** MediatR
* **Testes:** xUnit (Testes unitários automatizados)

---

## 🧪 Qualidade de Software

Abaixo, um exemplo da validação da lógica de negócio através de testes unitários automatizados, garantindo a confiabilidade das regras de encurtamento:

```csharp
[Fact]
public async Task Handler_Deve_Gerar_Um_Codigo_De_6_Caracteres()
{
    // Arrange
    var handler = new CreateUrlCommandHandler();
    var command = new CreateUrlCommand("[https://google.com](https://google.com)");

    // Act
    var result = await handler.Handle(command, CancellationToken.None);

    // Assert
    Assert.Equal(6, result.Length);
}
````
🛠️ Como rodar o projeto
Clone este repositório: 

git clone https://github.com/Nathan-Rodrigues-Dev-hub/EncurtadorUrl-DotNet-CleanArchitecture.git

Abra a solução no JetBrains Rider ou Visual Studio.

Certifique-se de que o .NET 8 SDK está instalado.

Execute o projeto TECH.WEBAPI

Acesse a documentação do Swagger no navegador para testar os endpoints.