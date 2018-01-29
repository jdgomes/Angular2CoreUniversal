import { Component, OnInit, ViewChild, ElementRef, EventEmitter, Output, Inject } from '@angular/core';
//import { LocationService } from 'app/shared/location.service';
//import { DOCUMENT } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router'; 
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/distinctUntilChanged';

/**
 * This component provides a text box to type a search query that will be sent to the SearchService.
 *
 * When you arrive at a page containing this component, it will retrieve the `query` from the browser
 * address bar. If there is a query then this will be made.
 *
 * Focussing on the input box will resend whatever query is there. This can be useful if the search
 * results had been hidden for some reason.
 *
 */
@Component({
  selector: 'aio-search-box',
  template: `<input #searchBox
    type="search"
    aria-label="search"
    placeholder="Search"
    (input)="doSearch()"
    (keyup)="doSearch($event)"
    (focus)="doFocus()"
    (click)="doSearch()">`
})
export class SearchBoxComponent implements OnInit {

  private searchDebounce = 300;
  private searchSubject = new Subject<string>();

  @ViewChild('searchBox') searchBox: ElementRef;
  @Output() onSearch = this.searchSubject.distinctUntilChanged().debounceTime(this.searchDebounce);
  @Output() onFocus = new EventEmitter<string>();

  //constructor(private locationService: LocationService) { }
  //constructor(private document: DOCUMENT) { }
  constructor(private route: ActivatedRoute, private router: Router) { }

  //constructor( @Inject(DOCUMENT) private document: any) { }

  /**
   * When we first show this search box we trigger a search if there is a search query in the URL
   */
  ngOnInit() {
    //const query = this.document.search()['search'];
    //if (query) {
    //  this.query = query;
    //  this.doSearch();
    //}
  }

  doSearch(event) {
    this.searchSubject.next(this.query);
    if (this.query && event && event.keyCode == 13)
      this.router.navigate(['/search-results']);
  }

  doFocus() {
    this.onFocus.emit(this.query);
  }

  focus() {
    this.searchBox.nativeElement.focus();
  }

  private get query() { return this.searchBox.nativeElement.value; }
  private set query(value: string) { this.searchBox.nativeElement.value = value; }
}
