import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tabbed-products',
  templateUrl: './tabbed-products.component.html',
  styleUrls: ['./tabbed-products.component.scss']
})
export class TabbedProductsComponent implements OnInit {

  constructor() { }

  tabIndex: number = 0;

  ngOnInit(): void {
  }

}
