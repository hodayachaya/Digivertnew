import { EmailValidator } from "@angular/forms";


export interface register {
    idUser: Text;
    userName: string;
    password: Text;

    FirstName: string;
    LastName: string;
    Phon: string;
    email: EmailValidator;
}
