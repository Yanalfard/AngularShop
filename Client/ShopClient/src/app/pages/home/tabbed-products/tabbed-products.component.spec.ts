import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabbedProductsComponent } from './tabbed-products.component';

describe('TabbedProductsComponent', () => {
  let component: TabbedProductsComponent;
  let fixture: ComponentFixture<TabbedProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TabbedProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TabbedProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
