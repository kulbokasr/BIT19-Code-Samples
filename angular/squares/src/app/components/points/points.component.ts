import { Component, OnInit } from '@angular/core';
import Point from 'src/app/models/point-model';
import { PointService } from 'src/app/services/point.service';

@Component({
  selector: 'app-points',
  templateUrl: './points.component.html',
  styleUrls: ['./points.component.scss']
})
export class PointsComponent implements OnInit {


  constructor() { }

  ngOnInit(): void {
  }

}
