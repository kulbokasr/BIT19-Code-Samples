import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import CreateOrder from '../models/create-order.model';
import Order from '../models/order.model';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private httpClient: HttpClient) { }

  public getUserOrders(userId : number) : Observable<Order[]> {
    return this.httpClient.get<Order[]>('https://localhost:44386/Order/'+userId)
  }
  public createOrder(createOrder : CreateOrder) : Observable<any> {
    return this.httpClient.post<Order>('https://localhost:44386/Order', createOrder)
  }
  public markAsPaid(orderId : number) :  Observable<Order[]> {
    return this.httpClient.put<Order[]>('https://localhost:44386/Order/'+orderId+'/Pay', orderId)
  }

}
