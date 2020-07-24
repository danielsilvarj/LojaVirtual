import { Component, OnInit } from "@angular/core";
import { Produto } from "../../modelo/produto";
import { ProdutoServico } from "../../servicos/produto/produto.servico";
import { Router } from "@angular/router";


@Component({
  selector: "pesquisa-produto",
  templateUrl: "./pesquisa.produto.component.html",
  styleUrls: ["./pesquisa.produto.component.css"]
})
export class PesquisaProcutoComponent implements OnInit {


  public produtos: Produto[];

  ngOnInit(): void {
        
  }

  constructor(private produtoServico: ProdutoServico, private routar: Router) {
    this.produtoServico.obterTodosProdutos()
      .subscribe(
        produtos => {
          this.produtos = produtos;
        },
        e => {
          console.log(e.error);
        });
  }

  public adicionarProduto() {
    sessionStorage.setItem('produtoSessao', "");
    this.routar.navigate(['/produto']);
  }

  public deletarProduto(produto: Produto) {
    var retorno = confirm("Deseja realmente deletar o produto selecionado ?");
    if (retorno == true) {
      this.produtoServico.deletar(produto)
        .subscribe(
          produtos => {
            this.produtos = produtos;
            //console.log()
          },
          e => {
            console.log(e.errors);
          }
        );
    }
  }

  public editarProduto(produto: Produto) {
    sessionStorage.setItem('produtoSessao', JSON.stringify(produto));
    this.routar.navigate(['/produto']);
  }


}
