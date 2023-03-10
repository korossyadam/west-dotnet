import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { MainNavigationComponent } from './main-navigation/main-navigation.component';
import { ProductListComponent } from './product-list/product-list.component';

import { HttpClientModule } from '@angular/common/http';

import { MatCardModule } from  '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input'
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatStepperModule } from '@angular/material/stepper';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatDialogModule } from '@angular/material/dialog';
import { MatTreeModule } from '@angular/material/tree';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatRadioModule } from '@angular/material/radio';
import { MatTabsModule } from '@angular/material/tabs';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatTableModule } from '@angular/material/table';
import { MatSortModule } from '@angular/material/sort';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';

import { SidenavComponent } from './sidenav/sidenav.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { CartComponent } from './cart/cart.component';
import { CategoriesComponent } from './categories/categories.component';
import { OfferComponent } from './offer/offer.component';
import { CarComponent } from './car/car.component';
import { ProductComponent } from './product/product.component';
import { FeaturedColumnsComponent } from './featured-columns/featured-columns.component';
import { FeaturedRowsComponent } from './featured-rows/featured-rows.component';
import { AdminComponent } from './admin/admin.component';
import { Categories2Component } from './categories2/categories2.component';
import { FeaturedCategoriesComponent } from './featured-categories/featured-categories.component';
import { OrderDialogComponent } from './dialogs/order-dialog/order-dialog.component';
import { OfferDialogComponent } from './dialogs/offer-dialog/offer-dialog.component';
import { InfoComponent } from './info/info.component';
import { OverviewComponent } from './cart/overview/overview.component';
import { FormComponent } from './cart/form/form.component';
import { ConfirmationComponent } from './cart/confirmation/confirmation.component';


@NgModule({
  declarations: [
    MainNavigationComponent,
    ProductListComponent,
    SidenavComponent,
    LoginComponent,
    ProfileComponent,
    HomeComponent,
    FooterComponent,
    CartComponent,
    OfferComponent,
    CarComponent,
    ProductComponent,
    FeaturedColumnsComponent,
    FeaturedRowsComponent,
    CategoriesComponent,
    AdminComponent,
    Categories2Component,
    FeaturedCategoriesComponent,
    OrderDialogComponent,
    OfferDialogComponent,
    InfoComponent,
    OverviewComponent,
    FormComponent,
    ConfirmationComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatCardModule,
    MatIconModule,
    MatDividerModule,
    MatButtonModule,
    MatInputModule,
    MatCheckboxModule,
    MatProgressSpinnerModule,
    MatStepperModule,
    MatExpansionModule,
    MatDialogModule,
    MatTreeModule,
    MatProgressBarModule,
    MatRadioModule,
    MatTabsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatSnackBarModule,
    MatTableModule,
    MatSortModule,
    MatSelectModule,
    MatFormFieldModule,
    MatSidenavModule
  ],
  providers: [],
  bootstrap: [SidenavComponent]
})
export class AppModule { }
