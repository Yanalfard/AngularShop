import { Component, Input, OnInit } from '@angular/core';
import { VmHomeBanner } from 'src/app/models/vm/VmHomeBanner';

@Component({
  selector: 'app-shop-banner',
  templateUrl: './shop-banner.component.html',
  styleUrls: ['./shop-banner.component.scss']
})
export class ShopBannerComponent implements OnInit {

  constructor() { }
  @Input('homeBannerModel')
  public homeBannerModel:VmHomeBanner = new VmHomeBanner();
  ngOnInit(): void {
  }
}
