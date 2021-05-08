import { Component, OnInit } from '@angular/core';
import { VmBlogLastBlogs } from 'src/app/models/vm/VmBlogLastBlogs';
import { VmHomeBanner } from 'src/app/models/vm/VmHomeBanner';
import { VmKeyword } from 'src/app/models/vm/VmKeyword';
import { VmMonthlyBlogs } from 'src/app/models/vm/VmMonthlyBlogs';
import { BlogService } from 'src/app/services/blog.service';

@Component({
  selector: 'app-blog-sidebar',
  templateUrl: './blog-sidebar.component.html',
  styleUrls: ['./blog-sidebar.component.scss']
})
export class BlogSidebarComponent implements OnInit {

  constructor(private blogService :BlogService) {}

  public recentBlogs: VmBlogLastBlogs[] = [];
  public monthlyBlogs: VmMonthlyBlogs[] = [];
  public homeBanners: VmHomeBanner[]=[];
  public keywords: VmKeyword[]=[];

  ngOnInit(): void {
       this.blogService.GetLastBlogList2().subscribe(i => this.recentBlogs = i);
       this.blogService.GetBlogsByDate3().subscribe(j =>this.monthlyBlogs = j);
       this.blogService.GetBanner4().subscribe(k =>this.homeBanners = k );
       this.blogService.GetKeywords5().subscribe(l => this.keywords = l);
  }

}
