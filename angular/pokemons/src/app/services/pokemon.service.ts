import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Pokemon from '../models/pokemon.model';

@Injectable({
  providedIn: 'root'
})
export class PokemonService {

  constructor(private httpclient : HttpClient) { }

  public getPokemon(id :number): Observable<Pokemon> {
    return this.httpclient.get<Pokemon>("https://pokeapi.co/api/v2/pokemon/"+id)
  }

  public getPokemonType(id :number): Observable<Pokemon> {
    return this.httpclient.get<Pokemon>("https://pokeapi.co/api/v2/pokemon/"+id)
  }
}
