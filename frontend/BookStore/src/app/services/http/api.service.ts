import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UrlParams } from 'src/app/entity/UrlParams';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiBase = `https://localhost:7214/`;

  constructor(private http: HttpClient) { }
  get(url: Array<string | number>): Observable<any> {
    return this.http.get(this.apiBase + url);
  }

  post(url: Array<string | number>, bodyParams: any): Observable<any> {
    console.log("author2", bodyParams);
    const u = this.apiBase + url;
    console.log(u);
    return this.http.post(this.apiBase + url, bodyParams);
  }
}
