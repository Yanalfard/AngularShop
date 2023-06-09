//#region Modules

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';

//#endregion

//#region Components

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { NewsletterComponent } from './components/footer/newsletter/newsletter.component';
import { HomeComponent } from './pages/home/home.component';
import { PreloaderComponent } from './components/preloader/preloader.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { BreadcrumbComponent } from './components/breadcrumb/breadcrumb.component';
import { LayoutComponent } from './pages/layout/layout.component';
import { ContactComponent } from './pages/contact/contact.component';
import { AboutComponent } from './pages/about/about.component';
import { FaqComponent } from './pages/faq/faq.component';
import { RulesComponent } from './pages/rules/rules.component';
import { BlogsComponent } from './pages/blogs/blogs.component';
import { BlogViewComponent } from './pages/blog-view/blog-view.component';
import { SearchComponent } from './pages/search/search.component';
import { CheckoutComponent } from './pages/checkout/checkout.component';
import { LoginComponent } from './pages/login/login.component';
import { DashboardComponent } from './pages/user/dashboard/dashboard.component';
import { OrdersComponent } from './pages/user/orders/orders.component';
import { AddressComponent } from './pages/user/address/address.component';
import { ProfileComponent } from './pages/user/profile/profile.component';
import { ChangePasswordComponent } from './pages/user/change-password/change-password.component';
import { OrderCompletedComponent } from './pages/user/order-completed/order-completed.component';
import { WishlistComponent } from './pages/user/wishlist/wishlist.component';
import { CartComponent } from './pages/user/cart/cart.component';
import { UserLayoutComponent } from './pages/user/user-layout/user-layout.component';
import { UserNavigationComponent } from './pages/user/user-navigation/user-navigation.component';
import { MapComponent } from './components/map/map.component';
import { ProductComponent } from './pages/product/product.component';
import { SliderComponent } from './pages/home/slider/slider.component';
import { TabbedProductsComponent } from './pages/home/tabbed-products/tabbed-products.component';
import { TodaysSalesComponent } from './pages/home/todays-sales/todays-sales.component';
import { TileProductsComponent } from './pages/home/tile-products/tile-products.component';
import { BrandsComponent } from './pages/home/brands/brands.component';
import { ProductBlockComponent } from './components/product-block/product-block.component';
import { ProductTileComponent } from './components/product-tile/product-tile.component';
import { SaleBannerComponent } from './pages/home/sale-banner/sale-banner.component';
import { BlogBlockComponent } from './components/blog-block/blog-block.component';
import { BlogSidebarComponent } from './components/blog-sidebar/blog-sidebar.component';
import { RecentBlogBlockComponent } from './components/blog-sidebar/recent-blog-block/recent-blog-block.component';
import { ArchiveComponent } from './components/blog-sidebar/archive/archive.component';
import { ShopBannerComponent } from './components/blog-sidebar/shop-banner/shop-banner.component';
import { TagComponent } from './components/blog-sidebar/tag/tag.component';
import { BlogCommentInfoComponent } from './components/blog-comment-info/blog-comment-info.component';
import { HeaderBannerComponent } from './components/header/header-banner/header-banner.component';
import { SingleBannerComponent } from './pages/home/single-banner/single-banner.component';
import { ProductImageGalleryComponent } from './components/product-image-gallery/product-image-gallery.component';
import { ProductDetailComponent } from './components/product-detail/product-detail.component';
import { ProductCommentComponent } from './components/product-comment/product-comment.component';
import { ProductAdditionalInfoComponent } from './components/product-additional-info/product-additional-info.component';
import { DiscountPipe } from './pipes/discount.pipe';
import { TestComponent } from './pages/test/test.component';
import { ImgFallbackDirective } from './directives/img-fallback.directive';

//#endregion

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NewsletterComponent,
    HomeComponent,
    PreloaderComponent,
    NotFoundComponent,
    BreadcrumbComponent,
    LayoutComponent,
    ContactComponent,
    AboutComponent,
    FaqComponent,
    RulesComponent,
    BlogsComponent,
    BlogViewComponent,
    SearchComponent,
    CheckoutComponent,
    LoginComponent,
    DashboardComponent,
    OrdersComponent,
    AddressComponent,
    ProfileComponent,
    ChangePasswordComponent,
    OrderCompletedComponent,
    WishlistComponent,
    CartComponent,
    UserLayoutComponent,
    UserNavigationComponent,
    MapComponent,
    ProductComponent,
    SliderComponent,
    TabbedProductsComponent,
    TodaysSalesComponent,
    TileProductsComponent,
    BrandsComponent,
    ProductBlockComponent,
    ProductTileComponent,
    SaleBannerComponent,
    BlogBlockComponent,
    BlogSidebarComponent,
    RecentBlogBlockComponent,
    ArchiveComponent,
    ShopBannerComponent,
    TagComponent,
    BlogCommentInfoComponent,
    HeaderBannerComponent,
    SingleBannerComponent,
    ProductImageGalleryComponent,
    ProductDetailComponent,
    ProductCommentComponent,
    ProductAdditionalInfoComponent,
    DiscountPipe,
    TestComponent,
    ImgFallbackDirective,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
