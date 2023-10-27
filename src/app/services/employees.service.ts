import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Employee } from '../models/employee.model';


@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  
  private basePath = 'https://localhost:7054/api/Employees';
  
  constructor(private http: HttpClient) { }

  getAllEmployees(): Observable <Employee[]> {

    return this.http.get<Employee[]>(this.basePath);
  }

  addEmployee(addEmpolyeeRequest: Employee): Observable <Employee> {

    return this.http.post<Employee>(this.basePath, addEmpolyeeRequest);
  }
  }

