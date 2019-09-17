import { Component,  Inject, OnInit } from '@angular/core';
import { DOCUMENT } from '@angular/common';

import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../../views/misc/_services/auth.service';
import { Router } from '@angular/router';
import { navItems } from '../../_nav';



@Component({
  selector: 'app-dashboard',
  templateUrl: './default-layout.component.html'
})
export class DefaultLayoutComponent implements OnInit {
  public navItems = navItems;
  public sidebarMinimized = true;
  private changes: MutationObserver;
  public element: HTMLElement;

  constructor(  private authService: AuthService,
    public router: Router,
    private toastr: ToastrService,
    @Inject(DOCUMENT) _document?: any) {

    this.changes = new MutationObserver((mutations) => {
      this.sidebarMinimized = _document.body.classList.contains('sidebar-minimized');
    });
    this.element = _document.body;
    this.changes.observe(<Element>this.element, {
      attributes: true,
      attributeFilter: ['class']
    });
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this.toastr.info('Deslogado com sucesso!');
    this.router.navigate(['../login/']);

  }

  ngOnInit() {

  }


}
