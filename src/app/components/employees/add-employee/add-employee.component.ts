import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscriber } from 'rxjs';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']

})

export class AddEmployeeComponent implements OnInit {

  addEmployeeRequest : Employee = {

    id:'',
    name:'', 
    email:'',
    phone: 0,
    salary: 0,
    department:'',
    img:''
  };

 public Employees : any;

  
constructor( private services : EmployeesService ) {
  
}
ngOnInit(): void{
    this.addEmployee();
}

addEmployee()
{
  this.services.addEmployee(this.addEmployeeRequest).subscribe({ 
    next: (Employee) =>   {
console.log(Employee)
    }
    });
    
  }
}