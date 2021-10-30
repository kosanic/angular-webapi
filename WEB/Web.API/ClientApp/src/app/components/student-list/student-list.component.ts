import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/student';
import { StudentInput } from 'src/app/models/student-input';
import { StudentiService } from 'src/app/services/studenti.service';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

  listaStudenata: Student[] = [];

  constructor(
    private studentiService: StudentiService
  ) { }

  ngOnInit(): void {
    this.ucitajKlijente();
  }


  ucitajKlijente() {
    this.studentiService.dohvatiSveStudente().subscribe(
      (result) => {
        console.log('Podaci su poslati');
        console.log(result);

        this.listaStudenata = result;
      }, // next, uvek se pozove kada se okine request
      (err) => {
        console.log('Doslo je do greske prilikom ucitavanja podatakla');
        console.error(err);
      }, // error, u ovaj blok ulazi kada dodje do greske, kada server vrati statuse 400 - 500
      () => {
        console.log('Uspesno ste ucitali podatke');

      }, // success, ulazi za statuse uspesnosti 200-300
    )
  }

  kreirajStudenta() {
    let obj = new StudentInput("Zoran", "Kosanic", new Date(), "13532");
    this.studentiService.kreirajStudenta(obj).subscribe();
  }

  izbrisiStudenta(student: Student) {
    console.log(student);

    this.studentiService.izbrisiStudenta(student.studentId).subscribe(
      ()=>{},
      ()=>{},
      ()=>{
        this.ucitajKlijente();
      },
    );
  }
  izmeniStudenta() {
    let obj = new StudentInput("XXXXX", "XXXXXXXX", new Date(), "XXXX");
    this.studentiService.izmeniStudenta(obj).subscribe();


  }

  // omoguciti otvaranje studenta u posebnom pregledu
  // dodati dugme pored dugmeta za brisanje, klkom na njega odradi redirekciju ja studenta preko prosledjenog id-ja
  // potrebne klase iz angukara
  // Route, Router
  // na beku imas {id} i selektujes iz studenata i dohvatas tog jednog i ispises podatke o njemu
}
