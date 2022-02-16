import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import Point from '../models/point-model';
import { PointService } from './point.service';

@Injectable({
  providedIn: 'root'
})
export class StateService {

  // We are using this to transmit updated Points
  public points$ = new BehaviorSubject<Point[]>([]);
  private points : Point[] = [];

  constructor(private pointService: PointService) { }

  public getAll() {
    this.pointService.getAll().subscribe((points) => {
      this.points = points;
      this.points$.next(this.points)
    })
  }
  public create(point : Point) {
    this.pointService.create(point).subscribe((point) => {
      this.points.push(point);
      this.points$.next(this.points)
    })
  }
}
