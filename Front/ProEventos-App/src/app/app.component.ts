import { Component } from '@angular/core';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { RouterOutlet } from '@angular/router';
import { EventosComponent } from './eventos/eventos.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PalestrantesComponent, EventosComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})

export class AppComponent {
  title = 'ProEventos-App';
}
