# ONION ARCHITECTURE

<img src='picture.png'/>

> Camada externa : API
> Camada Interna: Domain (camada que está no centro)

A camada externa é aquela que está mais acessível para o usuário, e
a camada interna é aquela que está diretamente no centro da regra de negócio

A ideia do Onion é deixar a camada interna para as bordas, para que não haja dependências

- .Domain Não tem dependência
- .Data (infraS)> depende de > Domain
- .API > depende de > Domain
- .API > depende de > Data(infraS)

https://www.youtube.com/watch?v=sZPBvlmuvw4
https://github.com/andreluizsecco/UnitOfWork.BookStore/blob/main/src/UnitOfWork.BookStore.Data.EFCore/Repositories/OrderRepository.cs