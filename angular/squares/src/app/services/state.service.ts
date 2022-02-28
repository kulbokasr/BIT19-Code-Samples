import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, filter } from 'rxjs';
import Point from '../models/point-model';
import { PointService } from './point.service';

@Injectable({
  providedIn: 'root'
})
export class StateService {

  // We are using this to transmit updated Points
  public points$ = new BehaviorSubject<Point[]>([]);
  private points : Point[] = [];
  private deletePointsTemp : Point[] = [];
 

  constructor(private pointService: PointService) { }

  public getAll() {
    this.pointService.getAll().subscribe((points) => {
      this.points = points;
      this.points$.next(this.points)
    })
  }
  public create(point : Point) : any { 

    this.pointService.create(point).subscribe(point => {
      this.points.push(point);
      this.points$.next(this.points)},
      (err: HttpErrorResponse) => {
        console.log(err.error)
      }
    )}
    public deleteAll(points : Point[]){
      this.pointService.deleteAll(points).subscribe()
      this.points = [];
      this.points$.next(this.points)
    }
    public deletePoint(pointToDelete : Point){
      this.deletePointsTemp.push(pointToDelete)
      this.pointService.deleteAll(this.deletePointsTemp).subscribe()
      this.points.forEach((point, index) =>{
        if(point.x == pointToDelete.x && point.y == pointToDelete.y) { 
          this.points.splice(index,1)
        } 
      }
      );
      this.points$.next(this.points)
      this.deletePointsTemp = []
    }
}
   

