import { Component, OnInit } from '@angular/core';
import { observable, Observable } from 'rxjs';
import { VmHomeProduct } from 'src/app/models/vm/VmHomeProduct';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-tabbed-products',
  templateUrl: './tabbed-products.component.html',
  styleUrls: ['./tabbed-products.component.scss']
})
export class TabbedProductsComponent implements OnInit {

  constructor(private homeService: HomeService) { }

  // newProducts: Observable<VmHomeProduct[]> = new Observable<VmHomeProduct[]>();
  // mostRatedProducts: Observable<VmHomeProduct[]> = new Observable<VmHomeProduct[]>();

  newProducts: VmHomeProduct[] = [];
  mostRatedProducts: VmHomeProduct[] = [];

  ngOnInit(): void {
    // this.newProducts = this.homeService.GetNewProducts2();
    // this.mostRatedProducts = this.homeService.GetMostRatedProducts3();

    this.homeService.GetNewProducts2().subscribe(i => this.newProducts = i);
    this.homeService.GetMostRatedProducts3().subscribe(i => this.mostRatedProducts = i);
  }

}
