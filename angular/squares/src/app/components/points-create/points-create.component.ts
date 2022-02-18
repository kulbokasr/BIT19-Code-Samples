import { Component, OnInit } from '@angular/core';
import Point from 'src/app/models/point-model';
import { PointService } from 'src/app/services/point.service';
import { StateService } from 'src/app/services/state.service';

@Component({
  selector: 'app-points-create',
  templateUrl: './points-create.component.html',
  styleUrls: ['./points-create.component.scss']
})
export class PointsCreateComponent implements OnInit {

  public pointCreate: Point = {} as Point
  public resultFile: File = {} as File
  constructor(private stateService: StateService, private pointService : PointService) { }

  ngOnInit(): void {
 
  }

  public createPoint(){
    let point : Point = {
      x : this.pointCreate.x,
      y : this.pointCreate.y
    }
    this.stateService.create(point)
  }
  public file : any

  // public createPointFromFile(file: any){
  //   fetch(file)
  // .then(response => response.text())
  // .then(data => {
  // 	// Do something with your data
  // 	console.log(data);
  // });
  //   // var rawFile = new XMLHttpRequest();
  //   // rawFile.open("GET", file, false);
  //   // rawFile.onreadystatechange = function ()
  //   // {
  //   //     if(rawFile.readyState === 4)
  //   //     {
  //   //         if(rawFile.status === 200 || rawFile.status == 0)
  //   //         {
  //   //             var allText = rawFile.responseText;
  //   //             alert(allText);
  //   //         }
  //   //     }
  //   // }
  //   // rawFile.send(null);
  // }

  getFile() {
    this.pointService.getFile('C:/Users/kulbo/projects/.Net-Course/angular/squares/readfromme.txt').subscribe(file => {
      this.resultFile = file;
      console.log(this.resultFile);
    });
  }

}
