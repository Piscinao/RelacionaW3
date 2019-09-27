import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Area } from '../_models/Area';


@Injectable({
  providedIn: 'root'
})
export class AreaService {
  baseURL = 'http://localhost:5000/api/area';

constructor(private http: HttpClient) {}

getAllArea(): Observable<Area[]> {
  return this.http.get<Area[]>(this.baseURL);

}
getAreaByTema(nome: string): Observable<Area[]> {
  return this.http.get<Area[]>(`${this.baseURL}/getByNome/${nome}`);

}
getAreaById(id: number): Observable<Area> {
  return this.http.get<Area>(`${this.baseURL}/${id}`);

}


postArea(area: Area) {
  return this.http.post(this.baseURL , area);
  // primeiro parametro do post é a url, e o segundo é o elemento todo copia do register e apssa para area

}

putArea(area: Area) {
  return this.http.put(`${this.baseURL}/${area.id}`, area);
  // primeiro parametro do post é a url, e o segundo é o elemento todo copia do register e apssa para area

}

deleteArea(id: number) {
  return this.http.delete(`${this.baseURL}/${id}`);
  // primeiro parametro do post é a url, e o segundo é o elemento todo copia do register e apssa para area

}
}
