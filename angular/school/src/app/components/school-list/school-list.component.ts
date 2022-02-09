import { Component, Input, OnInit } from '@angular/core';
import School from 'src/app/models/school.model';

@Component({
  selector: 'app-school-list',
  templateUrl: './school-list.component.html',
  styleUrls: ['./school-list.component.scss']
})
export class SchoolListComponent implements OnInit {

  @Input() schoolsInput : School[] = [];
  constructor() { }

  ngOnInit(): void {
  }

}
