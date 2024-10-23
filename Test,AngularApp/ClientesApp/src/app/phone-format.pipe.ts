// phone-format.pipe.ts
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'phoneFormat',
  standalone: true 
})
export class PhoneFormatPipe implements PipeTransform {
  transform(value: string): string {
    if (!value) return '';
    return value.replace(/(\+56)(\d{1})(\d{4})(\d{4})/, '$1$2 $3 $4');
  }
}
