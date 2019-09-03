import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LayoutRoutingModule } from './layout-routing.module';
import { LayoutComponent } from './layout.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { HeaderComponent } from './components/header/header.component';
import { ContatosComponent } from './contatos/contatos.component';
import { UsuarioComponent } from './usuario/usuario.component';
import { DateTimeFormatPipePipe } from './_helps/DateTimeFormatPipe.pipe';
import { BsDropdownModule, ModalModule, TooltipModule} from 'ngx-bootstrap';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BlankPageComponent } from './blank-page/blank-page.component';
import { RegistrarComponent } from './usuario/registrar/registrar.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { PageHeaderModule } from '../shared/modules/page-header/page-header.module';

@NgModule({
    imports: [
        CommonModule,
        LayoutRoutingModule,
        TranslateModule,
        FormsModule,
        PageHeaderModule,
        BsDatepickerModule.forRoot(),
        BsDropdownModule.forRoot(),
        TooltipModule.forRoot(),
        ModalModule.forRoot(),
        ReactiveFormsModule,
        NgbDropdownModule
    ],
    declarations: [
        LayoutComponent,
        ContatosComponent,
        RegistrarComponent,
        PalestrantesComponent,
        DateTimeFormatPipePipe,
       UsuarioComponent,
        BlankPageComponent,
        SidebarComponent,
        HeaderComponent]
})
export class LayoutModule {}
