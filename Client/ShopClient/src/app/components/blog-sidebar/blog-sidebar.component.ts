import { Component, OnInit } from '@angular/core';
import { VmBlogLastBlogs } from 'src/app/models/vm/VmBlogLastBlogs';
import { BlogService } from 'src/app/services/blog.service';

@Component({
  selector: 'app-blog-sidebar',
  templateUrl: './blog-sidebar.component.html',
  styleUrls: ['./blog-sidebar.component.scss']
})
export class BlogSidebarComponent implements OnInit {

  constructor(private blogService :BlogService) {}

  public recentBlogs: VmBlogLastBlogs[] = [];

  ngOnInit(): void {
       this.blogService.GetLastBlogList2().subscribe(i => this.recentBlogs = i);

  }

}
