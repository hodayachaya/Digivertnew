import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './component/home/home.component';
import { LogInComponent } from './component/log-in/log-in.component';
import { UserComponent } from './component/user/user.component';
import { NavComponent } from './component/nav/nav.component';
import { RegisterComponent } from './component/register/register.component';
import { ProjectComponent } from './component/project/project.component';

@NgModule({
  declarations: [

    AppComponent,
    HomeComponent,
    LogInComponent,
    RegisterComponent,
    UserComponent,
    NavComponent,
    ProjectComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule

  ],
  providers: [],
  bootstrap: [AppComponent,


  ],
  exports: [RouterModule],
})
export class AppModule { }
