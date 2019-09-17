// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-dashboard',
//   templateUrl: 'login.component.html'
// })
// export class LoginComponent { }

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../misc/_services/auth.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
    testetitulo = 'Login';
    model: any = {};

    constructor(private authService: AuthService
        , public router: Router
        , private toastr: ToastrService) {}

    ngOnInit() {
        if (localStorage.getItem('token') != null) {
            this.router.navigate(['/dashboard']);
        }
    }

    login() {
        this.authService.login(this.model)
        .subscribe(
            () => {
                this.router.navigate(['/dashboard']);
                this.toastr.success('Bem vindo a RelacionaW3', '\n Logado com sucesso!');
            },
            error => {
                this.toastr.error('Verifique se digitou os dados corretamente!', '\nAtenção: Falha ao tentar logar!');
            }
        );
    }
    // onLoggedin() {
    //     localStorage.setItem('isLoggedin', 'true');
    // }
}

