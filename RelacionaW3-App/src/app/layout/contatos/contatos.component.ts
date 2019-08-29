import { Component, OnInit, TemplateRef } from '@angular/core';
import { EventoService } from 'src/app/layout/_services/evento.service';
import { Evento } from 'src/app/layout/_models/Evento';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import Swal from 'sweetalert2';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { defineLocale, BsLocaleService, ptBrLocale} from'ngx-bootstrap';
import { ToastrService } from 'ngx-toastr';
defineLocale('pt-br', ptBrLocale);

@Component({
    selector: 'app-contatos',
    templateUrl: './contatos.component.html',
    styleUrls: ['./contatos.component.scss']
})
export class ContatosComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}