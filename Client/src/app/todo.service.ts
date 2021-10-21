import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { ToDoListItem } from './Models/ToDoListItem';
import { ToDoList } from './Models/ToDoList';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  baseUrl:string="https://localhost:44340/api/"

  constructor(private http:HttpClient) { }


  getTaskList(){
    return this.http.get(`${this.baseUrl}ToDo`);
  }

  addTask(task:ToDoListItem){
    return this.http.post(`${this.baseUrl}ToDoItem`,task);
  }

  addList(list:ToDoList){
    return this.http.post(`${this.baseUrl}ToDo`,list);
  }

  markTaskAsCompleted(task:ToDoListItem){
    return this.http.put(`${this.baseUrl}ToDoItem/${task.id}`,task);
  }
}
