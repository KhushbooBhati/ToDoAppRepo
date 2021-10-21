import { Component, OnInit } from '@angular/core';
import { ToDoList } from '../Models/ToDoList';
import { ToDoListItem } from '../Models/ToDoListItem';
import { TodoService } from '../todo.service';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  toDoLists:ToDoList[]=[];
  selectedToDoList:ToDoList;
  constructor(private todoService:TodoService) { }
  
  ngOnInit(): void {
    this.getTaskList();
  }

  getTaskList(){
    this.todoService.getTaskList().subscribe((data:ToDoList[])=>{
      this.toDoLists=data;
      this.selectedToDoList=this.toDoLists[0];
    });
  }

  onToDoListClick(id:number){
    let index=this.toDoLists.findIndex(x=>x.id==id);
    this.selectedToDoList={...this.toDoLists[index]};
  }

  addTaskForList(task:ToDoListItem){
    this.todoService.addTask(task).subscribe((data:ToDoListItem)=>{
      this.selectedToDoList.toDoListItems=[...this.selectedToDoList.toDoListItems,data]
     let index= this.toDoLists.findIndex(x=>x.id==this.selectedToDoList.id);
     this.toDoLists[index].toDoListItems=[...this.selectedToDoList.toDoListItems];
     this.selectedToDoList={...this.selectedToDoList};
    })  
  }

  onAddList(list:any){
    let todolist=new ToDoList();
    todolist.name=list.listName;
    todolist.toDoListItems=[];
    this.todoService.addList(todolist).subscribe((data:ToDoList)=>{
      this.toDoLists=[...this.toDoLists,data];
      if(this.toDoLists.length==1){
        this.selectedToDoList=this.toDoLists[0];
      }
     })
  }

  onTaskComplete(task:ToDoListItem){
    this.todoService.markTaskAsCompleted(task).subscribe((data:ToDoListItem)=>{
      let index=this.selectedToDoList.toDoListItems.findIndex(x=>x.id==data.id);
      this.selectedToDoList.toDoListItems[index]=data;
      let listIndex=this.toDoLists.findIndex(x=>x.id==this.selectedToDoList.id);
      this.toDoLists[listIndex]=this.selectedToDoList;
      this.toDoLists=[...this.toDoLists];
      alert(JSON.stringify(data));
     })
  }

}
