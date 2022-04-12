import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import Order from 'src/app/models/order.model';
import { OrderService } from 'src/app/services/order.service';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.scss']
})
export class MasterComponent implements OnInit {

  public orders : Order[] = [];
  constructor(private orderService : OrderService, public datepipe: DatePipe) { }
  public userId : number = 0;
  public users : number[] = [1,2,3];

  ngOnInit(): void {
    
    // this.orders.forEach(order => {
    //   if (order.time != null)
    //   {order.time = this.datepipe.transform(order.time, 'yyyy-MM-dd')}
    // })
  }

  public listorders(userId : number)
  {
    this.orderService.getUserOrders(userId).subscribe((orders) => {
      this.orders = orders
    })
      this.orders.forEach(order => {
      order.orderDate =new Date(order.orderDate)
    }) 
  }
  public markAsPaid(userId : number)
  {
    this.orderService.markAsPaid(this.userId)
  }
}
