import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PalestrantesComponent } from './palestrantes.component';

const routes: Routes = [
    {
        path: '',
        component: PalestrantesComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class PalestrantesRoutingModule {}
