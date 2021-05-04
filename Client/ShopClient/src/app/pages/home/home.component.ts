import { Component, OnInit } from '@angular/core';
import { VmHomeBanner } from 'src/app/models/vm/VmHomeBanner';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private homeService: HomeService) { }

  bannerOne: VmHomeBanner = new VmHomeBanner();
  bannerTwo: VmHomeBanner = new VmHomeBanner();

  ngOnInit(): void {
    this.homeService.GetBanners4().subscribe((i: VmHomeBanner[]) => {
      i[0] = this.bannerOne;
      i[1] = this.bannerTwo;
    });
  }

}
