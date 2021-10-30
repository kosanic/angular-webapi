export class StudentInput {

    constructor(studentIme: string, studentPrezime: string, datumRodjenja: Date, brojIndeksa: string) {
        this.studentIme = studentIme;
        this.studentPrezime = studentPrezime;
        this.datumRodjenja = datumRodjenja;
        this.brojIndeksa = brojIndeksa;
    }

    studentIme: string;
    studentPrezime: string;
    datumRodjenja: Date;
    brojIndeksa: string;
}
