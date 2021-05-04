import { Component, OnInit } from '@angular/core';
import { VmHomeSlider } from 'src/app/models/vm/VmHomeSlider';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.scss']
})
export class SliderComponent implements OnInit {

  slides: VmHomeSlider[] = [];

  constructor(private homeService: HomeService) { }

  ngOnInit(): void {
    this.homeService.GetSliders1().subscribe(i => this.slides = i.splice(0,3));
  }

}
