import { Component, OnInit } from '@angular/core';
import School from 'src/app/models/school.model';
import { SchoolService } from 'src/app/services/school.service';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.scss']
})
export class SchoolComponent implements OnInit {

  public schools : School[] = [];
  constructor(private schoolService : SchoolService) { }

  ngOnInit(): void {
    this.schoolService.getAll().subscribe((schools) => {
      this.schools = schools;
    })
  }

}
