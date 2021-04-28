import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecentBlogBlockComponent } from './recent-blog-block.component';

describe('RecentBlogBlockComponent', () => {
  let component: RecentBlogBlockComponent;
  let fixture: ComponentFixture<RecentBlogBlockComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecentBlogBlockComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecentBlogBlockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
