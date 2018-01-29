import {
  Component, OnInit,
  // animation imports
  trigger, state, style, transition, animate, Inject
} from '@angular/core';
import { ISearchResult } from '../../models/SearchResult';
import { SearchService } from '../../shared/search.service';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToasterModule, ToasterService, ToastComponent, ToasterContainerComponent } from 'angular5-toaster/angular5-toaster';

//@import 'node_modules/angular5-toaster/toaster'

  //, '../../node_modules/angular5-toaster/toaster'

@Component({
  selector: 'app-search-results',

  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.css'],
  animations: [
    // Animation example
    // Triggered in the ngFor with [@flyInOut]
    trigger('flyInOut', [
      state('in', style({ transform: 'translateY(0)' })),
      transition('void => *', [
        style({ transform: 'translateY(-100%)' }),
        animate(1000)
      ]),
      transition('* => void', [
        animate(1000, style({ transform: 'translateY(100%)' }))
      ])
    ])
  ]
})
export class SearchResultsComponent implements OnInit {

  private toasterService: ToasterService;
  searchResults: ISearchResult[];
  selectedResult: ISearchResult;

  // Use "constructor"s only for dependency injection
  constructor(private searchService: SearchService, toasterService: ToasterService) {
    this.toasterService = toasterService;
  }

  // Here you want to handle anything with @Input()'s @Output()'s
  // Data retrieval / etc - this is when the Component is "ready" and wired up
  ngOnInit() {
    this.searchService.search().subscribe(result => {
      console.log('HttpClient [GET] /api/search/', result);
      this.searchResults = result;
    });
  }

  onSelect(user: ISearchResult): void {
    this.selectedResult = user;
  }
  
  popToast(title) {
    this.toasterService.pop('success', 'Bookmark added!', title);
  }

}
