import { Component, OnInit, TemplateRef } from '@angular/core';
import { EventoService } from 'src/app/layout/_services/evento.service';
import { Evento } from 'src/app/layout/_models/Evento';
import { BsModalService } from 'ngx-bootstrap';
import Swal from 'sweetalert2';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { defineLocale, BsLocaleService, ptBrLocale} from'ngx-bootstrap';
import { ToastrService } from 'ngx-toastr';
defineLocale('pt-br', ptBrLocale);

@Component({
    selector: 'app-blank-page',
    templateUrl: './blank-page.component.html',
    styleUrls: ['./blank-page.component.scss']
})
export class BlankPageComponent implements OnInit {

    eventosFiltrados: Evento [];
    eventos: Evento[];
    evento: Evento;
    modoSalvar = 'post';

    imagemLargura: number = 50;
    imagemMargem: number = 2;
    mostrarImagem = false;
    registerForm: FormGroup;
    bodyDeletarEvento = '';
    file: File;

    dataAtual: string;

    // Encapsulamento da propriedade
    // n acessa do lado de fora acessa o get ou o set da propriedade
    _filtroLista = '';
    fileNameToUpdate: string;

    constructor(
        private eventoService: EventoService
      , private modalService: BsModalService
      , private fb: FormBuilder
      , private localeService: BsLocaleService
      , private toastr: ToastrService
        ) {
            this.localeService.use('pt-br');

        }

    openModal(template: any) {
        this.registerForm.reset();
        template.show();
    }

    openModalDelete(evento: Evento) {
        Swal.fire({
            title: 'Você tem certeza?',
            text: 'Essa ação, não poderá ser desfeita!',
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: 'Sim, excluir!'
          }).then((result) => {
            if (result.value) {
                this.evento = evento;
                this.eventoService.deleteEvento(this.evento.id).subscribe(
                    () => {
                        this.getEventos();
                    }, error => {
                        console.log(error);
                    }
                );
              Swal.fire(
                'Excluído!',
                'O dado fui excluído com sucesso.',
                'success'
              )
            }
          });
    }
    showModalRegistro() {
        Swal.fire({
            title: 'Feito!',
            text: 'O dado foi salvo com sucesso.',
            type: 'success'
        });
    }

    showModalAtualizar() {
        Swal.fire({
            title: 'Feito!',
            text: 'Os dados foram atualizados com sucesso.',
            type: 'success'
        });
    }

    showModalErro(){
        Swal.fire({
            title: 'Erro!',
            text: 'Algum problema ocorreu contate o administrador do sistema.',
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
    // OnInit signifca q executa antes do html ficar pronto
    // pegar informações e atribuir a variaveis q serao utrilizadas dentro do html
    editarEvento(evento: Evento, template: any) {
        //this.toastr.success('Hello World', 'Toast Teste');
        this.modoSalvar = 'put';
        this.openModal(template);
        // carrega dado atual
        this.evento = Object.assign({}, evento);
        this.fileNameToUpdate = evento.imagemURL.toString();
        this.evento.imagemURL = '';
        // preenche o formulario
        this.registerForm.patchValue(this.evento);

    }

    novoEvento(template: any) {
        this.modoSalvar = 'post';
        this.openModal(template);
    }

    ngOnInit() {
        this.validation();
        this.getEventos();
    }

    alterarImagem() {
        this.mostrarImagem = !this.mostrarImagem;
    }

    validation() {
        this.registerForm = this.fb.group({
            tema: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
            local: ['', Validators.required],
            dataEvento: ['', Validators.required],
            imagemURL: ['', Validators.required],
            qtdPessoas: ['', [Validators.required, Validators.max(120000)]],
            telefone: ['', Validators.required],
            email: ['', [Validators.required, Validators.email]]
        });
    }

    onFileChange(event) {
        const reader = new FileReader();

        if (event.target.files && event.target.files.length) {
            this.file = event.target.files;

        }
    }

    uploadImagem() {
        if (this.modoSalvar === 'post') {
        const nomeArquivo = this.evento.imagemURL.split('\\', 3);
        this.evento.imagemURL = nomeArquivo[2];
        this.eventoService.postUpload(this.file, nomeArquivo[2]).
        subscribe(
            () => {
                this.dataAtual = new Date().getMilliseconds().toString();
                this.getEventos();
            }
        );
    }   else {
        this.evento.imagemURL = this.fileNameToUpdate;
        this.eventoService.postUpload(this.file, this.fileNameToUpdate)
        .subscribe(
            () => {
                this.dataAtual = new Date().getMilliseconds().toString();
                this.getEventos();
            }
        );
    }
    }

    salvarAlteracao(template: any) {
        if (this.registerForm.valid) {
            if (this.modoSalvar === 'post') {
            this.evento = Object.assign({}, this.registerForm.value);
            this.uploadImagem();
            this.eventoService.postEvento(this.evento).subscribe(
                (novoEvento: Evento) => {
                    template.hide();
                    this.getEventos();
                    this.showModalRegistro();
                }, error => {
                    console.log(error);
                }
            );
         } else {
            this.evento = Object.assign({id: this.evento.id}, this.registerForm.value);
            this.uploadImagem();
            this.eventoService.putEvento(this.evento).subscribe(
                () => {
                    template.hide();
                    this.getEventos();
                    this.showModalAtualizar();
                }, error => {
                    this.showModalErro();
                }
            );

         }
        }
    }
            // passar como parâmetro para o serviço
    filtrarEventos(filtrarPor: string): Evento[] {
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.eventos.filter(
            evento => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
        )
    }

    getEventos() {
        // requisição na api em ajax
        this.eventoService.getAllEvento().subscribe(
            (_eventos: Evento[]) => {
                this.eventos = _eventos;
                this.eventosFiltrados = this.eventos;
            }, error => {
                this.toastr.error(`Erro ao tentar carregar eventos: ${error}`);
            });
    }


}
