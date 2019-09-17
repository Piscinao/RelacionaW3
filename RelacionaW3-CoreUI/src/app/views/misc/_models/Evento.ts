import { Lote } from './Lote';
import { RedeSocial } from './RedeSocial';
import { Palestrante } from './Palestrante';

export class Evento {
    // interface de referencia de um tipo específico

    /**
     *
     */
    constructor() {
    }
    id: number;
    nome: string;
    dataEvento: Date ;
    tema: string;
    meioDeContato: string;
    fonte: string;
    imagemURL: string;
    telefone: string;
    email: string;
    lotes: Lote[];
    redesSociais: RedeSocial[];
    palestranteseventos: Palestrante [];

}
