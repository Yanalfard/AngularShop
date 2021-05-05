import { Component, Input, OnInit } from '@angular/core';
import { VmHomeProduct } from 'src/app/models/vm/VmHomeProduct';

@Component({
  selector: 'app-product-block',
  templateUrl: './product-block.component.html',
  styleUrls: ['./product-block.component.scss']
})
export class ProductBlockComponent implements OnInit {

  constructor() { }

  @Input("productModel")
  public productModel: VmHomeProduct = new VmHomeProduct();

  ngOnInit(): void {

  }

}
