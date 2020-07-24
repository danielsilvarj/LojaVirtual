import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";
import { Router, ActivatedRoute, RouterModule } from "@angular/router";


@Component({
  selector: "cadastro-usuario",
  templateUrl: "./cadastro.usuario.component.html",
  styleUrls:["./cadastro.usuario.component.css"]
})
export class CadastroUsuarioComponent implements OnInit {
    
  public usuario: Usuario;
  public ativar_spinner: boolean;
  public mensagem: string;
  public usuarioCadastrado: boolean;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,private usuarioServico: UsuarioServico) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  public cadastrar() {
    //alert("Nome: " + this.usuario.nome + " Senha " + this.usuario.senha + " Email " + this.usuario.email + " SobreNome " + this.usuario.sobreNome);
    this.ativar_spinner = true;
    this.usuarioServico.cadastrarUsuario(this.usuario)
      .subscribe(
        usuarioJson => {
          this.usuarioCadastrado = true;
          this.mensagem = "";
          this.ativar_spinner = false;
        },
        e => {
          this.usuarioCadastrado = false;
          this.mensagem = e.error;
          this.ativar_spinner = false;
        }
      );
  }

}
