import { Component, Input, OnInit } from '@angular/core';
import Order from 'src/app/models/order.model';
import { OrderService } from 'src/app/services/order.service';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.scss']
})
export class OrderComponent implements OnInit {

  @Input() orders : Order[] = [];
  constructor(private orderService : OrderService) { }

  ngOnInit(): void {
  }
  public markAsPaid(orderId : number)
  {
    this.orderService.markAsPaid(orderId).subscribe()
  }

}
