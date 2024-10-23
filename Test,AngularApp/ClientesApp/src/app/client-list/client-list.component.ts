// client-list.component.ts
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientService, Client } from '../client.service';
//import { PhoneFormatPipe } from '../phone-format.pipe';
import { PhoneFormatPipe } from '../phone-format.pipe';
import { NgxPaginationModule } from 'ngx-pagination';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrls: ['./client-list.component.css'],
  standalone: true,
  imports: [CommonModule, PhoneFormatPipe,NgxPaginationModule]
})
export class ClientListComponent implements OnInit {
  clients: Client[] = [];
  totalItems = 1;
  itemsPerPage = 1;
  maxSize = 1;
  currentPage = 1;

  constructor(private clientService: ClientService) { }

  pageChanged(event: number): void {
    this.currentPage = event;
    this.loadClients(); 
  }
  loadClients(): void {
    this.clientService.getClients(this.itemsPerPage, this.currentPage).subscribe(data => {
      this.clients = data;
     
      this.totalItems = 1; 
    });
  }
  ngOnInit(): void {
    this.clientService.getClients(10, 1).subscribe(data => {
      this.clients = data;
    });
  }
}
