import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss']
})
export class MapComponent implements OnInit {

  @Input("zoom")
  public zoom: number = 14;
  @Input("latitude")
  public latitude: number = 35.804357;
  @Input("longitude")
  public longitude: number = 51.414715;

  constructor() { }

  ngOnInit(): void {
    // TODO: Map logic here
  }

}
