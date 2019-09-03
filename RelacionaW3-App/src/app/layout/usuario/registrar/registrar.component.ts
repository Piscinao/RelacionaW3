import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { User } from '../../_models/User';
import { AuthService } from '../../_services/auth.service';
import { Router } from '@angular/router';


@Component({
    selector: 'app-registrar',
    templateUrl: './registrar.component.html',
    styleUrls: ['./registrar.component.scss']
})
export class RegistrarComponent implements OnInit {
  registrarForm: FormGroup;
  user: User;

  constructor(public fb: FormBuilder
    , private toastr: ToastrService
    , public router: Router
    , private authService: AuthService)
    { }

  ngOnInit() {
    this.validation();

  }

  validation() {
    this.registrarForm = this.fb.group({
      nomeCompleto: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      userName: ['', Validators.required],
      passwords: this.fb.group({
        password: ['', [Validators.required, Validators.minLength(4)]],
        confirmPassword: ['', Validators.required]
      }, {validator: this.compararSenhas})
    });
  }

  compararSenhas(fb: FormGroup)
  {
    // componente
    const confirmSenhaCtrl = fb.get('confirmPassword');
    // conponente validação
    if (confirmSenhaCtrl.errors == null || 'mismatch' in confirmSenhaCtrl.errors) {
    // valor é o mesmo de confirmsenha
      if (fb.get('password').value !== confirmSenhaCtrl.value) {
        confirmSenhaCtrl.setErrors({ mismatch: true});
      } else {
          confirmSenhaCtrl.setErrors(null);
      }
    
      }
    }
   // adiciona um password tem que fazer match com os dados das variaveis
   cadastrarUsuario() {
    if (this.registrarForm.valid) {
      this.user = Object.assign(
        { password: this.registrarForm.get('passwords.password').value },
        this.registrarForm.value);
      this.authService.registrar(this.user).subscribe(
        () => {
          this.router.navigate(['app/login/login']);
          this.toastr.success('Cadastro Realizado');
        }, error => {
          const erro = error.error;
          erro.forEach(element => {
            switch (element.code) {
              case 'DuplicateUserName':
                this.toastr.error('Cadastro Duplicado!');
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