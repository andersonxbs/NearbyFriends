import { Http } from '@angular/http';

export class AuthService {
  constructor(private http: Http) {
  }

  login(credentials) {
    return this.http.post('/api/authenticate',
      JSON.stringify(credentials));
  }

  logout() {
  }

  isLoggedIn() {
    return false;
  }
}  
