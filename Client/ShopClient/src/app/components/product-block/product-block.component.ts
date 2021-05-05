import { Component, Input, OnInit } from '@angular/core';
import { VmAmount } from 'src/app/models/vm/VmAmount';
import { VmHomeProduct } from '../../models/vm/VmHomeProduct';

@Component({
  selector: 'app-product-block',
  templateUrl: './product-block.component.html',
  styleUrls: ['./product-block.component.scss']
})
export class ProductBlockComponent implements OnInit {

  constructor() {
  }

  @Input("productModel")
  public productModel: VmHomeProduct = new VmHomeProduct();

  selectedAmount: VmAmount = new VmAmount;

  ngOnInit(): void {
    this.selectedAmount = this.productModel?.availableAmount[0] ?? new VmAmount();
    console.log(this.selectedAmount);
  }

}
