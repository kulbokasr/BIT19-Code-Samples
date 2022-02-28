import { Component, OnInit, ViewChild } from '@angular/core';
import Point from 'src/app/models/point-model';
import { StateService } from 'src/app/services/state.service';
import { AngularPaginatorPipe } from 'angular-paginator';
import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'app-points-list',
  templateUrl: './points-list.component.html',
  styleUrls: ['./points-list.component.scss']
})
export class PointsListComponent implements OnInit {

  public points : Point[] = []
  public pageOfItems: Array<any> = [{}];
  constructor(private stateService: StateService) { }

  @ViewChild('paginator') paginator: MatPaginator | undefined;

  ngOnInit(): void {
    this.stateService.getAll();

    this.stateService.points$.subscribe((points) => {
      this.points = points
    })


  }

  public deleteAll(){
    this.stateService.deleteAll(this.points)
  }
  public deletePoint(x: number, y: number){
    let point : Point = {
      x : x,
      y : y
    }
    this.stateService.deletePoint(point)
  }

}
