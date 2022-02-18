import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Point from '../models/point-model';

@Injectable({
  providedIn: 'root'
})
export class PointService {

  constructor(private httpClient: HttpClient) { }
  public getAll() : Observable<Point[]> {
    return this.httpClient.get<Point[]>('https://localhost:44393/point')
  }
  public create(point : Point) : Observable<Point> {
    return this.httpClient.post<Point>('https://localhost:44393/point', point)
  }
  public getFile(url: string): Observable<File> {
    return this.httpClient.get<File>(url);
  }
  public deleteAll(points : Point[]) : Observable<Point[]> {
    return this.httpClient.delete<Point[]>('https://localhost:44393/point',{ body: points })
  }
}
