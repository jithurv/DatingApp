import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  baseurl = 'http://localhost:5000/api/auth/';
  constructor(private http: HttpClient) {}

  login(model: any) {
    const returnValue = this.http.post(this.baseurl + 'login', model).pipe(
      map((response: any) => {
        if (response != null) {
          localStorage.setItem('token', response.token);
        }
      })
    );
    return returnValue;
  }
}
