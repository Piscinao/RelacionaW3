import { Component, OnInit, TemplateRef } from '@angular/core';
import { EventoService } from 'src/app/layout/_services/evento.service';
import { Evento } from 'src/app/layout/_models/Evento';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { defineLocale, BsLocaleService, ptBrLocale} from'ngx-bootstrap';
import { ToastrService } from 'ngx-toastr';
defineLocale('pt-br', ptBrLocale);

@Component({
    selector: 'app-palestrantes',
    templateUrl: './palestrantes.component.html',
    styleUrls: ['./palestrantes.component.scss']
})
export class PalestrantesComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}


