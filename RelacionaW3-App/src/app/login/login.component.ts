import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
    animations: [routerTransition()]
})
export class LoginComponent implements OnInit {
    
    testetitulo = 'Login';
    model: any = {};
    constructor(
      public router: Router
    ) {}

    ngOnInit() {}

    login() {
        console.log();

    }

    onLoggedin() {
        localStorage.setItem('isLoggedin', 'true');
    }
}
