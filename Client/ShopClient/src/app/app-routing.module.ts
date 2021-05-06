import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './pages/about/about.component';
import { BlogViewComponent } from './pages/blog-view/blog-view.component';
import { BlogsComponent } from './pages/blogs/blogs.component';
import { ContactComponent } from './pages/contact/contact.component';
import { FaqComponent } from './pages/faq/faq.component';
import { HomeComponent } from './pages/home/home.component';
import { LayoutComponent } from './pages/layout/layout.component';
import { LoginComponent } from './pages/login/login.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { ProductComponent } from './pages/product/product.component';
import { RulesComponent } from './pages/rules/rules.component';
import { SearchComponent } from './pages/search/search.component';
import { TestComponent } from './pages/test/test.component';
import { AddressComponent } from './pages/user/address/address.component';
import { CartComponent } from './pages/user/cart/cart.component';
import { ChangePasswordComponent } from './pages/user/change-password/change-password.component';
import { CompareComponent } from './pages/user/compare/compare.component';
import { DashboardComponent } from './pages/user/dashboard/dashboard.component';
import { OrderCompletedComponent } from './pages/user/order-completed/order-completed.component';
import { OrdersComponent } from './pages/user/orders/orders.component';
import { ProfileComponent } from './pages/user/profile/profile.component';
import { UserLayoutComponent } from './pages/user/user-layout/user-layout.component';
import { WishlistComponent } from './pages/user/wishlist/wishlist.component';

const routes: Routes = [
  {
    // ROOT
    path: '', component: LayoutComponent,
    children: [
      { path: '', component: HomeComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'about', component: AboutComponent },
      { path: 'rules', component: RulesComponent },
      { path: 'faq', component: FaqComponent },
      { path: 'blog/:id', component: BlogViewComponent },
      { path: 'blog', component: BlogsComponent },
      // { path: 'product', redirectTo: 'search' },
      { path: 'product/:id', component: ProductComponent },
      { path: 'product', component: ProductComponent },
      { path: 'search', component: SearchComponent },
      { path: 'cart', component: CartComponent },
      { path: 'compare', component: CompareComponent },
      { path: 'wishlist', component: WishlistComponent },
      { path: 'login', component: LoginComponent },
      {
        path: 'user', component: UserLayoutComponent,
        children: [
          { path: '', component: DashboardComponent },
          { path: 'dashboard', redirectTo: '' },
          { path: 'orders', component: OrdersComponent },
          { path: 'profile', component: ProfileComponent },
          { path: 'address', component: AddressComponent },
          { path: 'changepassword', component: ChangePasswordComponent },
          { path: 'orderCompleted', component: OrderCompletedComponent },
        ]
      },

    ]
  },
  { path: 'test', component: TestComponent },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
