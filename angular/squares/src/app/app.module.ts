import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { JwPaginationModule } from 'jw-angular-pagination';

import { AppComponent } from './app.component';
import { PointsComponent } from './components/points/points.component';
import { PointsListComponent } from './components/points-list/points-list.component';
import { PointsCreateComponent } from './components/points-create/points-create.component';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatNativeDateModule} from '@angular/material/core';
import { MatTableModule } from '@angular/material/table'  




@NgModule({
  declarations: [
    AppComponent,
    PointsComponent,
    PointsListComponent,
    PointsCreateComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    JwPaginationModule,
    MatPaginatorModule,
    MatNativeDateModule,
    MatTableModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
