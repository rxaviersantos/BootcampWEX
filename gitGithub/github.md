<h1 align="center"> Primeiros passos com GitHub</h1>

Este tutorial ensina os princípios básicos de GitHub, como: 
```
- Criar um repositório
- Iniciar e gerenciar uma nova branch
- Fazer alterações em um arquivo, enviá-lo por push para o GitHub como commit
- Abrir e realizar merge de um pull request
```

Para concluir este tutorial, você precisa ter uma conta do **[Github](https://github.com/)**  e acesso à Internet. Para saber mais sobre github, vá até o **[Glossário ](https://docs.github.com/pt/get-started/quickstart/github-glossary)**.

**1** - Na página do GitHub, selecione Novo Repositório no canto superior direito. 

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/418051bf-5046-4fe4-bb7b-9c4e20a2ed68)

**2** - No campo "Nome do repositório", digite ``"Nome do Seu Projeto"``.

**3** - No campo "Descrição", digite uma breve descrição do seu projeto.

**4** - Selecione se o repositório será ``Público ou Privado``.

**5** - Selecione Adicionar um arquivo ``LEIAME``.

**6** - Clique em ``Criar repositório``.

---
### Branch 

A Branch permite que você tenha diferentes versões de um repositório de uma só vez.

Seu repositório tem uma branch chamado main que é uma branch definitiva. Você pode criar branches adicionais com base em main no repositório. Você pode usar branches para fazer experimentos e edições antes de fazer commit delas em main.

Este diagrama mostra:
```
- A branch main
- A criação de uma nova branch chamada feature
- O percurso que a branch feature faz antes de ser mesclado com a main
```

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/1190f61e-2ee1-4b7a-a922-6a08af4a345e)

---
### Criando uma nova branch 

<ol>
    <li>Clique na guia código de seu repositório</li>
    <li>Clique no menu suspenso main</li>
</ol>

  ![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/5f4401ee-2376-45bb-b96f-fe57a0594c8b)



3. No campo main, digite o nome da nova branch, exemplo: <code>feature.</code>

4. Clique em criar branch


![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/f932432f-8279-4ba9-b4d4-76cb66738628)

Agora terá duas branches, main e feature. 

---
### Criando e fazendo commit das alterações

Você pode fazer e salvar as alterações nos arquivos do seu repositório. Cada commit tem uma mensagem de commit associada, que é uma descrição que explica por que uma determinada alteração foi feita. As mensagens de commit capturam histórico das suas alterações para que outros colaboradores possam entender o que você fez e o porquê.


1. Selecione a nova branch criada ex. (feature), clique em um arquivo já criado ou crie um novo arquivo ex. (add new readme).
2. Clique para editar o arquivo.
3. No editor, escreva suas alterações ex. (usando elementos Markdown).
4. Clique em fazer commit das alterações.
5. Na caixa ```Propor alterações```, escreva uma mensagem de commit descrevendo as alterações.
6. Clique em propor alterações

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/04db9f09-57ad-4e73-a42f-d55be20dc746)

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/ed309ad1-0d90-4e61-818f-714b45c278a4)

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/cff7361b-c462-4dd2-a336-f8086cbe35bf)


Essas alterações serão feitas somente no arquivo README na branch ```feature```, ou seja, agora esse branch tem um conteúdo diferente de ```main```.

---
### Abrindo um Pull Request

Ao abrir um pull request, você está propondo suas alterações e solicitando que alguém analise e faça ``Pull`` na sua contribuição e os mescle na sua ``branch``.
Os Pull Requests mostram diffs, ou diferenças, do conteúdo de ambos os branches. As alterações, adições e subtrações são exibidas em cores diferentes.    
Assim que você fizer um commit, você poderá abrir um pull request e começar uma discussão, mesmo antes de o código ser concluído.

Você pode até abrir *Pull Request* em seu próprio repositório e fazer merge você mesmo. É uma ótima maneira de aprender o fluxo de GitHub antes de trabalhar em projetos maiores.

1. Clique na guia Solicitações de Pull Request do seu repositório.
2. Selecione nova solicitação de Pull Request.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/1925a505-9a98-4d77-8b8a-c5200742c365)

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/bf607c6b-c801-4f34-b5ca-90b3dd65df7e)

---
3. Na caixa Compare e analise, selecione a Branch que foi criada, ex. ``feature``, para comprá-la com a ``main``.


![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/dd2c032a-f062-40a2-b0c5-115b70bddda0)

---
4. Veja as mudanças que você fez na página de Comparação e certifique-se que eles são o que você deseja enviar.


![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/fdfca010-d074-43c4-bf80-2535bf75c688)

---
5. Clique em Criar solicitação de Pull Request.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/f376ce79-0dd8-4e21-a746-03ca1a2def16)

---
6. Dê um título ao seu pull request e escreva uma breve descrição das suas alterações. Você pode incluir emojis e arrastar e soltar imagens e gifs.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/ea0ab65d-366b-415a-bb5a-d9de9008b4e9)

---
7. Opcionalmente, à direita do título e da descrição, clique no  ao lado de Revisores, Destinatários, Rótulos, Projetos ou Marco para adicionar qualquer uma dessas opções à sua solicitação de pull.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/f4427ab0-7b5b-4f8c-871a-03aeae9c5fa6)


8. Clique em Criar solicitação de pull.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/e392e4cb-ff66-4fac-ae2f-134c6795d51b)

---
### Mesclando o Pull Request

Nesta etapa final, você mesclará a branch ``feature`` na branch main. Depois que você mesclar a solicitação de ``Pull``, as alterações na branch ``feature`` serão incorporadas na branch ``main``.

Às vezes, uma solicitação de ``Pull`` pode introduzir alterações no código que entram em conflito com o código existente em ``main``. Se houver algum conflito, o GitHub irá alertar você sobre o código conflitante e impedirá a fusão até que os conflitos sejam resolvidos. Você poderá criar um commit que resolve os conflitos ou usar comentários na ``Pull Request`` para discutir os conflitos com os integrantes da equipe.

Nesta apresentação, não terá conflitos. Portanto, está pronto para fazer merge da branch ``feature`` na branch principal.

1. Na parte inferior da solicitação do ``Pull Request``, clique em **Mesclar solicitação** de Pull Request para mesclar as alterações na branch ``main``.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/8b2c97ec-91cb-41fc-b4d1-6ac185308de6)

---
2. Clique em Confirmar a mesclagem. Você receberá uma mensagem de que a solicitação foi mesclada com sucesso e o pedido foi encerrado.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/a93a843e-bd02-45c6-8061-aea1ed172375)

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/1e677282-85e8-4a10-a46d-bb57a86da580)

--
3. Clique em Excluir branch. Agora que a sua solicitação de ``Pull Request`` foi mesclada e as alterações estão em ``main``, você pode excluir o branch ``feature`` com segurança. Se você quiser fazer mais alterações no seu projeto, você pode sempre criar uma nova branch e repetir este processo.

![image](https://github.com/rxaviersantos/BootcampWEX/assets/85380530/ef1d4b77-734c-4981-bb55-b0a897fe5d40)

   







