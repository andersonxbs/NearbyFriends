"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var AuthService = /** @class */ (function () {
    function AuthService(http) {
        this.http = http;
    }
    AuthService.prototype.login = function (credentials) {
        return this.http.post('/api/authenticate', JSON.stringify(credentials));
    };
    AuthService.prototype.logout = function () {
    };
    AuthService.prototype.isLoggedIn = function () {
        return false;
    };
    return AuthService;
}());
exports.AuthService = AuthService;
//# sourceMappingURL=AuthService.js.map