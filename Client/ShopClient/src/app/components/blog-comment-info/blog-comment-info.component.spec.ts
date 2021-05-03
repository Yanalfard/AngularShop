import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BlogCommentInfoComponent } from './blog-comment-info.component';

describe('BlogCommentInfoComponent', () => {
  let component: BlogCommentInfoComponent;
  let fixture: ComponentFixture<BlogCommentInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BlogCommentInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BlogCommentInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
