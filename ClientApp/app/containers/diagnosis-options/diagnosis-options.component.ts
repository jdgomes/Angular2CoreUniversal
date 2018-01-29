import { Component, OnInit, Inject } from '@angular/core';

import { TranslateService } from '@ngx-translate/core';

@Component({
    selector: 'app-home',
    templateUrl: './diagnosis-options.component.html',
    styleUrls: ['./diagnosis-options.component.css']
})
export class DiagnosisOptionsComponent implements OnInit {
  

    // Use "constructor"s only for dependency injection
    constructor(
      public translate: TranslateService
    ) { }

    // Here you want to handle anything with @Input()'s @Output()'s
    // Data retrieval / etc - this is when the Component is "ready" and wired up
    ngOnInit() { }

    public setLanguage(lang) {
        this.translate.use(lang);
    }
}
