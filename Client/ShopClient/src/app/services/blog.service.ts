import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { VmBlogLastBlogs } from '../models/vm/VmBlogLastBlogs';
import { VmBlogList } from '../models/vm/VmBlogList';
import { VmHomeBanner } from '../models/vm/VmHomeBanner';
import { VmKeyword } from '../models/vm/VmKeyword';
import { VmMonthlyBlogs } from '../models/vm/VmMonthlyBlogs';

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  constructor(private http: HttpClient) { }

  readonly controller: string = '/Blog';
  readonly pref: string = environment.apiDomain + '/api' + this.controller;

  GetBlogList1(): Observable<VmBlogList[]> {
    return this.http.get<VmBlogList[]>(this.pref + '/GetBlogList1');
  }
  GetLastBlogList2(): Observable<VmBlogLastBlogs[]>{
    return this.http.get<VmBlogLastBlogs[]>(this.pref + '/GetLastBlogList2');
  }
  GetBlogsByDate3(): Observable<VmMonthlyBlogs[]>{
    return this.http.get<VmMonthlyBlogs[]>(this.pref + '/GetBlogsByDate3');
  }
  GetBanner4(): Observable<VmHomeBanner[]>{
    return this.http.get<VmHomeBanner[]>(this.pref + '/GetBanner4');
  }
  GetKeywords5(): Observable<VmKeyword[]>{
    return this.http.get<VmKeyword[]>(this.pref + '/GetKeywords5');
  }

}
