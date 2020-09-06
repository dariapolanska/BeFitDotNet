import { Component, OnInit } from '@angular/core';
import { BMIService } from '../shared/bmi.service';
import { HealthyWeight } from '../shared/healthy-weight.model';

@Component({
  selector: 'app-calculator-bmi',
  templateUrl: './calculator-bmi.component.html',
  styleUrls: ['./calculator-bmi.component.css']
})
export class CalculatorBMIComponent implements OnInit {

  title = 'Calculate your BMI';

  public weight = 50;
  public height = 1.7;
  public BMI = 0;
  public healthyWeight: HealthyWeight = { min: 0, max: 0 };

  constructor(private BMIService: BMIService) { }

  ngOnInit(): void {
  }

  onClickCalculate() {
    this.getBMI(this.weight, this.height);
    this.getHelthyWeight(this.height);
  }

  getBMI(weight, height): void {
    this.BMIService.calculateBMI(weight, height).subscribe(result => this.BMI = result);
  }

  getHelthyWeight(height): void {
    this.BMIService.calculateHealthyWeight(height).subscribe(result => this.healthyWeight = result);
  }
}
