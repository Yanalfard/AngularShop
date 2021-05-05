import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'discount'
})
export class DiscountPipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }

  transform(afterDiscount: number, beforeDiscount: number): unknown {
    return Math.round(((beforeDiscount / afterDiscount) - 1) * 100);
  }


}
