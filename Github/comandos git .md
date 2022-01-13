# Comandos no Git

## comandos de configuracao do git para autor
1. git config --global user.name"name"
2. git config --global(ou local) user.email"email"
3. git config --global --unset user.name"name" (remove o nome)
4. git config --global --unset user.email"email" (remove o email)

## comandos iniciais
1. git init -inicia o git na pasta.
2. git add  - (pode ser * ou nome do arquivo) adiciona os arquivos para o local conhecido Untracked --> Tracked
3. git commit -commita os arquivos e gera o sha de conjunto de arquivo unico

## comandos Base
1. git config --list (lista as configuracoes do git) utiliz *q* para sair
2. clear (limpa terminal)
3. ls lista diretorio
4. git status - mostra o que esta na pasta commitado ou nao - status dos arquivos.
5. git remote add origin "url do repository"(origem para enviar do local para o remoto)
6. git remote -v (lista de repositorio remotos cadastrados)
7. git push (apelido do arquivo) (nome em azul na frente *main*, *master* etc)

## comando de criacao e chave ssh
1. ssh-keygen -t ed25519 -C email
2. cat id_(nome da chave ) -verifica conteudo
3. pwd (mostra caminho completo da pasta)
4. eval $(ssh-agent -s)  (create agent to key (cria agente para chave)
5. ssh-add id_(nome da chave privada ou o caminho da chave) - entrega a chave para o agente criado