# Note Keeper

Bem-vindo ao Note Keeper!<br>
Este é um projeto de um aplicativo web simples desenvolvido para estudos e aprimoração de conhecimentos em ASP.NET!<br>
Com este aplicativo, você pode criar, editar e excluir notas de forma prática e organizada.

## 🖥 Visão geral
O Gerenciador de Notas é uma aplicação web criada com o objetivo de facilitar o registro e organização de notas. Com este projeto, você pode:

- Criar notas: Crie novas notas informando um título e o conteúdo desejado.
- Visualizar notas: Veja todas as suas notas em uma lista organizada, exibindo o título e o conteúdo de cada uma.
- Editar notas: Edite o título e o conteúdo das notas existentes de acordo com suas necessidades.
- Excluir notas: Remova notas que já não são mais relevantes para você.

## 📙 Screenshots do sistema
Aqui estão fotos para mostrar como é o Note Keeper:
<br>
<br>
<img src="https://i.imgur.com/vtVLW4c.png" alt="Página Inicial" height="60%" width="60%"/>
<details>
    <summary>Clique aqui para expandir e ver mais como é por dentro do sistema!</summary>
  <h3>Página inicial:</h3>
      <img src="https://i.imgur.com/D7ky7P2.png" alt="Página Inicial" height="60%" width="60%"/>
  <h3>Criação de notas:</h3>
     <img src="https://i.imgur.com/tNn0NNo.png" alt="Criar notas" height="60%" width="60%"/>
  <h3>Editar notas:</h3>
      <img src="https://i.imgur.com/pCxXbs5.png" alt="Editar notas" height="60%" width="60%"/>
    <h3>Deletar notas:</h3>
      <img src="https://i.imgur.com/4pFtIh0.png" alt="Deletar notas" height="60%" width="60%"/>
</details>

## 🛠️ Tecnologias utilizadas
O Note Keeper foi desenvolvido utilizando as seguintes tecnologias:

- HTML / CSS / JavaScript: Linguagens utilizadas para construção do front-end do aplicativo.
- ASP.NET Core: Framework utilizado para construir o aplicativo web.
- C#: Linguagem de programação utilizada no backend do aplicativo.
- SQL Server: Sistema de gerenciamento de banco de dados utilizado para armazenar as notas.

## ⚙ Pré-requisitos
Antes de executar o projeto, você precisará ter o seguinte instalado em sua máquina:

- ASP.NET Core 6.0 SDK: O SDK do ASP.NET Core é necessário para compilar e executar o projeto. Você pode baixá-lo em: https://dotnet.microsoft.com/download.
- SQL Server: Certifique-se de ter o SQL Server instalado em sua máquina ou tenha acesso a um servidor SQL Server.

## Configuração do banco de dados
O Note Keeper utiliza o SQL Server como sistema de gerenciamento de banco de dados. Siga as etapas abaixo para configurar o banco de dados em sua máquina:

1. Crie um novo banco de dados no SQL Server para o Gerenciador de Notas.
2. No arquivo <a href="https://github.com/Gabriel-Vismeck/note-keeper/blob/main/Program.cs">Program.cs</a>, atualize a string de conexão do banco de dados com as informações corretas, como nome do servidor, nome do banco de dados, nome de usuário e senha.

## 🔧 Executando o projeto
Após configurar o banco de dados, siga as etapas abaixo para executar o projeto:

1. Clone este repositório para o seu ambiente local.
2. Abra o projeto em sua IDE preferida.
3. No terminal, navegue até a pasta principal do programa.
4. Execute o comando "dotnet ef database update" para aplicar as migrações do Entity Framework Core e criar a estrutura do banco de dados.
5. Execute o projeto com sua IDE e abra seu navegador no endereço que o servidor está rodando o projeto.

##
>"O verdadeiro conhecimento é aquele que permite ação."
>
>-*Confúcio*

