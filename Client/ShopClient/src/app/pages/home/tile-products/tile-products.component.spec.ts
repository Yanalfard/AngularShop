import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TileProductsComponent } from './tile-products.component';

describe('TileProductsComponent', () => {
  let component: TileProductsComponent;
  let fixture: ComponentFixture<TileProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TileProductsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TileProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
