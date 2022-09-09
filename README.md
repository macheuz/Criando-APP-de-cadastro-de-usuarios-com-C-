# Aplicativo de gestão de clientes para academia

Esse software foi desenvolvido com o intuito de aprendizado, a como criar uma aplicação com um banco de dados integrado,
como fazer a atualização dos dados em diferentes formulários, como configurar os elementos interativos, os eventos (botões, datagrids, OpenDialog...),
como criar um arquivo instalável (.EXE)...

## Softwares e Componentes utilizados no projeto:
SQLite Studio<br/>
Visual Studio 2022 <br/>
System.Data.SQLite<br/>
Microsoft Visual Installer Projects<br/>

## Instalação pelo Visual Studio:
1- Clone o repositório para seu Visua lStudio
2- Instale o Microsoft Visual Installer Projects
3 - Adicione um novo projeto ao projeto -> Setup wizard, dê o nome ao projeto e selecione a pasta onde o Executável será criado
4- no setup wizard em "Choose project outputs to include" selecione todos os checkbox de saida primaria(inclusive) para cima
5 - em "Choose files to include" selecione o SQLite.interop.dll (bin/debug/x86)
6- Em Application Folder Crie as pastas imgs, fotos e banco
7- Adicione o arquivo "banco_academia" (bin/debug/banco) na pasta banco que acabou de ser criada na Application Folder
8- Adicione os arquivos "led_verde" e "led_vermelho" (banco de dados/imgs) na pasta imgs que acabou de ser criada na Application Folder
9- Va no gerenciador de soluções, clique com o botão direito do mouse e clique em compilar
10- Va na pasta que você selecionou para criar o executável (etapa 3) e execute o setup (debug/release)
11 - Teste o Programa

## Download do Executável do programa
https://drive.google.com/file/d/1OXILUbXzVk2IRpNqX0FCAcqBx7VeUTCv/view?usp=sharing
