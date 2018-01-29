import { Component, Input } from '@angular/core';
import { ISearchResult } from '../../models/SearchResult';
import { SearchService } from '../../shared/search.service';

@Component({
    selector: 'app-search-result-detail',
    templateUrl: './search-result-detail.component.html'
})
export class SearchResultDetailComponent {
  @Input() result: ISearchResult;

    constructor(private searchService: SearchService) { }


    //updateUser(user) {
    //  this.searchService.updateUser(user).subscribe(result => {
    //        console.log('Put user result: ', result);
    //    }, error => {
    //        console.log(`There was an issue. ${error._body}.`);
    //    });
    //}
}
