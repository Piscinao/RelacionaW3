import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-blank-page',
    templateUrl: './blank-page.component.html',
    styleUrls: ['./blank-page.component.scss']
})
export class BlankPageComponent implements OnInit {

    eventos: any;

    constructor(private http: HttpClient) {}
    //OnInit signifca q executa antes do html ficar pronto
    //pegar informações e atribuir a variaveis q serao utrilizadas dentro do html
    //
    ngOnInit() {
        this.getEventos();
    }

    getEventos(){
        //requisição na api em ajax
        this.eventos = this.http.get('http://localhost:5000/api/values').subscribe(
            response => { this.eventos = response;
            }, error =>{
                console.log(error);
            });
    }


}
