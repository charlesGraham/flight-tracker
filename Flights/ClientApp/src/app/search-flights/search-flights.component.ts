import { Component, OnInit } from '@angular/core';
import { Time } from '@angular/common';
import { FlightService } from '../api/services';
import { FlightRm } from '../api/models';
@Component({
  selector: 'app-search-flights',
  templateUrl: './search-flights.component.html',
  styleUrls: ['./search-flights.component.css']
})
export class SearchFlightsComponent implements OnInit {


  searchResults: FlightRm[] = [];

  constructor(private flightService: FlightService) { }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

}

