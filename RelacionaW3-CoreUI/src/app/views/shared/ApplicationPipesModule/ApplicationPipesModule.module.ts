import { NgModule} from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { ApplicationPipesModuleComponent } from './ApplicationPipesModule.component';

import { SafeHtmlPipe } from '../../misc/_helps/safeHtml.pipe';
import { registerLocaleData } from '@angular/common';
import localeBr from '@angular/common/locales/pt';
import { FormatDateWithMomentPipe } from '../../misc/_helps/formatDateWithMoment.pipe';
import { FormatDateTime } from '../../misc/_helps/formatDateTime.pipe';
import { DateTimeFormatPipePipe } from '../../misc/_helps/DateTimeFormatPipe.pipe';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    ApplicationPipesModuleComponent,
    SafeHtmlPipe,
    DateTimeFormatPipePipe

    // DatePipe
    // FormatDateWithMomentPipe
  ],
  exports: [
    DateTimeFormatPipePipe,
    // FormatDateWithMomentPipe,
    // FormatDateTime,
    // DatePipe,
    SafeHtmlPipe
  ]
})
export class ApplicationPipesModuleModule { }
