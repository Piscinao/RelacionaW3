import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { User } from '../_models/User';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

baseURL = 'http://localhost:5000/api/user/';
jwtHelper = new JwtHelperService();
decodedToken: any;
tokenHeader: HttpHeaders;

constructor(private http: HttpClient) {

  this.tokenHeader = new HttpHeaders({'Authorization': `Bearer  ${localStorage.getItem('token')}`});
}

login(model: any) {
  return this.http
    .post(`${this.baseURL}login`, model).pipe(
      map((response: any) => {
        const user = response;
        if (user) {
          localStorage.setItem('token', user.token);
          this.decodedToken = this.jwtHelper.decodeToken(user.token);
          sessionStorage.setItem('username', this.decodedToken.unique_name);
        }
      })
    );
}

registrar(model: any) {
  return this.http.post(`${this.baseURL}register`, model, { headers: this.tokenHeader});
}

putUser(user: User) {
  return this.http.put(`${this.baseURL}/${user.id}`, user);
  // primeiro parametro do post é a url, e o segundo é o elemento todo copia do register e apssa para evento

}

getUserById(id: number): Observable<User> {
  return this.http.get<User>(`${this.baseURL}/${id}`);

}

getAllUser(): Observable<User[]> {

  return this.http.get<User[]>(this.baseURL);

}

// getUserById(id: number): Observable<User> {
//   return this.http.get<User>(`${this.baseURL}/${id}`);

// }

deleteUser(id: number) {
  return this.http.delete(`${this.baseURL}/${id}`);
}

loggedIn() {
  const token = localStorage.getItem('token');
  return !this.jwtHelper.isTokenExpired(token);

}

}
