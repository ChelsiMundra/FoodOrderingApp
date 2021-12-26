import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ActivatedRoute } from '@angular/router'
import { SingleResComponent } from './single-res.component';

describe('SingleResComponent', () => {
  let component: SingleResComponent;
  let fixture: ComponentFixture<SingleResComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleResComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleResComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
