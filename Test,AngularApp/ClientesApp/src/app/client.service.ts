// client.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Client {
  idClient: number;
  name: string;
  rut: string;
  email: string;
  country: string;
  phone: string;
}

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private apiUrl = 'https://localhost:7028/api/Client/GetAllClientsEF'; // Replace with your actual API URL

  constructor(private http: HttpClient) { }

  getClients(pageSize: number, pageNumber: number): Observable<Client[]> {
    return this.http.get<Client[]>(`${this.apiUrl}?pageSize=${pageSize}&pageNumber=${pageNumber}`);
  }
}
