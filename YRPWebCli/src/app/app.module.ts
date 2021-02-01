import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';

import { DashboardComponent } from './Dashboard/dashboard.component';
import { AppComponent } from './app.component';

const appRoutes: Routes = [
    {path: '', component: DashboardComponent}
]

@NgModule({
    imports:[BrowserModule, RouterModule.forRoot(appRoutes)],
    declarations: [ AppComponent, DashboardComponent],
    exports: [RouterModule],
    providers: [],
    bootstrap:[AppComponent]
})

export class AppModule {}