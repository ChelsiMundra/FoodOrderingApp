import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowResComponent } from './show-res.component';

describe('ShowResComponent', () => {
  let component: ShowResComponent;
  let fixture: ComponentFixture<ShowResComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowResComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowResComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
