import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import SchoolCreate from '../models/school-create.model';
import School from '../models/school.model';

@Injectable({
  providedIn: 'root'
})
export class SchoolService {

  constructor(private httpClient: HttpClient) { }

  public getAll() : Observable<School[]> {
    return this.httpClient.get<School[]>('https://localhost:44304/School')
  }
  public create(schoolCreate : SchoolCreate) : Observable<School> {
    return this.httpClient.post<School>('https://localhost:44304/School', schoolCreate)
  }

}
