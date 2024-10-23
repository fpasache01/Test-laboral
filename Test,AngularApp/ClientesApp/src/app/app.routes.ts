// app.routes.ts
import { Routes } from '@angular/router';
import { ClientListComponent } from './client-list/client-list.component';

export const routes: Routes = [
  { path: 'clients', component: ClientListComponent },
  { path: '', redirectTo: '/clients', pathMatch: 'full' }
];
