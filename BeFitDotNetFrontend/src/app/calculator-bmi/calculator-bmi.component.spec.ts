import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculatorBMIComponent } from './calculator-bmi.component';

describe('CalculatorBMIComponent', () => {
  let component: CalculatorBMIComponent;
  let fixture: ComponentFixture<CalculatorBMIComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CalculatorBMIComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CalculatorBMIComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
