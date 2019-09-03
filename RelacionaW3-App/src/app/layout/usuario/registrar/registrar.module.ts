import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegistrarRoutingModule } from './registrar-routing.module';
import { RegistrarComponent } from './registrar.component';
import { PageHeaderModule } from 'src/app/shared/modules/page-header/page-header.module';
import { TooltipModule } from 'ngx-bootstrap';

@NgModule({
    imports: [
        CommonModule,
        RegistrarRoutingModule,
        FormsModule,
        TooltipModule.forRoot(),
        PageHeaderModule,
        ReactiveFormsModule
     ],
    declarations: [
        RegistrarComponent
    ],
})
export class RegistrarModule {}
