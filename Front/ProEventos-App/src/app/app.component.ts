import { Component } from '@angular/core';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { RouterOutlet } from '@angular/router';
import { EventosComponent } from './eventos/eventos.component';
import { HttpClientModule } from '@angular/common/http'
import { NavComponent } from './nav/nav.component';

import { CollapseModule } from 'ngx-bootstrap/collapse'


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PalestrantesComponent, EventosComponent, HttpClientModule, NavComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})

export class AppComponent {
  title = 'ProEventos-App';
}
