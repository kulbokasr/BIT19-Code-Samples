import { Time } from "@angular/common"
import Item from "./item.model"
import User from "./user.model"

export default interface Order {
    id: number,
    name: string,
    status: string,
    userId: number,
    itemId: number
    user: User,
    item: Item,
    orderDate: Date,
    orderDateString : any
}