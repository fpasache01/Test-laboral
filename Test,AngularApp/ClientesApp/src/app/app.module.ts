import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ClientListComponent } from './client-list/client-list.component';
import { PhoneFormatPipe } from './phone-format.pipe';
import { NgxPaginationModule } from 'ngx-pagination';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { NO_ERRORS_SCHEMA } from '@angular/compiler';


@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,

    FormsModule,
    NgxPaginationModule
  ],
  declarations: [
    AppComponent,
    ClientListComponent,
    PhoneFormatPipe
  ],
  
  providers: [],
  bootstrap: [AppComponent],
  schemas:[CUSTOM_ELEMENTS_SCHEMA,NO_ERRORS_SCHEMA]
})
export class AppModule { }
