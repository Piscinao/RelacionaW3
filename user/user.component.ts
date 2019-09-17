import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { AuthService } from '../misc/_services/auth.service';
import { User } from '../misc/_models/User';
import Swal from 'sweetalert2';

@Component({
  templateUrl: './user.component.html'
})
export class UserComponent implements OnInit {

  usuariosFiltrados: User [];
  modoSalvar = 'post';
  registerForm: FormGroup;
  users: User[];
  user: User;

  _filtroLista = '';


  constructor(private authService: AuthService
    , public router: Router
    , public fb: FormBuilder
    , private toastr: ToastrService) {
  }

  ngOnInit() {
    this.validation();
    this.getUser();
  }


  openModalDelete(user: User) {
    Swal.fire({
        title: 'Você tem certeza?',
        text: 'Essa ação, não poderá ser desfeita!',
        type: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        cancelButtonText: 'Cancelar',
        confirmButtonText: 'Sim, excluir!'
      }).then((result) => {
        if (result.value) {
            this.user = user;
            this.authService.deleteUser(this.user.id).subscribe(
                () => {
                    this.getUser();
                }, error => {
                    console.log(error);
                }
            );
          Swal.fire(
            'Excluído!',
            'O dado fui excluído com sucesso.',
            'success'
          );
        }
      });
}
showModalRegistro() {
    Swal.fire({
        title: 'Feito!',
        text: 'O dado foi salvo com sucesso.',
        type: 'success'
    });
}

showModalAtualizar() {
    Swal.fire({
        title: 'Feito!',
        text: 'Os dados foram atualizados com sucesso.',
        type: 'success'
    });
}

showModalErro() {
    Swal.fire({
        title: 'Erro!',
        text: 'Algum problema ocorreu contate o administrador do sistema.',
        type: 'error'
    });
}

  openModal(template: any) {
    this.registerForm.reset();
    template.show();
}

get filtroLista(): string {
  return this._filtroLista;
}
set filtroLista(value: string) {
  this._filtroLista = value;
  this.usuariosFiltrados = this.filtroLista ? this.filtrarUsuarios(this.filtroLista) : this.users;
}

filtrarUsuarios(filtrarPor: string): User[] {
  filtrarPor = filtrarPor.toLocaleLowerCase();
  return this.users.filter(
      user => user.fullName.toLocaleLowerCase().indexOf(filtrarPor) !== -1
  );
}

getUser() {
  // requisição na api em ajax
  this.authService.getAllUser().subscribe(
      (_users: User[]) => {
          this.users = _users;
          this.usuariosFiltrados = this.users;
      }, error => {
          this.toastr.error(`Erro ao tentar carregar users: ${error}`);
      });
}

  validation() {
    this.registerForm = this.fb.group({
      fullName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      userName: ['', Validators.required],
      passwords: this.fb.group({
        password: ['', [Validators.required, Validators.minLength(4)]],
        confirmPassword: ['', Validators.required]
      }, { validator: this.compararSenhas })
    });
  }

  compararSenhas(fb: FormGroup) {
    const confirmSenhaCtrl = fb.get('confirmPassword');
    if (confirmSenhaCtrl.errors == null || 'mismatch' in confirmSenhaCtrl.errors) {
      if (fb.get('password').value !== confirmSenhaCtrl.value) {
        confirmSenhaCtrl.setErrors({ mismatch: true });
      } else {
        confirmSenhaCtrl.setErrors(null);
      }
    }
  }

  novoUsuario(template: any) {
    this.modoSalvar = 'post';
    this.openModal(template);
}

editarUsuario(user: User, template: any) {
  // this.toastr.success('Hello World', 'Toast Teste');
  this.modoSalvar = 'put';
  this.openModal(template);
  // carrega dado atual
  this.user = Object.assign({}, user);
  // preenche o formulario
  this.registerForm.patchValue(this.user);

}

salvarAlteracao(template: any) {
  if (this.registerForm.valid) {
      if (this.modoSalvar === 'post') {
        this.user = Object.assign(
          { password: this.registerForm.get('passwords.password').value },
          this.registerForm.value);
      this.authService.registrar(this.user).subscribe(
          (novoUser: User) => {
              template.hide();
              this.getUser();
              this.showModalRegistro();
          }, error => {
            const erro = error.error;
            erro.forEach(element => {
              switch (element.code) {
                case 'DuplicateUserName':
                  this.toastr.error('Cadastro Duplicado!');
                  break;
                default:
                  this.toastr.error(`Erro no Cadatro! CODE: ${element.code}`);
                  break;
              }
            });
          }
      );
   } else {
      this.user = Object.assign({id: this.user.id}, this.registerForm.value);
      this.authService.putUser(this.user).subscribe(
          () => {
              template.hide();
              this.getUser();
              this.showModalAtualizar();
          }, error => {
              this.showModalErro();
          }
      );

   }
  }
}

  cadastrarUsuario() {
    if (this.registerForm.valid) {
      this.user = Object.assign(
        { password: this.registerForm.get('passwords.password').value },
        this.registerForm.value);
        this.authService.registrar(this.user).subscribe(
        () => {
          this.router.navigate(['/user/user']);
          this.toastr.success('Cadastro Realizado');
        }, error => {
          const erro = error.error;
          erro.forEach(element => {
            switch (element.code) {
              case 'DuplicateUserName':
                this.toastr.error('Cadastro Duplicado!');
                break;
              default:
                this.toastr.error(`Erro no Cadatro! CODE: ${element.code}`);
                break;
            }
          });
        }
      );
    }
  }
}
