import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { ContatosComponent } from './contatos/contatos.component';
import { BlankPageComponent } from './blank-page/blank-page.component';
import { UsuarioComponent } from './usuario/usuario.component';
import { RegistrarComponent } from './usuario/registrar/registrar.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';

// ALTERA ROTAS PARA O MENU E O HTTP
const routes: Routes = [
    {
        path: '',
        component: LayoutComponent,
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'prefix' },
            { path: 'contatos', component: ContatosComponent},
            { path: 'registrar', component: RegistrarComponent},
            { path: 'palestrantes', component: PalestrantesComponent},
            { path: 'usuario', component: UsuarioComponent},
            { path: 'blank-page', component: BlankPageComponent},
            { path: 'dashboard', loadChildren: () => import('./dashboard/dashboard.module').then(m => m.DashboardModule) },
            { path: 'charts', loadChildren: () => import('./charts/charts.module').then(m => m.ChartsModule) },
            { path: 'tables', loadChildren: () => import('./tables/tables.module').then(m => m.TablesModule) },
            { path: 'forms', loadChildren: () => import('./form/form.module').then(m => m.FormModule) },
            { path: 'bs-element', loadChildren: () => import('./bs-element/bs-element.module').then(m => m.BsElementModule) },
            { path: 'grid', loadChildren: () => import('./grid/grid.module').then(m => m.GridModule) },
            { path: 'components', loadChildren: () => import('./bs-component/bs-component.module').then(m => m.BsComponentModule) },
          //  { path: 'usuario', loadChildren: () => import('./usuario/usuario.module').then(m => m.UsuarioModule) },
         //   { path: 'contatos', loadChildren: () => import('./contatos/contatos.module').then(m => m.ContatosModule) },
          //  { path: 'palestrantes', loadChildren: () => import('./palestrantes/palestrantes.module').then(m => m.PalestrantesModule) },
           // { path: 'blank-page', loadChildren: () => import('./blank-page/blank-page.module').then(m => m.BlankPageModule) }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LayoutRoutingModule {}
