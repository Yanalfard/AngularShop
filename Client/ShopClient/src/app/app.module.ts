import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { NewsletterComponent } from './components/footer/newsletter/newsletter.component';
import { HomeComponent } from './pages/home/home.component';
import { PreloaderComponent } from './components/preloader/preloader.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { BreadcrumbComponent } from './components/breadcrumb/breadcrumb.component';



@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NewsletterComponent,
    HomeComponent,
    PreloaderComponent,
    NotFoundComponent,
    BreadcrumbComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
