import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { ApplicationPipesModuleComponent } from './ApplicationPipesModule.component';
import { DateTimeFormatPipePipe } from '../../misc/_helps/DateTimeFormatPipe.pipe';
import { SafeHtmlPipe } from '../../misc/_helps/safeHtml.pipe';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    ApplicationPipesModuleComponent,
    SafeHtmlPipe,
    DateTimeFormatPipePipe
  ],
  exports: [
    DateTimeFormatPipePipe,
    SafeHtmlPipe
  ]
})
export class ApplicationPipesModuleModule { }
