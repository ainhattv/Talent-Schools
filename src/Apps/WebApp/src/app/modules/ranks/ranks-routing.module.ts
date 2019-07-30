import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RanksComponent } from './ranks.component';

const routes: Routes = [
  {
    path: '',
    component: RanksComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RanksRoutingModule { }
