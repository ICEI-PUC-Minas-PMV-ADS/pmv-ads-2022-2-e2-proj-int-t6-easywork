# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito Funcional  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| Cadastrar: Funcionalidade permite o usuário fazer um cadastro. | Views - Usuario - Criar.cshtml / UsuarioController.cs | 
|RF-002| Editar a conta: Funcionalidade permite o usuário editar os dados da sua conta.  | Views - AlterarDados - Index.cshtml / AlterarDadosController.cs |
|RF-003| Excluir a Conta: Funcionalidade permite o usuário excluir a sua conta. | Views - ApagarUsuario - Index.cshtml / ApagarUsuarioController.cs | 
|RF-004| Efetuar Login: Funcionalidade permite o usuário fazer login para acessar os conteúdos do site. | Views - Login - Index.cshtml / LoginController.cs |
|RF-005| Redefinir Senha: Funcionalidade envia para o e-mail cadastrado do usuário uma nova senha. | Views - Login - RedefinirSenha.cshtml / LoginController.cs | 
|RF-006| Alterar Senha: Funcionalidade permite o usuário alterar a sua senha já cadastrada. | Views - AlterarSenha - Index.cshtml / AlterarSenhaController.cs |
|RF-007| Visualizar Profissionais: Funcionalidade permite os usuários terem acesso aos profissionais indicados. | Views - Profissionais - Index.cshtml / ProfissionaisController.cs | 
|RF-008| Acessar Cursos e Materiais: Funcionalidade permite os usuários terem acesso a cursos e materiais indicados pelo site. | Views - Cursos_e_Materiais - Index.cshtml / Cursos_e_MateriaisController.cs |

</br>
</br>

|ID    | Descrição do Requisito Não Funcional  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-006| O site deverá criptografar a senha dos usuários. | Helper - Criptografia.cs | 
</br>

# Instruções de acesso

Link para acesso a aplicação:  andersonmr-001-site1.itempurl.com

Login e senha teste:
----

Login: admin

Senha: 123456

E-mail e senha teste:
----

E-mail teste: contaptestet@hotmail.com

Senha: C#nta777 (por gentileza, não alterar a senha. Obrigado!)

