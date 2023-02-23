import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

   public eventos: any = [
    {
     Tema: 'Angular',
     Local: 'Campo Grande'
    },
    {
      Tema: 'Angular11',
      Local: 'Rio de Janeiro'
     },
     {
      Tema: 'Angular14',
      Local: 'Parana'
     }
  ]



}
