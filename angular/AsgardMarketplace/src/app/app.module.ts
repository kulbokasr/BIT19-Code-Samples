import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { MasterComponent } from './components/master/master.component';
import { OrderComponent } from './components/order/order.component';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    MasterComponent,
    OrderComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
