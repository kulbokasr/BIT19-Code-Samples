import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { SchoolComponent } from './components/school/school.component';
import { SchoolListComponent } from './components/school-list/school-list.component';

@NgModule({
  declarations: [
    AppComponent,
    SchoolComponent,
    SchoolListComponent
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
