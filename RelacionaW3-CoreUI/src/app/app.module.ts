import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { PERFECT_SCROLLBAR_CONFIG } from 'ngx-perfect-scrollbar';
import { PerfectScrollbarConfigInterface } from 'ngx-perfect-scrollbar';

const DEFAULT_PERFECT_SCROLLBAR_CONFIG: PerfectScrollbarConfigInterface = {
  suppressScrollX: true
};

import { AppComponent } from './app.component';

// Import containers
import { DefaultLayoutComponent } from './containers';

import { P404Component } from './views/error/404.component';
import { P500Component } from './views/error/500.component';
import { LoginComponent } from './views/login/login.component';
import { RegisterComponent } from './views/register/register.component';

const APP_CONTAINERS = [
  DefaultLayoutComponent
];

import {
  AppAsideModule,
  AppBreadcrumbModule,
  AppHeaderModule,
  AppFooterModule,
  AppSidebarModule,
} from '@coreui/angular';

// Import routing module
import { AppRoutingModule } from './app.routing';

// Import 3rd party components
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { ChartsModule } from 'ng2-charts';
import {NgxMaskModule} from 'ngx-mask';

import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthInterceptor } from './views/auth/auth.interceptor';
import { EventoService } from './views/misc/_services/evento.service';
import { EventoEditComponent } from './views/eventos/eventoEdit/eventoEdit.component';
import { BsDatepickerModule } from 'ngx-bootstrap';
import { DateTimeFormatPipePipe } from './views/misc/_helps/DateTimeFormatPipe.pipe';
import { EventosComponent } from './views/eventos/eventos.component';
import { SafeHtmlPipe } from './views/misc/_helps/safeHtml.pipe';
import { ApplicationPipesModuleModule } from './views/shared/ApplicationPipesModule/ApplicationPipesModule.module';



@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      progressBar: true,
    }),
    AppRoutingModule,
    AppAsideModule,
    HttpClientModule,
    AppBreadcrumbModule.forRoot(),
    AppFooterModule,
    AppHeaderModule,
    ReactiveFormsModule,
    ApplicationPipesModuleModule,
    FormsModule,
    AppSidebarModule,
    PerfectScrollbarModule,
    BsDropdownModule.forRoot(),
    BsDatepickerModule.forRoot(),
    TabsModule.forRoot(),
    NgxMaskModule.forRoot(),
    // DateTimeFormatPipePipe,
    ChartsModule
  ],
  declarations: [
    AppComponent,
    ...APP_CONTAINERS,
    P404Component,
    // DateTimeFormatPipePipe,
    P500Component,
    // EventosComponent,
    // SafeHtmlPipe,
    EventoEditComponent,
    LoginComponent,
    RegisterComponent
  ],
  // exports: [
  //   DateTimeFormatPipePipe
  // ],

  providers: [
    EventoService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true,
    },
    {
     provide: LocationStrategy,
    useClass: HashLocationStrategy,
    }
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
