import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';

import { LoginRoutingModule } from './login-routing.module';
import { LoginComponent } from './login.component';
import { FormsModule } from '@angular/forms';

@NgModule({
    imports: [ 
        CommonModule,
        TranslateModule,
        FormsModule,
        LoginRoutingModule
    ],
    declarations: [LoginComponent],
    schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class LoginModule {}
