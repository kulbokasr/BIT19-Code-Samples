import { Component, OnInit } from '@angular/core';
import Point from 'src/app/models/point-model';
import { StateService } from 'src/app/services/state.service';

@Component({
  selector: 'app-points-list',
  templateUrl: './points-list.component.html',
  styleUrls: ['./points-list.component.scss']
})
export class PointsListComponent implements OnInit {

  public points : Point[] = []
  constructor(private stateService: StateService) { }

  ngOnInit(): void {
    this.stateService.getAll();

    this.stateService.points$.subscribe((points) => {
      this.points = points
    })
  }

  public deleteAll(){
    this.stateService.deleteAll(this.points)
    this.points = []
  }

}
