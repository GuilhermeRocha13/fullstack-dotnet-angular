import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { error } from 'console';
import { response } from 'express';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {

  public eventos: any = [] ;
  private _filtroLista: string = ''

  
  
  constructor(private http: HttpClient) { }

  ngOnInit():void {
    this.getEventos();

  }
  public getEventos(): void {
    
    this.http.get('https://localhost:5001/api/eventos/').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }
  
  public get filtroLista(): string{
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventos = this.filtroLista ? this.filtrarEventos(this._filtroLista) : this.eventos
  }

  filtrarEventos(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLowerCase();
    return this.eventos.filter(
      (      evento: { tema: string; }) => evento.tema.toLowerCase().indexOf(filtrarPor)
    )
  } 


}
