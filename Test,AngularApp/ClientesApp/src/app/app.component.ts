import { Component, NgModule } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PhoneFormatPipe } from './phone-format.pipe';
import { HttpClientModule } from '@angular/common/http';
import { ClientService } from './client.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ClientesApp';
}
