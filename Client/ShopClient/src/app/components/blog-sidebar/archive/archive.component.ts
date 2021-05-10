import { Component, Input, OnInit } from '@angular/core';
import { VmMonthlyBlogs } from 'src/app/models/vm/VmMonthlyBlogs';

@Component({
  selector: 'app-blog-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {

  constructor() { }

  @Input('monthlyBlogModel')
  public monthlyBlogModel:VmMonthlyBlogs =new VmMonthlyBlogs();

  ngOnInit(): void {
    console.log(this.monthlyBlogModel);
  }

}
