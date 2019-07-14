import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ApoliceAutomovelComponent } from './apolice-automovel/apolice-automovel.component';
import { ApoliceAutomovelService } from './apolice-automovel.service';

@NgModule({
   declarations: [
      AppComponent,
      ApoliceAutomovelComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule
   ],
   providers: [ApoliceAutomovelService],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
