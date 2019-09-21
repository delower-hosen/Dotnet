import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.scss']
})
export class ValueComponent implements OnInit {

  public values: any;

  constructor(
    private _http: HttpClient
  ) { }

  ngOnInit() {
    this.getValues();
  }

  getValues() {
    debugger;
    this._http.get('http://localhost:5000/api/values').subscribe(res=>{
    this.values = res;
    console.log(this.values);
    })
  }

}
