import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';
@Pipe({
  name: 'formatDateWithMoment',
})
export class FormatDateWithMomentPipe implements PipeTransform {
  transform(value: Date, ...args) {
    return this.formataDataParaExibicao(value, args[0]);
  }

  formataDataParaExibicao(dataEvento, format) : string {
    return moment(dataEvento).format(format);
  }
}