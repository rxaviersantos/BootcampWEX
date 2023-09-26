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



