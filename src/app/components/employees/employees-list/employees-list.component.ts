import { Component, OnInit } from '@angular/core';
import { Subscriber } from 'rxjs';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

 public Employees : any;
 imageBaseUrl = EmployeesService+"C:/Users/vaio/Desktop/images";

  constructor(private services : EmployeesService){}

  ngOnInit() : void {

    this.getAllEmployees();
  }

  private getAllEmployees(): void {
    this.services.getAllEmployees().subscribe(result => {
         this.Employees = result;
        });
    }  }


 