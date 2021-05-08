import { BlogService } from './../../services/blog.service';
import { Component, OnInit } from '@angular/core';
import { VmBlogList } from 'src/app/models/vm/VmBlogList';

@Component({
  selector: 'app-blogs',
  templateUrl: './blogs.component.html',
  styleUrls: ['./blogs.component.scss']
})
export class BlogsComponent implements OnInit {

  constructor(private blogService: BlogService) { }

  blogs: VmBlogList[] = [];

  ngOnInit(): void {
    this.blogService.GetBlogList1().subscribe(i => this.blogs = i);


  }

}
