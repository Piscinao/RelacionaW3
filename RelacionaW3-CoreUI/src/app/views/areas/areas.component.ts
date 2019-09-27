import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalService, BsModalRef, BsDatepickerConfig } from 'ngx-bootstrap';
import Swal from 'sweetalert2';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { defineLocale, BsLocaleService, ptBrLocale} from 'ngx-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { AreaService } from '../misc/_services/area.service';
import { Area } from '../misc/_models/Area';
defineLocale('pt-br', ptBrLocale);

@Component({
    selector: 'app-areas',
    templateUrl: './areas.component.html'
})
    export class AreasComponent implements OnInit {
    constructor(
        private areaService: AreaService
      , private modalService: BsModalService
      , private fb: FormBuilder
      , private localeService: BsLocaleService
      , private toastr: ToastrService
        ) {
            this.maxDate.setDate(this.maxDate.getDate() + 7);
            this.bsRangeValue = [this.bsValue, this.maxDate];
            this.localeService.use('pt-br');

        }

    get filtroLista(): string {
        return this._filtroLista;
    }
    set filtroLista(value: string) {
        this._filtroLista = value;
        this.areasFiltrados = this.filtroLista ? this.filtrarAreas(this.filtroLista) : this.areas;
    }

    modalRef: BsModalRef;
    areasFiltrados: Area [];
    areas: Area[];
    area: Area;
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
    bodyDeletarArea = '';
    file: File;

    color = 'accent';
    checked = false;
    disabled = false;

    bsValue = new Date();
    bsRangeValue: Date[];
    maxDate = new Date();

    respostaPadrao: boolean = false;

    checked2: boolean = true;
    // Encapsulamento da propriedade
    // n acessa do lado de fora acessa o get ou o set da propriedade
    _filtroLista = '';
    fileNameToUpdate: string;

    openModal(template: any) {
        this.registerForm.reset();
        template.show(this.config);
        // this.modalRef = this.modalService.show(template);
    }

    openModalDelete(area: Area) {
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
                this.area = area;
                this.areaService.deleteArea(this.area.id).subscribe(
                    () => {
                        this.getAreas();
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
    editarArea(area: Area, template: any) {

        this.modoSalvar = 'put';
        this.openModal(template);
        // carrega dado atual
        this.area = Object.assign({}, area);
        this.registerForm.patchValue(this.area);

    }

    novoArea(template: any) {
        this.modoSalvar = 'post';
        this.openModal(template);
    }

    ngOnInit() {
        this.validation();
        this.getAreas();
    }


    validation() {
        this.registerForm = this.fb.group({
            nome: ['', Validators.required]

        });
    }


    salvarAlteracao(template: any) {
        if (this.registerForm.valid) {
            if (this.modoSalvar === 'post') {
            this.area = Object.assign({}, this.registerForm.value);
            // this.uploadImagem();
            this.areaService.postArea(this.area).subscribe(
                (novoArea: Area) => {
                    template.hide();
                    this.getAreas();
                    this.showModalRegistro();
                }, error => {
                    console.log(error);
                }
            );
         } else {
            this.area = Object.assign({id: this.area.id}, this.registerForm.value);
            this.areaService.putArea(this.area).subscribe(
                () => {
                    template.hide();
                    this.getAreas();
                    this.showModalAtualizar();
                }, error => {
                    this.showModalErro();
                }
            );

         }
        }
    }
            // passar como parâmetro para o serviço
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
            }, error => {
                this.toastr.error(`Erro ao tentar carregar areas: ${error}`);
            });
    }


}
