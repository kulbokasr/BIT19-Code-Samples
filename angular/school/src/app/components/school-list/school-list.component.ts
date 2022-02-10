import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import School from 'src/app/models/school.model';
import Student from 'src/app/models/student.model';

@Component({
  selector: 'app-school-list',
  templateUrl: './school-list.component.html',
  styleUrls: ['./school-list.component.scss']
})
export class SchoolListComponent implements OnInit {

  @Input() schoolsInput : School[] = [];
  @Input() studentInput : Student[] = [];
  @Output() removeChoolEvent = new EventEmitter<number>();
  constructor() { }

  ngOnInit(): void {
  }

  public removeSchool(schoolId: number){
    this.removeChoolEvent.emit(schoolId);
  }

}
