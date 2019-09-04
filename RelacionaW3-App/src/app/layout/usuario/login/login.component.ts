import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../../../router.animations';
import { AuthService } from '../../_services/auth.service';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    animations: [routerTransition()]
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
                this.toastr.success('Logado com sucesso');
            },
            error => {
                this.toastr.error('Atenção: Falha ao tentar logar!')
            }
        )
    }

    // onLoggedin() {
    //     localStorage.setItem('isLoggedin', 'true');
    // }
}
