import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private apiUrl = 'https://localhost:7028/api/Client/GetAllClientsEF?pageSize=1&pageNumber=1';

  constructor(private http: HttpClient) { }

  getClients(): Observable<Client[]> {
    return this.http.get<Client[]>(this.apiUrl);
  }
}

export interface Client {
  idClient: number;
  name: string;
  rut: string;
  email: string;
  country: string;
  phone: string;
}
