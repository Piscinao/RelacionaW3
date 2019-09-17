import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EventosComponent } from './eventos.component';
import { AuthGuard } from '../auth/auth.guard';
import { EventoEditComponent } from './eventoEdit/eventoEdit.component';

const routes: Routes = [
    {
      path: 'eventos', component: EventosComponent,
      canActivate: [AuthGuard],
      data: {
      title: 'Eventos'
    },
  },

    // {
    //   path: 'eventos',
    //   component: EventosComponent,
    //   canActivate: [AuthGuard]
    // },
    // {
    //     path: 'evento/:id/edit',
    //     component: EventoEditComponent,
    //     canActivate: [AuthGuard]
    // }
    // },

      // {
      //   path: 'evento/:id/edit',
      //   component: EventoEditComponent,
      //   canActivate: [AuthGuard]
      // },

];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class EventosRoutingModule {}
