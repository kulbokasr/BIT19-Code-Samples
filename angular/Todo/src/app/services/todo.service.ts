import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Todo from '../model/todo.model';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  constructor(private httpclient : HttpClient) { }

  public getAllTodos(): Observable<Todo[]> {
    return this.httpclient.get<Todo[]>("https://jsonplaceholder.typicode.com/todos")
  }
  
}
