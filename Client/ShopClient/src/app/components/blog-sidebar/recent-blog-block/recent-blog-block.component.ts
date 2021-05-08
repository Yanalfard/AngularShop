import { Component, Input, OnInit } from '@angular/core';
import { VmBlogLastBlogs } from 'src/app/models/vm/VmBlogLastBlogs';

@Component({
  selector: 'app-recent-blog-block',
  templateUrl: './recent-blog-block.component.html',
  styleUrls: ['./recent-blog-block.component.scss']
})
export class RecentBlogBlockComponent implements OnInit {

  constructor() { }

@Input('recentBlogModel')
public recentBlogModel:VmBlogLastBlogs =new VmBlogLastBlogs();

  ngOnInit(): void {
  }

}
