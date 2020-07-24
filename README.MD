Loja virtual usando DotNet CORE e Angular com MySql

Para usar a area de administrador é necessario inserir via script de banco um usuario:
insert into lojaVirtual.usuarios (email, senha, nome, sobrenome,ehadministrador) values ('admin@email.com', 'admin', 'admin', 'admin', 1);

Telas:
Tela de Login
Tela de Cadastro de Usuario
Tela de Cadastro de Produtos
Tela de Carrinho de Compra

Tabelas e Relacionamentos
Tabela : Usuarios
Tabela : Produtos
Tabela : Pedidos
	Relacionamento: Pedido --> Usuario
	Relacionamento: Pedido --> FormasPagamento
Tabela : ItensPedido
	Relacionamento: ItensPedido --> Pedido
Tabela : FormasPagamento

