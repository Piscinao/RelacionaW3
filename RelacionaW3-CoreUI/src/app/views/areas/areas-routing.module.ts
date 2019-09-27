import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AreasComponent } from './areas.component';
import { AuthGuard } from '../auth/auth.guard';

const routes: Routes = [
    {
      path: 'areas', component: AreasComponent,
      canActivate: [AuthGuard],
      data: {
      title: 'Areas'
    },
  },

    // {
    //   path: 'areas',
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
export class AreasRoutingModule {}
