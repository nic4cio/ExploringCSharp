No processo de criar uma aplicação, muitas vezes nos deparamos com alguns desafios técnicos interessantes, principalmente para os iniciantes. Imagine que você acabou de ser contratado como pessoa desenvolvedora C#, estudou e tem seus projetos voltados somente para a plataforma Windows, a sua nova empresa utiliza por padrão o Linux, para redução de custo e licenciamento. Nesta situação, não tem jeito, você terá que recorrer ao sistema do Pinguim!

Os mais experientes com a plataforma .NET sabem que desde meados da década dos anos 2000 é possível desenvolver em C# no ambiente Linux. Para isso, se fazia necessário a utilização do projeto Mono, que inclusive existe até hoje.

Mas a partir de 2014 esse cenário mudou, com o desenvolvimento da plataforma .NET Core, que nasce tendo como um dos objetivos ser realmente multiplataforma, ou seja, a ideia é que você possa desenvolver o mesmo código para rodar no Windows, Linux e Mac, sem a necessidade de usar projeto de terceiros.

Beleza, mas se eu precisar criar um projeto C# no Linux, quais ferramentas preciso instalar? Como instalar? Existe alguma documentação? Neste artigo vamos te responder tudo!😉
.NET 6 no Linux

Para começar os trabalhos de criação de um projeto .C# no Linux, precisamos verificar a existência do .NET. Para isso vamos abrir o terminal do Linux e digitar os comandos: dotnet --list-sdks e dotnet --list-runtimes. Para esse artigo estou utilizando o Ubuntu 18. Espera-se como saída o que é mostrado na imagem abaixo:
alt text: Na é mostrado a tela do terminal do Linux com a execução dos comandos dotnet --list-sdks e dotnet --list-runtimes.

Mas caso eu não tenha instalado o .NET, como fazer? Vamos trabalhar com a versão mais recente até a escrita deste artigo .NET 6, que foi lançado em novembro de 2021 pela Microsoft e que agora unifica os recursos do .NET Framework ( Windows) com o .NET Core (multiplataforma).

Verifique a versão do seu Linux, você pode fazer isso acessando o portal da Microsoft e validar a sua versão.
alt text: Na imagem apresenta a tabela de versão do Linux Ubuntu e os .NET compatíveis.

Com o Ubuntu devidamente instalado, execute a sequência de comando abaixo para a instalação do SDK e da Runtime do .NET 6 no Linux Ubuntu e vamos usar o APT:

    Inicie instalando o pacote da Microsoft, para isso abra o terminal e cole o seguinte comando:

wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

    Na sequência vamos instalar o SDK ( pacote de ferramentas para desenvolver em .NET), execute o comando:

sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-6.0

    E por fim, mas não menos importante, a runtime:

sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-6.0

Após a execução destes passos abra seu terminal e execute novamente os comandos dotnet --list-sdks e dotnet --list-runtimes para validar sua instalação.
Instalando o VS Code no Ubuntu

Para criar o programa console no Linux, podemos utilizar qualquer editor de texto e salvar os arquivos com extensão .cs, mas que tal usar uma ferramenta mais robusta e flexível? Se você pensou no VS Code, acertou! Seguindo o passo a passo a seguir vamos prosseguir com sua instalação:

Acesse o site do VS Code e baixe a versão do pacote referente a distribuição que você está utilizando.
alt text: Na imagem mostra um recorte da imagem do site de download do VS Code e destaca em um quadro vermelho a extensão .deb.

A ferramenta também é multiplataforma, portanto podemos utilizá-la no Windows e Mac facilmente. Na versão desktop do Ubuntu é necessário ir ao diretório de download do pacote baixado (.deb) e depois de dois cliques proceder com a instalação como mostra a imagem abaixo:
alt text: Na imagem mostra um recorte da imagem de instalação visual do pacote .deb do VS Code.

Após a instalação ser concluída, podemos executar o VS Code clicando no ícone ou via terminal.
alt text: Na imagem mostra a tela inicial do VS Code instalado no linux Ubuntu.

Neste ponto, já estamos quase terminando a configuração, agora é importante que consigamos escrever os códigos C#, para isso vamos instalar alguns plugins. Clique no menu lateral esquerdo no ícone de extensões, como na imagem abaixo:
alt text: Na imagem mostra a tela inicial do VS Code destacando o menu lateral esquerdo exibindo o ícone de extensões.

Na tela que será aberta, pesquise pela nossa querida “C#” e clique em instalar a extensão, que é da própria Microsoft.
alt text: Na imagem mostra a tela inicial do VS Code destacando o menu lateral esquerdo exibindo o ícone de extensões.

Pronto, já podemos criar nossos projetos .NET e usar o C# como nossa linguagem de programação. Então, vamos criar um projeto novo?
Criando um projeto

Para criação do nosso projeto console, vamos inicialmente criar um diretório na pasta Documentos chamada UsandoConsoleNoLinux, você pode usar o terminal usando o comando mkdir NOME_DIRETORIO ou usar a interface gráfica por dentro do próprio VS Code.

Clicando no ícone do Explorador no canto superior esquerdo, para habilitar o botão de Abrir Pasta como apresentado na imagem abaixo:
alt text: Na imagem mostra a tela do VS Code destacando em uma sequência o icone do explorador no menu lateral esquerdo, o botão Abrir Pasta e o botão criar pasta na janela suspensa aberta.

Agora, para criar um projeto do tipo console, vá ao menu superior e clique em Terminal > Novo Terminal. Com o terminal aberto dentro do VS code digite o comando: dotnet new console.

Na sequência você irá perceber que serão criados os arquivos Program.cs e .csproj na raíz do diretório como vemos na imagem a seguir:
alt text: Na imagem mostra o explorador do VS Code o arquivo `Program.cs` e `UsandoConsoleNoLinux.csproj`.

Vamos abrir nosso Program.cs e digitar nosso helloworld Console.WriteLine(“Usando C# e .NET 6 no Linux!”);, por estamos com o .NET 6 o padrão do Program.cs é a utilização da “instrução de nível superior”, por isso o arquivo encontra-se somente com o comando Console.WriteLine e já podemos testar.

Para executar vamos usar o comando dotnet run, como mostrado na imagem abaixo:
alt text: Na imagem mostra um recorte da tela do VS Code, mostrando parte do arquivo Program.cs e o terminal com o comando dotnet run.

Podemos ainda executar nossa aplicação pelo terminal também usando o dotnet run ou “buildar” a aplicação usando dotnet build, veja na imagem a seguir:
alt text: A imagem mostrando o terminal do Linux Ubuntu com a execução do comando dotnet run e dotnet build.

Criamos e executamos um projeto console no ambiente Linux, muito bacana!😉
Conclusão

Neste artigo, apresentamos como configurar o .NET 6 no Linux Ubuntu, uma vez que muitas pessoas desenvolvedoras, principalmente as mais iniciantes, ainda focam em aprender e a desenvolver no Windows, e com o .NET 6 você pode estar entregando projetos no Linux ou Mac.

Para exemplificar e atestar a nossa querida ferramenta, criamos um projeto console, que por meios da linha de comandos (CLI) podemos executar e buildar nossa aplicação. Entendendo como configurar e executar o céu é o limite, te convido a testar criar uma API ou um projeto com acesso a dados no Linux usando o C#. Então vamos praticar e mergulhar ainda mais em tecnologia?