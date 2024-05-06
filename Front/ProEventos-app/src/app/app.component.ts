import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PalestrantesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})

export class AppComponent {
  title = 'ProEventos-app';
}


