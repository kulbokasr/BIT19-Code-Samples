import { Component, OnInit } from '@angular/core';
import School from 'src/app/models/school.model';
import StudentCreate from 'src/app/models/student-create.model';
import Student from 'src/app/models/student.model';
import { SchoolService } from 'src/app/services/school.service';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.scss']
})
export class StudentComponent implements OnInit {

  constructor(private studentService : StudentService, private schoolService : SchoolService) { }
  public students : Student[] = [];
  public schools : School[] = []

  ngOnInit(): void {
    this.studentService.getAll().subscribe((students) => {
      this.students = students
    })
    this.schoolService.getAll().subscribe((schools) => {
      this.schools = schools
    })
  }

  public removeStudent(removeStudentEvent: any) : void {
    let id = removeStudentEvent
    this.studentService.delete(id).subscribe()
    this.students = this.students.filter(s => s.id != id);
  }

  public createStudent(studentCreateEvent: any) : void {
    let createStudent : StudentCreate = studentCreateEvent
    this.studentService.create(createStudent).subscribe((student) => {
      this.students.push(student)
    })
  }



}
