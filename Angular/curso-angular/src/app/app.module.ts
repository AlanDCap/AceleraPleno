import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CasosComponent } from './components/casos/casos.component';
import { ClienteComponent } from './components/cliente/cliente.component';
import { EmmiterOneComponent } from './components/emmiter-one/emmiter-one.component';
import { EmmiterTwoComponent } from './components/emmiter-two/emmiter-two.component';
import { ListaEnderecoComponent } from './components/lista-endereco/lista-endereco.component';
import { PrimeiroComponent } from './components/primeiro/primeiro.component';
import { SegundoComponent } from './components/segundo/segundo.component';
import { ConsultaCepComponent } from './services/consulta-cep/consulta-cep.component';

@NgModule({
  declarations: [
    AppComponent,
    CasosComponent,
    ClienteComponent,
    EmmiterOneComponent,
    EmmiterTwoComponent,
    ListaEnderecoComponent,
    PrimeiroComponent,
    SegundoComponent,
    ConsultaCepComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
