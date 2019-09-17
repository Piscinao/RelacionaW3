import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { BsDropdownModule, ModalModule, TooltipModule, TabsModule} from 'ngx-bootstrap';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { EventosRoutingModule } from './eventos-routing.module';
import { EventosComponent } from './eventos.component';
import { DateTimeFormatPipePipe } from '../misc/_helps/DateTimeFormatPipe.pipe';
import { NgxMaskModule } from 'ngx-mask';
import { EventoEditComponent } from './eventoEdit/eventoEdit.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ApplicationPipesModuleModule } from '../shared/ApplicationPipesModule/ApplicationPipesModule.module';



@NgModule({
    imports: [
        CommonModule,
        EventosRoutingModule,
        FormsModule,
        NgxMaskModule.forRoot(),
        // AppModule,
        TabsModule.forRoot(),
        BsDatepickerModule.forRoot(),
        BsDropdownModule.forRoot(),
        TooltipModule.forRoot(),
        ApplicationPipesModuleModule,
        ModalModule.forRoot(),
        // DateTimeFormatPipePipe,
        ReactiveFormsModule
     ],
    declarations: [
        EventosComponent,
        // DateTimeFormatPipePipe
        // EventoEditComponent
    ],
    exports: [
        // DateTimeFormatPipePipe
        // EventoEditComponent
    ],
})
export class EventosModule {}
