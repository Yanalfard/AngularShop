import { VmBlogList } from './../../models/vm/VmBlogList';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-blog-block',
  templateUrl: './blog-block.component.html',
  styleUrls: ['./blog-block.component.scss']
})
export class BlogBlockComponent implements OnInit {

  @Input("blogModel")
  public blogModel: VmBlogList = new VmBlogList();

  constructor() { }

  ngOnInit(): void {
  }

}
