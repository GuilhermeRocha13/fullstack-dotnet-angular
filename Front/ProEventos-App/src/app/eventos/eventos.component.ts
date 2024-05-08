import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {

  public eventos: any ;

  public getEventos(): void {
    this.eventos = [ {
      Tema: 'Angu',
      Local: 'BH'
    },
    {
      Tema: 'Ang',
      Local: 'B'
    },
    {
      Tema: 'a',
      Local: 'bH'
    }
  ]
  }
}
