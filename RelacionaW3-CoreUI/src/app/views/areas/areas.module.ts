import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { BsDropdownModule, ModalModule, TooltipModule, TabsModule} from 'ngx-bootstrap';
import { NgxMaskModule } from 'ngx-mask';
import { NgxCurrencyModule } from 'ngx-currency';
import { ApplicationPipesModuleModule } from '../shared/ApplicationPipesModule/ApplicationPipesModule.module';
import { AreasRoutingModule } from './areas-routing.module';
import { AreasComponent } from './areas.component';
import { AppModule } from '../../app.module';



@NgModule({
    imports: [
        CommonModule,
        AreasRoutingModule,
        FormsModule,
        NgxMaskModule.forRoot(),
        NgxCurrencyModule,
        //  AppModule,
        TabsModule.forRoot(),
        BsDropdownModule.forRoot(),
        TooltipModule.forRoot(),
        ApplicationPipesModuleModule,
        ModalModule.forRoot(),
        ReactiveFormsModule
     ],
    declarations: [
        AreasComponent,
        // DateTimeFormatPipePipe
        // EventoEditComponent
    ],
    exports: [
        // DateTimeFormatPipePipe
        // EventoEditComponent
    ],
})
export class AreasModule {}
