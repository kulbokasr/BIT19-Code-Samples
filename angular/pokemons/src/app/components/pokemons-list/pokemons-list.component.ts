import { Component, OnInit } from '@angular/core';
import Pokemon from 'src/app/models/pokemon.model';
import { PokemonService } from 'src/app/services/pokemon.service';

@Component({
  selector: 'app-pokemons-list',
  templateUrl: './pokemons-list.component.html',
  styleUrls: ['./pokemons-list.component.scss']
})
export class PokemonsListComponent implements OnInit {

  constructor(private pokemonService: PokemonService) { }

  public pokemons : Pokemon[] = []
  public pokemon : Pokemon = {} as Pokemon
  public data : [] = []

  ngOnInit(): void {
    this.getAllPokemons()
  }

  getAllPokemons(){
    for (let id = 1; id < 21; id++){
      this.pokemonService.getPokemon(id).subscribe((pokemon) => {
        this.pokemon = pokemon;
        this.pokemons.push(this.pokemon)
      });
     
    }

  }

}
