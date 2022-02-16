import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { PointsComponent } from './components/points/points.component';
import { PointsListComponent } from './components/points-list/points-list.component';
import { PointsCreateComponent } from './components/points-create/points-create.component';

@NgModule({
  declarations: [
    AppComponent,
    PointsComponent,
    PointsListComponent,
    PointsCreateComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
