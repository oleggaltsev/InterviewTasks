import {Component, OnInit, ViewEncapsulation} from '@angular/core';
import * as firebase from 'firebase';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements  OnInit {
  ngOnInit(): void {
    firebase.initializeApp({
      apiKey: 'AIzaSyCA1FNSLdctTfeMcSIiIhnO8fIsSbM_oZM',
      authDomain: 'shopping-list-c97c5.firebaseapp.com'
    });
  }
}
