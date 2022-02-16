import { Component, OnInit } from '@angular/core';
import Point from 'src/app/models/point-model';
import { PointService } from 'src/app/services/point.service';

@Component({
  selector: 'app-points',
  templateUrl: './points.component.html',
  styleUrls: ['./points.component.scss']
})
export class PointsComponent implements OnInit {
  public points : Point[] = [];
  public error: any;

  constructor(private pointService: PointService) { }

  ngOnInit(): void {
    this.pointService.getAll().subscribe((points) => {
      this.points = points
    })
  }

  public createPoint(pointEvent : any): void {
    this.error = null;
    this.pointService.create(pointEvent).subscribe({
      next:(point) => {
      this.points.push(point)},
      
      error:(err) => {
        console.log(err.error);
        this.error = err.error;
    }});
  }

}
