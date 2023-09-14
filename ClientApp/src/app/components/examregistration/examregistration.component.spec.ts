import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExamregistrationComponent } from './examregistration.component';

describe('ExamregistrationComponent', () => {
  let component: ExamregistrationComponent;
  let fixture: ComponentFixture<ExamregistrationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExamregistrationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExamregistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
