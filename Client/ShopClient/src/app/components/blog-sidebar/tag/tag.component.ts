import { Component, Input, OnInit } from '@angular/core';
import { VmKeyword } from 'src/app/models/vm/VmKeyword';

@Component({
  selector: 'app-blog-tag',
  templateUrl: './tag.component.html',
  styleUrls: ['./tag.component.scss']
})
export class TagComponent implements OnInit {

  constructor() { }

  @Input('keywordModel')
  public keywordModel:VmKeyword[] =[new VmKeyword()];

  ngOnInit(): void {
    console.log(this.keywordModel);
  }

}
