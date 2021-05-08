import { Directive, Input, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: 'img[appImgFallback]'
})
export class ImgFallbackDirective {

  @Input()
  appImgFallback: string = 'assets/images.banner1.jpg';

  constructor(private eRef: ElementRef) { }

  @HostListener('error')
  loadFallbackError() {
    const element: HTMLImageElement = this.eRef.nativeElement;
    element.src = this.appImgFallback || 'assets/images.banner1.jpg';
  }

}
