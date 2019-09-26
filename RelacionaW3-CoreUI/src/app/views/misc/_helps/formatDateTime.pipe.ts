import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';

@Pipe({
   name: 'formatDateTime'
})
export class FormatDateTime implements PipeTransform {
   transform(date: any, args?: any): any {
     const d = new Date(date);
     return moment(d).format('MM/dd/yyyy');

   }
}
