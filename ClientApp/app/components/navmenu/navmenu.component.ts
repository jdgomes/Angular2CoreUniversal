import { Component, OnInit, Inject } from '@angular/core';

import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './navmenu.component.html',
  styleUrls: ['./navmenu.component.css']
})

export class NavMenuComponent {

  constructor(  public translate: TranslateService ) { }

  public setLanguage(lang) {
    this.translate.use(lang);
  }
}
