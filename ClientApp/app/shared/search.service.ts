import { Injectable, Inject, Injector } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Http, URLSearchParams } from '@angular/http';
import { APP_BASE_HREF } from '@angular/common';
import { ORIGIN_URL } from '@nguniversal/aspnetcore-engine';
import { ISearchResult } from '../models/SearchResult';
import { Observable } from 'rxjs/Observable';


@Injectable()
export class SearchService {

  private baseUrl: string;

  constructor(
    private http: HttpClient,
    private injector: Injector
  ) {
    this.baseUrl = this.injector.get(ORIGIN_URL);
  }

  search() {
    return this.http.get<ISearchResult[]>(`${this.baseUrl}/api/search`);
  }
}
