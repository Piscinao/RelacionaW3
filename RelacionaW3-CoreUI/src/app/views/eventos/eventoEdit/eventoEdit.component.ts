import { Component, OnInit, Sanitizer } from '@angular/core';
import { EventoService } from '../../misc/_services/evento.service';
import { BsModalService, BsLocaleService } from 'ngx-bootstrap';
import { FormBuilder, FormGroup, Validators, FormArray } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '../../misc/_models/Evento';
import { ActivatedRoute } from '@angular/router';
import { DomSanitizer } from '@angular/platform-browser';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-evento-edit',
  templateUrl: './eventoEdit.component.html',
  styleUrls: ['./eventoEdit.component.scss']
})
export class EventoEditComponent implements OnInit {

  titulo = 'Editar Evento';
  evento: Evento = new Evento();
  imagemURL =  'assets/img/brand/upload-icon.png';
  registerForm: FormGroup;
  fileNameToUpdate: string;
  dataAtual = '';
  file: File;



  get lotes(): FormArray {
    return <FormArray>this.registerForm.get('lotes');
  }

  get redesSociais(): FormArray {
    return <FormArray>this.registerForm.get('redesSociais');
  }

 constructor(
        private eventoService: EventoService
     , private fb: FormBuilder
      , private localeService: BsLocaleService
      , public sanitizer: DomSanitizer
      , private router: ActivatedRoute
      , private toastr: ToastrService
        ) {
            // this.localeService.use('pt-br');
        }

        ngOnInit() {
          this.validation();
          this.carregarEvento();
      }

      carregarEvento() {
        const idEvento = +this.router.snapshot.paramMap.get('id');
        this.eventoService.getEventoById(idEvento)
        .subscribe(
          (evento: Evento) => {
            this.evento = Object.assign({}, evento);
          //  this.fileNameToUpdate = evento.imagemURL.toString();
          //  this.imagemURL = ` http://localhost:5000/resources/images/${this.evento.imagemURL}?_ts=${this.dataAtual}`;
          //  this.evento.imagemURL = ' ';
          // preenche o formulario
           this.registerForm.patchValue(this.evento);

           this.evento.lotes.forEach(lote => {
             this.lotes.push(this.criaLote(lote));

           });

           this.evento.redesSociais.forEach( redeSocial => {
             this.redesSociais.push(this.criaRedeSocial(redeSocial));
           });

          }
        );
      }

      onFileChange(evento: any, file: FileList) {
        const reader = new FileReader();
        reader.onload = (event: any) => this.imagemURL = event.target.result;
        this.file = evento.target.files;
        reader.readAsDataURL(file[0]);
      }

      validation() {
          this.registerForm = this.fb.group({
            id: [],
              tema: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
              nome: ['', Validators.required],
              dataEvento: ['', Validators.required],
              imagemURL: [],
              meioDeContato: [],
              telefone: ['', Validators.required],
              email: ['', [Validators.required, Validators.email]],
         lotes: this.fb.array([]) ,
         redesSociais: this.fb.array([])
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

      salvarEvento() {
        this.evento = Object.assign({id: this.evento.id}, this.registerForm.value);
        // this.evento.imagemURL = this.fileNameToUpdate;
        //     this.uploadImagem();
            this.eventoService.putEvento(this.evento).subscribe(
                () => {
                    this.showModalAtualizar();
                }, error => {
                    this.showModalErro();
                }
            );
      }

        uploadImagem() {
            if (this.registerForm.get('imagemURL').value !== ' ' ) {
            this.eventoService.postUpload(this.file, this.fileNameToUpdate)
            .subscribe(
                () => {
                    this.dataAtual = new Date().getMilliseconds().toString();
                    this.imagemURL = ` http://localhost:5000/resources/images/${this.evento.imagemURL}?_ts=${this.dataAtual}`;
                }
            );
           }
         }


      criaLote(lote: any): FormGroup {
        return this.fb.group({
          id: [lote.id],
          quantidade : [ lote.quantidade   , Validators.required],
          nome: [lote.nome  , Validators.required],
          preco: [lote.preco , Validators.required],
          dataInicio: [lote.dataInicio, Validators],
          dataFim: [lote.dataFim, Validators]
          });
      }

      criaRedeSocial(redeSocial: any): FormGroup {
          return this.fb.group({
          id: [redeSocial.id],
          nome: [redeSocial.nome, Validators.required],
          url: [redeSocial.url, Validators.required]
        });
      }


      adicionarLote() {
        this.lotes.push(this.criaLote({id: 0}));
      }

      adicionarRedeSocial() {
        this.redesSociais.push(this.criaRedeSocial({id: 0}));
      }

      removerRedeSocial(id: number) {
        this.redesSociais.removeAt(id);

      }

      removerLote(id: number) {
        this.lotes.removeAt(id);

      }
}
