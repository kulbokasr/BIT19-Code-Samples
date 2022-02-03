export default interface Pokemon {
    id : number,
    name : string,
    weight : number,
    type : {name : string}
    photo: string // sprites -> front_default
}