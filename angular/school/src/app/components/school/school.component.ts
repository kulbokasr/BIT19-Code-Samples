import { Component, OnInit } from '@angular/core';
import SchoolCreate from 'src/app/models/school-create.model';
import School from 'src/app/models/school.model';
import Student from 'src/app/models/student.model';
import { SchoolService } from 'src/app/services/school.service';
import { StudentService } from 'src/app/services/student.service';
import { retry, catchError } from 'rxjs/operators';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.scss']
})
export class SchoolComponent implements OnInit {

  public schools : School[] = [];
  public students : Student[] = [];
  public error: any; 
  constructor(private studentService : StudentService, private schoolService : SchoolService) { }
  
  ngOnInit(): void {
    this.schoolService.getAll().subscribe((schools) => {
      this.schools = schools;
    })
    this.studentService.getAll().subscribe((students) => {
      this.students = students
    })
  }

  public removeSchool(removeSchoolEvent: any) : void {
    let id = removeSchoolEvent
    this.schoolService.delete(id).subscribe()
    this.schools = this.schools.filter(s => s.id != id);
    this.students = this.students.filter(s => s.schoolId !=id)
  }
  public createSchool(schoolCreateEvent: any) : void {
    this.error = null;
    let createSchool: SchoolCreate = {
      name: schoolCreateEvent
    }
    this.schoolService.create(createSchool).subscribe({
      next:(school) => {
      this.schools.push(school)},
      
      error:(err) => {
        console.log(err.error);
        this.error = err.error;
    }});
  }

}
