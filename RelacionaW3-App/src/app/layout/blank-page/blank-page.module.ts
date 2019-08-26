import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BlankPageRoutingModule } from './blank-page-routing.module';
import { BlankPageComponent } from './blank-page.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DateTimeFormatPipePipe } from '../_helps/DateTimeFormatPipe.pipe';
import { BsDropdownModule, ModalModule, TooltipModule } from 'ngx-bootstrap';



@NgModule({
    imports: [
        CommonModule,
        BlankPageRoutingModule,
        FormsModule,
        BsDropdownModule.forRoot(),
        TooltipModule.forRoot(),
        ModalModule.forRoot(),
        ReactiveFormsModule
     ],
    declarations: [
        BlankPageComponent,
        DateTimeFormatPipePipe
    ],
})
export class BlankPageModule {}
