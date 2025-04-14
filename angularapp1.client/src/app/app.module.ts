import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GetAllComponent } from './component/get-all/get-all.component';
import { GetbyidComponent } from './component/getbyid/getbyid.component';
import { AddnewprComponent } from './component/addnewpr/addnewpr.component';
import { EditproComponent } from './component/editpro/editpro.component';
import { DeleteComponent } from './component/delete/delete.component';
import { DashComponent } from './dash/dash.component';

@NgModule({
  declarations: [
    AppComponent,
    GetAllComponent,
    GetbyidComponent,
    AddnewprComponent,
    EditproComponent,
    DeleteComponent,
    DashComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
