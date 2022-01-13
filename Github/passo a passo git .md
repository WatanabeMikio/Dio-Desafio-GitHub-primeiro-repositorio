# Comandos para Git

 1. iniciar o Git na pasta selecionada *Git Bash*
 2. 1 vez usando Git necessario configurar NAME e Email
      - git config --global(ou local) user.email"email@msmsm.com"
      - git config --global(ou local) user.name"nome"
     obs caso necessario alterar utilizar git config --global(ou local) --unset user.email
 3. criar arquivo Markdown
 4. voltar para o terminal e commitar os arquivos
      - git add * -----> adiciona todos os arquivos untracked para conhecidos
      - git commit -m "mensagem" ----> mensagem importante para ver o que se refere o commit
 5. dps de salva no diretorio local levar para o diretory remoto apontando no Git o Github.

 ## passos para cricao da chave

 1. utilizar comandos ssh-key para gerar chave unica pegar e ir para o GitHub
 2. ir ate o GitHub e colar a chave na configuracao
 3. criar agente e passar a chave para ele toda vez que usarmos essa chave ele percebe e descripitografa a mensagem

