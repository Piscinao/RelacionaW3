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

    static fontes = {
        Interna: 'Interna',
        Externa: 'Externa'
    };

    static meiosDeContato = {
        Telefonico: 'Telefonico',
        Site: 'Site',
        RedesSociais: 'Redes Sociais',
        Email: 'E-mail',
        FormularioImpresso: 'Formulário Impresso'
    };

    static classificacao = {
        Cliente: 'Cliente',
        Representante: 'Representante',
        Comunidade: 'Comunidade',
        Colaborador: 'Colaborador',
        Prestador: 'Prestador',
        Fornecedor: 'Fornecedor'
    };

    static caracteristica = {
        DenunciaInterna: 'Denuncia Interna',
        DenunciaExterna: 'Denuncia Externa',
        Duvida: 'Duvida',
        Reclamacao: 'Reclamacao',
        ContatoComercial: 'Contato Comercial',
        Sugestao: 'Sugestao',
        PosVenda: 'Pos-Venda',
        PesquisaSatisfacao: 'PesquisaSatisfacao',
        ComoEstouDirigindo: 'ComoEstouDirigindo',
        Agradecimento: 'Agrecimento'
    };

    id: number;
    nome: string;
    dataEvento: Date;
    tema: string;
    meioDeContato: string;
    classificacao: string;
    caracteristica: string;
    areaEnvolvida: string;
    areaResponsavel: string;
    fonte: string;
    imagemURL: string;
    respostaPadrao: string;
    telefone: string;
    celular: string;
    email: string;
    lotes: Lote[];
    redesSociais: RedeSocial[];
    palestranteseventos: Palestrante [];

    // get paidText(): string {
    //     return this.paid ? 'Pago' : 'Pendente';
    // }


}
