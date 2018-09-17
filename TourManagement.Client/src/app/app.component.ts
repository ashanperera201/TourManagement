import { Component } from '@angular/core';
import { } from "automapper-ts";
import { OpenIdConnectService } from './shared/open-id-connect.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Pluralsight Demo';

  constructor(private openIdConnectService: OpenIdConnectService) {

  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    var path = window.location.pathname
    if (path != '/signin-oidc') {
      if (!this.openIdConnectService.userAvailable) {
        this.openIdConnectService.triggerSignIn();
      }
    }
  }
}
