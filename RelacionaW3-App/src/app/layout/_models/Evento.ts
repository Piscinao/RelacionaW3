import { Lote } from './Lote';
import { RedeSocial } from './RedeSocial';
import { Palestrante } from './Palestrante';

export interface Evento {
    //interface de referencia de um tipo específico
    id: number;
    local: string;
    dataEvento: Date ;
    tema: string;
    qtdPessoas: number;
    imagemURL: string;
    telefone: string;
    email: string;
    lotes: Lote[];
    redessociais: RedeSocial[];
    palestranteseventos: Palestrante [];

}
