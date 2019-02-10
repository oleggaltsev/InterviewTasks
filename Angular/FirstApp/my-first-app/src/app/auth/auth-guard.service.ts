import {ActivatedRouteSnapshot, CanActivate, CanLoad, Route, RouterStateSnapshot, UrlSegment} from '@angular/router';
import {AuthService} from './auth.service';
import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';

@Injectable()
export class AuthGuard implements CanActivate, CanLoad {
   constructor(private authService: AuthService) {}
   canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    return this.authService.isAuthenticated();
  }
  canLoad(route: Route, segments: UrlSegment[]): Observable<boolean> | Promise<boolean> | boolean {
    return this.authService.isAuthenticated();
  }
}
