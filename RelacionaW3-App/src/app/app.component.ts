import { Component } from '@angular/core';
// COMPONENTES CAMINHOS
@Component({
  selector: 'app-root', // COMO UTILIZA O COMPONENTE NO HTML
  templateUrl: './app.component.html',// TEMPLATE RELACIONADO A CLASSE
  // template: '<h1>{{title}}</h1>
  styleUrls: ['./app.component.css'] /// QUAL O CSS
})
export class AppComponent {
  title = 'Relaciona W3';
}
