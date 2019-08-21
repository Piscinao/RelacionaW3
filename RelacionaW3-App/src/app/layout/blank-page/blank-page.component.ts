import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-blank-page',
    templateUrl: './blank-page.component.html',
    styleUrls: ['./blank-page.component.scss']
})
export class BlankPageComponent implements OnInit {

    //Encapsulamento da propriedade
    //n acessa do lado de fora acessa o get ou o set da propriedade
    _filtroLista: string;
    get filtroLista(): string{
        return this._filtroLista;
    }
    set filtroLista(value: string){
        this._filtroLista = value;
        this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
    }

    eventosFiltrados: any = [];
    eventos: any = [];
    imagemLargura: number = 50;
    imagemMargem: number = 2;
    mostrarImagem = false;

    constructor(private http: HttpClient) {}
    //OnInit signifca q executa antes do html ficar pronto
    //pegar informações e atribuir a variaveis q serao utrilizadas dentro do html
    //
    ngOnInit() {
        this.getEventos();
    }

    alterarImagem(){
        this.mostrarImagem = !this.mostrarImagem;
    }

    filtrarEventos(filtrarPor: string): any {
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.eventos.filter(
            evento => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
        )
    }


    getEventos(){
        //requisição na api em ajax
        this.eventos = this.http.get('http://localhost:5000/api/values').subscribe(
            response => { this.eventos = response;
                this.eventosFiltrados = this.eventos;
            }, error =>{
                console.log(error);
            });
           
    }


}
