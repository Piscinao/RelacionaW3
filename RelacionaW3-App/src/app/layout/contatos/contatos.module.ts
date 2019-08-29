import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContatosRoutingModule } from './contatos-routing.module';
import { ContatosComponent } from './contatos.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DateTimeFormatPipePipe } from '../_helps/DateTimeFormatPipe.pipe';
import { BsDropdownModule, ModalModule, TooltipModule} from 'ngx-bootstrap';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
    imports: [
        CommonModule,
        ContatosRoutingModule,
        FormsModule,
        BsDatepickerModule.forRoot(),
        BsDropdownModule.forRoot(),
        TooltipModule.forRoot(),
        ModalModule.forRoot(),
        ReactiveFormsModule
     ],
    declarations: [
        ContatosComponent,
        DateTimeFormatPipePipe
    ],
})
export class ContatosModule {}
