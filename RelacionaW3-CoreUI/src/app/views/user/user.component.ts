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

  registerForm: FormGroup;
  user: User;

  constructor(private authService: AuthService
    , public router: Router
    , public fb: FormBuilder
    , private toastr: ToastrService) {
  }

  ngOnInit() {
    this.validation();
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

  showModalAtualizar() {
    Swal.fire({
        title: 'Feito!',
        text: 'O usuário foi cadastrado com sucesso.',
        type: 'success'
    });
}

showModalErro() {
  Swal.fire({
      title: 'Erro!',
      text: 'Esse nome de usuário já existe, entre com outro nome!',
      type: 'error'
  });
}

  cadastrarUsuario() {
    if (this.registerForm.valid) {
      this.user = Object.assign(
        { password: this.registerForm.get('passwords.password').value },
        this.registerForm.value);
        this.authService.registrar(this.user).subscribe(
        () => {
          this.router.navigate(['/user/user']);
          this.showModalAtualizar();
        }, error => {
          const erro = error.error;
          erro.forEach(element => {
            switch (element.code) {
              case 'DuplicateUserName':
                this.showModalErro();
                break;
              default:
                this.toastr.error(`Erro no Cadastro! CODE: ${element.code}`);
                break;
            }
          });
        }

      );
    }
  }
}
