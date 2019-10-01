import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalService, BsModalRef, BsDatepickerConfig } from 'ngx-bootstrap';
import Swal from 'sweetalert2';
import { FormGroup, Validators, FormBuilder, FormArray } from '@angular/forms';
import { defineLocale, BsLocaleService, ptBrLocale} from 'ngx-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '../misc/_models/Evento';
import { EventoService } from '../misc/_services/evento.service';
import { AreaService } from '../misc/_services/area.service';
import { Area } from '../misc/_models/Area';
defineLocale('pt-br', ptBrLocale);

@Component({
    selector: 'app-eventos',
    templateUrl: './eventos.component.html'
})
    export class EventosComponent implements OnInit {
    constructor(
        private eventoService: EventoService
      , private areaService: AreaService
      , private modalService: BsModalService
      , private fb: FormBuilder
      , private localeService: BsLocaleService
      , private toastr: ToastrService
        ) {
            this.maxDate.setDate(this.maxDate.getDate() + 7);
            this.bsRangeValue = [this.bsValue, this.maxDate];
            this.localeService.use('pt-br');
        }

    // get areas(): FormArray {
    //         return <FormArray>this.registerForm.get('areas');
    //  }

    get filtroLista(): string {
        return this._filtroLista;
    }
    set filtroLista(value: string) {
        this._filtroLista = value;
        this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
    }

    get filtroListaArea(): string {
        return this._filtroListaArea;
    }

    set filtroListaArea(value: string) {
        this._filtroListaArea = value;
        this.areasFiltrados = this.filtroListaArea ? this.filtrarAreas(this.filtroListaArea) : this.areas;
    }

    numero: number = 1;

    modalRef: BsModalRef;
    eventosFiltrados: Evento [];
    areasFiltrados: Area [];
    eventos: Evento[];
    evento: Evento;
    // area: Area[];
    area: Area;
    areas: Area[];
    areasEvento: Evento[];

    modoSalvar = 'post';
    config = {
        animated: true,
        keyboard: true,
        backdrop: true,
        ignoreBackdropClick: true
        };
    imagemLargura: number = 50;
    imagemMargem: number = 2;
    mostrarImagem = false;
    registerForm: FormGroup;
    bodyDeletarEvento = '';
    file: File;

    color = 'accent';
    checked = false;
    disabled = false;

    dataAtual: string;
    dataAtualInput: number =  Date.now();

    bsValue = new Date();
    bsRangeValue: Date[];
    maxDate = new Date();

    respostaPadrao: boolean = false;

    checked2: boolean = true;
    // Encapsulamento da propriedade
    // n acessa do lado de fora acessa o get ou o set da propriedade
    _filtroLista = '';
    _filtroListaArea = '';
    fileNameToUpdate: string;

    openModal(template: any) {
        this.registerForm.reset();
        template.show(this.config);
        // this.modalRef = this.modalService.show(template);
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
              );
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

    showModalErro() {
        Swal.fire({
            title: 'Erro!',
            text: 'Algum problema ocorreu contate o administrador do sistema.',
            type: 'error'
        });
    }
    // OnInit signifca q executa antes do html ficar pronto
    // pegar informações e atribuir a variaveis q serao utrilizadas dentro do html
    editarEvento(evento: Evento, template: any) {
        // this.toastr.success('Hello World', 'Toast Teste');
        this.modoSalvar = 'put';
        this.openModal(template);
        // carrega dado atual
        this.evento = Object.assign({}, evento);

            // RODAR UPLOAD
        // this.fileNameToUpdate = evento.imagemURL.toString();
        // this.evento.imagemURL = '';
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
        this.getAreas();
    }

    alterarImagem() {
        this.mostrarImagem = !this.mostrarImagem;
    }

    validation() {
        this.registerForm = this.fb.group({
            tema: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
            nome: ['', Validators.required],
            dataEvento: ['', Validators.required],
            imagemURL: [],
            meioDeContato: ['', Validators.required],
            respostaPadrao: [],
            classificacao: ['', Validators.required],
            caracteristica: ['', Validators.required],
            areaEnvolvida: ['', Validators.required],
            areaResponsavel: ['', Validators.required],
            fonte: ['', Validators.required],
            telefone: ['', Validators.required],
            celular: [],
            email: ['', Validators.required],
            areas: this.fb.array([])
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
            // this.uploadImagem();
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
            // this.uploadImagem();
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
        );
    }

    filtrarAreas(filtrarPor: string): Area[] {
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.areas.filter(
            area => area.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
        );
    }

    getAreas() {
        // requisição na api em ajax

        this.areaService.getAllArea().subscribe(
            (_areas: Area[]) => {
                this.areas = _areas;
                this.areasFiltrados = this.areas;
                // this.evento.areas.forEach(area => {
                //     this.areas.push(this.criaArea(area));
                //   });
            }, error => {
                this.toastr.error(`Erro ao tentar carregar areas: ${error}`);
            });
    }

    getEventos() {
        // requisição na api em ajax
        this.dataAtual = new Date().getMilliseconds().toString();
        this.eventoService.getAllEvento().subscribe(
            (_eventos: Evento[]) => {
                this.eventos = _eventos;
                this.eventosFiltrados = this.eventos;
                // this.evento.areas.forEach(area => {
                //     this.areas.push(this.criaArea(area));
                //   });
            }, error => {
                this.toastr.error(`Erro ao tentar carregar eventos: ${error}`);
            });
    }


}
