import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";


@Injectable({
  providedIn:"root"
})
export class UsuarioServico {


  private baseURL: string;
  private _usuario: Usuario;

  set usuario(usuario: Usuario) {
    sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
    this._usuario = usuario;
  }

  get usuario(): Usuario {
    let usuario_json = sessionStorage.getItem("usuario-autenticado");
    this._usuario = JSON.parse(usuario_json);
    return this._usuario;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.baseURL = baseUrl;

  }

  public usuario_autenticado(): boolean {
    return this._usuario != null && this._usuario.email != "" && this._usuario.senha != "";
    //return this._usuario != null;
  }

  public usuario_administrador(): boolean {
    //return this._usuario != null && this._usuario.email != "" && this._usuario.senha != "";
    return this.usuario_autenticado() && this.usuario.ehAdministrador;
  }

  public limpar_sessao() {
    sessionStorage.setItem("usuario-autenticado", "");
    this._usuario = null;
  }

  public verificarUsuario(usuario: Usuario): Observable<Usuario> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    return this.http.post<Usuario>(this.baseURL + "api/usuario/VerificarUsuario", body, { headers });
  }

  public cadastrarUsuario(usuario: Usuario): Observable < Usuario > {

    return this.http.post<Usuario>(this.baseURL + "api/usuario", JSON.stringify(usuario), { headers: this.headers });

  }

}

