import { AfterViewInit, Component, ElementRef, OnInit, TemplateRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit, AfterViewInit {

  public searchText: string = '';

  constructor() { }

  ngOnInit(): void {
  }

  ngAfterViewInit(): void {
    document.querySelector('.sidetoggle')?.addEventListener('click', function () {
      document.head.classList.add('open');
      document.body.classList.add('sidetoggle_active');
      document.querySelector('.sidebar_menu')?.classList.add('active');
      // $("body").append('<div id="header-overlay" class="header-overlay"></div>');
    });
  }

}
