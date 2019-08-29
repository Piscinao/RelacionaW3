import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ContatosComponent } from './contatos.component';

const routes: Routes = [
    {
        path: '',
        component: ContatosComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ContatosRoutingModule {}
