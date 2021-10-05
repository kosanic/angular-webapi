import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Student } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentiService {

  apiUrl = environment.apiUrl + "/studenti";
  constructor(
    private http: HttpClient
  ) { }


  dohvatiSveStudente(): Observable<Student[]> {
    return this.http.get<Student[]>(this.apiUrl);
  }
}
