import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { HealthyWeight } from './healthy-weight.model';

@Injectable({
  providedIn: 'root'
})
export class BMIService {

  constructor(private http: HttpClient) { }

  calculateBMI(weight, height): Observable<number> {
    return this.http.post<number>("/api/calculate-bmi", { weight, height });
  }

  calculateHealthyWeight(height): Observable<HealthyWeight> {
    return this.http.post<HealthyWeight>("/api/calculate-healthy-weight", { height });
  }
}
