import { Component, OnInit, Input, Output, EventEmitter  } from '@angular/core';
import { ToDoList } from '../Models/ToDoList';
import { ToDoListItem } from '../Models/ToDoListItem';


@Component({
  selector: 'app-todo-list-item',
  templateUrl: './todo-list-item.component.html',
  styleUrls: ['./todo-list-item.component.css']
})
export class TodoListItemComponent implements OnInit {
  @Input() selectedToDoList:ToDoList;
  taskList:ToDoListItem[]=[];
  @Output() onAddTask=new EventEmitter<ToDoListItem>();
  @Output() onTaskComplete=new EventEmitter<ToDoListItem>();
  constructor() { }

  ngOnInit(): void {
  }

  AddTask(taskToAdd:any){
    let task=new ToDoListItem();
    task.isCompleted=false;
    task.name=taskToAdd.taskName;
    task.toDoListId=this.selectedToDoList.id;
    this.onAddTask.emit(task);
  }

  onCompleteTask(task:ToDoListItem){
    task.isCompleted=true;
    this.onTaskComplete.emit(task);
  }

  ngOnChanges(){
    this.taskList=this.selectedToDoList.toDoListItems;
  }

}
