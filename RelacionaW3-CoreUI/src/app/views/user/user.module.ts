// Angular
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDatepickerModule, BsDropdownModule, TooltipModule, ModalModule } from 'ngx-bootstrap';


// Theme Routing

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule,
    ToastrModule,
    BsDatepickerModule.forRoot(),
    BsDropdownModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    ReactiveFormsModule
  ],
  declarations: [
    UserComponent
  ]
})
export class UserModule { }
