import { Component, OnInit } from '@angular/core';
import Todo from 'src/app/model/todo.model';
import { TodoService } from 'src/app/services/todo.service';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.scss']
})
export class TodoListComponent implements OnInit {

  constructor(private todoService: TodoService) { }
  public todos : Todo[] = []

  ngOnInit(): void {
    this.todoService.getAllTodos().subscribe((todos) => {
      this.todos = todos;
    });
  }

}
