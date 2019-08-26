import { Component, OnInit, TemplateRef } from '@angular/core';
import { EventoService } from 'src/app/layout/_services/evento.service';
import { Evento } from 'src/app/layout/_models/Evento';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import Swal from 'sweetalert2';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
    selector: 'app-blank-page',
    templateUrl: './blank-page.component.html',
    styleUrls: ['./blank-page.component.scss']
})
export class BlankPageComponent implements OnInit {

    eventosFiltrados: Evento [];
    eventos: Evento[];
    imagemLargura: number = 50;
    imagemMargem: number = 2;
    mostrarImagem = false;
    modalRef: BsModalRef;
    registerForm: FormGroup;

    //Encapsulamento da propriedade
    //n acessa do lado de fora acessa o get ou o set da propriedade
    _filtroLista = '';

    constructor(
        private eventoService: EventoService
      , private modalService: BsModalService
        ) {}

    openModal(template: TemplateRef<any>) {
        this.modalRef = this.modalService.show(template);
    }

    openModalDelete(){
        Swal.fire({
            title: 'Você tem certeza?',
            text: "Essa ação não poderá ser desfeita!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: 'Sim, excluir!'
          }).then((result) => {
            if (result.value) {
              Swal.fire(
                'Excluído!',
                'O dado fui excluído com sucesso.',
                'success'
              )
            }
          })
    }

    showModal(){
        Swal.fire({
            title: 'Error!',
            text: 'Olá Mundo',
            type: 'error'
        });
    }

    get filtroLista(): string {
        return this._filtroLista;
    }
    set filtroLista(value: string) {
        this._filtroLista = value;
        this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
    }
    //OnInit signifca q executa antes do html ficar pronto
    //pegar informações e atribuir a variaveis q serao utrilizadas dentro do html
    //
    ngOnInit() {
        this.validation();
        this.getEventos();
    }

    alterarImagem(){
        this.mostrarImagem = !this.mostrarImagem;
    }

    validation(){
        this.registerForm = new FormGroup({
            tema: new FormControl ('', 
            [Validators.required, Validators.minLength(4), Validators.maxLength(50)]),
            local: new FormControl ('', Validators.required),
            dataEvento: new FormControl ('', Validators.required),
            imagemURL: new FormControl ('', Validators.required),
            qtdPessoas: new FormControl ('',
            [Validators.required, Validators.max(120000)]),
            telefone: new FormControl ('', Validators.required),
            email: new FormControl ('',
            [Validators.required, Validators.email])
        });

    }

    salvarAlteracao(){

    }

    filtrarEventos(filtrarPor: string): Evento[] {
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.eventos.filter(
            evento => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
        )
    }


    getEventos(){
        //requisição na api em ajax
        this.eventoService.getAllEvento().subscribe(
            (_eventos: Evento[]) => { 
                this.eventos = _eventos;
                this.eventosFiltrados = this.eventos;
                console.log(_eventos);
            }, error =>{
                console.log(error);
            });
    }


}
