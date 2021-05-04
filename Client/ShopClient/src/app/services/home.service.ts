import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { VmAddress } from '../models/vm/VmAddress';
import { VmFooter } from '../models/vm/VmFooter';
import { VmHomeBanner } from '../models/vm/VmHomeBanner';
import { VmHomeBannerNoText } from '../models/vm/VmHomeBannerNoText';
import { VmHomeProduct } from '../models/vm/VmHomeProduct';
import { VmHomeProductSpecial } from '../models/vm/VmHomeProductSpecial';
import { VmHomeSlider } from '../models/vm/VmHomeSlider';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  readonly controller: string = '/Home';
  readonly pref: string = environment.apiDomain + '/api' + this.controller;

  constructor(private http: HttpClient) { }

  GetSliders1(): Observable<VmHomeSlider[]> {
    return this.http.get<VmHomeSlider[]>(this.pref + '/GetSliders1');
  }

  GetNewProducts2(): Observable<VmHomeProduct[]> {
    return this.http.get<VmHomeProduct[]>(this.pref + '/GetNewProducts2');
  }

  GetMostRatedProducts3(): Observable<VmHomeProduct[]> {
    return this.http.get<VmHomeProduct[]>(this.pref + '/GetMostRatedProducts3');
  }

  GetBanners4(): Observable<VmHomeBanner[]> {
    return this.http.get<VmHomeBanner[]>(this.pref + '/GetBanners4');
  }

  GetDiscountedProducts5(): Observable<VmHomeProduct[]> {
    return this.http.get<VmHomeProduct[]>(this.pref + '/GetDiscountedProducts5');
  }

  GetBannerAfterProducts6(): Observable<VmHomeBannerNoText[]> {
    return this.http.get<VmHomeBannerNoText[]>(this.pref + '/GetBannerAfterProducts6');
  }

  GetProductsAfterBanners7(): Observable<VmHomeProductSpecial[]> {
    return this.http.get<VmHomeProductSpecial[]>(this.pref + '/GetProductsAfterBanners7');
  }

  GetFooter(): Observable<VmFooter> {
    return this.http.get<VmFooter>(this.pref + '/GetFooter');
  }
}
