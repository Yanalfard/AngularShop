import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-tile',
  templateUrl: './product-tile.component.html',
  styleUrls: ['./product-tile.component.scss']
})
export class ProductTileComponent implements OnInit {

  constructor() { }

  temp_id: number = 0;

  ngOnInit(): void {
    this.temp_id = Math.ceil(Math.random() * 12);
  }

}
