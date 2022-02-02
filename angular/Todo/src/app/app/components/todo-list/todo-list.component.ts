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
  public todo : Todo = { } as Todo

  ngOnInit(): void {
    this.todoService.getAllTodos().subscribe((todos) => {
      this.todos = todos;
    });
  }
 onDelete(id:number){
   this.todoService.deleteTodo(id).subscribe(log => console.log('deleted '+id))
 }
 onDeleteLocal(index: number){
   this.todos.splice(index,1)
  }

}
