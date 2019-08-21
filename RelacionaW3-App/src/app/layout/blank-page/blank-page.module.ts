import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BlankPageRoutingModule } from './blank-page-routing.module';
import { BlankPageComponent } from './blank-page.component';
import { FormsModule } from '@angular/forms';



@NgModule({
    imports: [
        CommonModule,
        BlankPageRoutingModule,
        FormsModule
    ],
    declarations: [BlankPageComponent]
})
export class BlankPageModule {}
