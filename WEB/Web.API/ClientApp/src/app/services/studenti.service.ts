import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Student } from '../models/student';
import { StudentInput } from '../models/student-input';

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

  kreirajStudenta(input: StudentInput): Observable<number> {
    return this.http.post<number>(this.apiUrl, input);
  }

  izbrisiStudenta(studentid: number): Observable<any>{
    return this.http.delete<any>(this.apiUrl + "/" + studentid);
  }
  izmeniStudenta(input: StudentInput): Observable<any>{
    return this.http.post<any>(this.apiUrl,input);
  }
}
