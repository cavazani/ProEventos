import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent {
  //Criando Lista de objetos manual para testes
  //  public eventos: any = [
  //   {
  //    Tema: 'Angular',
  //    Local: 'Campo Grande'
  //   },
  //   {
  //     Tema: 'Angular11',
  //     Local: 'Rio de Janeiro'
  //    },
  //    {
  //     Tema: 'Angular14',
  //     Local: 'Parana'
  //    }
  // ]

  public eventos: any = [];
  larguraImagem: number = 100;
  margemImagem: number = 2;
  exibirImagem: boolean = true;
  filtroLista: string = '';

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEventos();
  }

 alterarEstadoDaImagem(){
  this.exibirImagem = !this.exibirImagem;
 }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      (response) => (this.eventos = response),
      (error) => console.log(error)
    );
  }
}
