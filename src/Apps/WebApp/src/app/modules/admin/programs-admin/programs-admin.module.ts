import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProgramsAdminRoutingModule } from './programs-admin-routing.module';
import { ProgramsAdminComponent } from './programs-admin.component';
import { EditProgramComponent } from './edit-program/edit-program.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ProgramsAdminComponent,
    EditProgramComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    ProgramsAdminRoutingModule
  ]
})
export class ProgramsAdminModule { }
