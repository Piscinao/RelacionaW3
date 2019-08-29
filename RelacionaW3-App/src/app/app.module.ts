import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { LanguageTranslationModule } from './shared/modules/language-translation/language-translation.module';

import { EventoService } from './layout/_services/evento.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthGuard } from './shared';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';




@NgModule({
   imports: [
      CommonModule,
      BrowserModule,
      BrowserAnimationsModule,
      HttpClientModule,
      LanguageTranslationModule,
      ToastrModule.forRoot(),
      AppRoutingModule
   ],
   declarations: [
      AppComponent
   ],
   providers: [
      AuthGuard,
      EventoService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule {}
