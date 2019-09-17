
import { Constants } from '../../util/Constants';
import { DatePipe } from '@angular/common';
import { PipeTransform, Pipe } from '@angular/core';


@Pipe({
  name: 'DateTimeFormatPipe'
})
export class DateTimeFormatPipePipe extends DatePipe implements PipeTransform {

  transform(value: any, args?: any): any {
    return super.transform(value, Constants.DATE_FMT);
  }

}
