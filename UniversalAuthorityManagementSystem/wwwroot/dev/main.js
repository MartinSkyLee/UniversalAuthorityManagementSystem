(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _app_pages_application_application_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../app/pages/application/application.component */ "./src/app/pages/application/application.component.ts");
/* harmony import */ var _app_pages_login_login_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../app/pages/login/login.component */ "./src/app/pages/login/login.component.ts");
/* harmony import */ var _app_layout_default_default_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../app/layout/default/default.component */ "./src/app/layout/default/default.component.ts");
/* harmony import */ var _pages_menu_menu_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./pages/menu/menu.component */ "./src/app/pages/menu/menu.component.ts");
/* harmony import */ var _pages_role_role_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./pages/role/role.component */ "./src/app/pages/role/role.component.ts");
/* harmony import */ var _pages_permission_permission_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./pages/permission/permission.component */ "./src/app/pages/permission/permission.component.ts");
/* harmony import */ var _pages_user_user_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./pages/user/user.component */ "./src/app/pages/user/user.component.ts");
/* harmony import */ var _shared_auth_auth_guard__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./shared/auth/auth.guard */ "./src/app/shared/auth/auth.guard.ts");











var routes = [
    {
        path: '',
        component: _app_layout_default_default_component__WEBPACK_IMPORTED_MODULE_5__["DefaultComponent"],
        children: [
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: _app_pages_application_application_component__WEBPACK_IMPORTED_MODULE_3__["ApplicationComponent"] },
            { path: 'menu', component: _pages_menu_menu_component__WEBPACK_IMPORTED_MODULE_6__["MenuComponent"] },
            { path: 'role', component: _pages_role_role_component__WEBPACK_IMPORTED_MODULE_7__["RoleComponent"] },
            { path: 'permission', component: _pages_permission_permission_component__WEBPACK_IMPORTED_MODULE_8__["PermissionComponent"] },
            { path: 'user', component: _pages_user_user_component__WEBPACK_IMPORTED_MODULE_9__["UserComponent"] },
        ],
        canActivate: [_shared_auth_auth_guard__WEBPACK_IMPORTED_MODULE_10__["AuthGuard"]]
    },
    { path: 'login', component: _app_pages_login_login_component__WEBPACK_IMPORTED_MODULE_4__["LoginComponent"] },
];
// { useHash: true }
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
            providers: [_shared_auth_auth_guard__WEBPACK_IMPORTED_MODULE_10__["AuthGuard"]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<router-outlet></router-outlet>"

/***/ }),

/***/ "./src/app/app.component.less":
/*!************************************!*\
  !*** ./src/app/app.component.less ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQubGVzcyJ9 */"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");
/* harmony import */ var _auth_config__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./auth.config */ "./src/app/auth.config.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");







var AppComponent = /** @class */ (function () {
    function AppComponent(authService, router, routerActive, _iconService) {
        this.authService = authService;
        this.router = router;
        this.routerActive = routerActive;
        this._iconService = _iconService;
        //设置iconfont
        this._iconService.fetchFromIconfont({
            scriptUrl: '//at.alicdn.com/t/font_1147472_93eqn4uhz5.js'
        });
        this.authService.configure(_auth_config__WEBPACK_IMPORTED_MODULE_3__["authConfig"]);
        this.authService.tokenValidationHandler = new angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_2__["JwksValidationHandler"]();
        this.authService.loadDiscoveryDocumentAndLogin();
    }
    AppComponent.prototype.ngOnInit = function () {
    };
    AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.less */ "./src/app/app.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_2__["OAuthService"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["Router"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["ActivatedRoute"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NzIconService"]])
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_common_locales_zh__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @angular/common/locales/zh */ "./node_modules/@angular/common/locales/zh.js");
/* harmony import */ var _angular_common_locales_zh__WEBPACK_IMPORTED_MODULE_10___default = /*#__PURE__*/__webpack_require__.n(_angular_common_locales_zh__WEBPACK_IMPORTED_MODULE_10__);
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");
/* harmony import */ var _blocks_nav_nav_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./blocks/nav/nav.component */ "./src/app/blocks/nav/nav.component.ts");
/* harmony import */ var _pages_application_application_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./pages/application/application.component */ "./src/app/pages/application/application.component.ts");
/* harmony import */ var _blocks_premission_premission_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./blocks/premission/premission.component */ "./src/app/blocks/premission/premission.component.ts");
/* harmony import */ var _blocks_search_search_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./blocks/search/search.component */ "./src/app/blocks/search/search.component.ts");
/* harmony import */ var _pages_login_login_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./pages/login/login.component */ "./src/app/pages/login/login.component.ts");
/* harmony import */ var _layout_default_default_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./layout/default/default.component */ "./src/app/layout/default/default.component.ts");
/* harmony import */ var _pages_menu_menu_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./pages/menu/menu.component */ "./src/app/pages/menu/menu.component.ts");
/* harmony import */ var _pages_role_role_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./pages/role/role.component */ "./src/app/pages/role/role.component.ts");
/* harmony import */ var _pages_permission_permission_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./pages/permission/permission.component */ "./src/app/pages/permission/permission.component.ts");
/* harmony import */ var _pages_user_user_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./pages/user/user.component */ "./src/app/pages/user/user.component.ts");
/* harmony import */ var _blocks_role_cascader_role_cascader_component__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./blocks/role-cascader/role-cascader.component */ "./src/app/blocks/role-cascader/role-cascader.component.ts");























Object(_angular_common__WEBPACK_IMPORTED_MODULE_9__["registerLocaleData"])(_angular_common_locales_zh__WEBPACK_IMPORTED_MODULE_10___default.a);
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"],
                _blocks_nav_nav_component__WEBPACK_IMPORTED_MODULE_12__["NavComponent"],
                _pages_application_application_component__WEBPACK_IMPORTED_MODULE_13__["ApplicationComponent"],
                _blocks_premission_premission_component__WEBPACK_IMPORTED_MODULE_14__["PremissionComponent"],
                _blocks_search_search_component__WEBPACK_IMPORTED_MODULE_15__["SearchComponent"],
                _pages_login_login_component__WEBPACK_IMPORTED_MODULE_16__["LoginComponent"],
                _layout_default_default_component__WEBPACK_IMPORTED_MODULE_17__["DefaultComponent"],
                _pages_menu_menu_component__WEBPACK_IMPORTED_MODULE_18__["MenuComponent"],
                _pages_role_role_component__WEBPACK_IMPORTED_MODULE_19__["RoleComponent"],
                _pages_permission_permission_component__WEBPACK_IMPORTED_MODULE_20__["PermissionComponent"],
                _pages_user_user_component__WEBPACK_IMPORTED_MODULE_21__["UserComponent"],
                _blocks_role_cascader_role_cascader_component__WEBPACK_IMPORTED_MODULE_22__["RoleCascaderComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
                _app_routing_module__WEBPACK_IMPORTED_MODULE_3__["AppRoutingModule"],
                ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NgZorroAntdModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormsModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_6__["ReactiveFormsModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_7__["HttpClientModule"],
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_8__["BrowserAnimationsModule"],
                angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_11__["OAuthModule"].forRoot({
                    resourceServer: {
                        allowedUrls: ['http://10.9.53.103:5101/'],
                        sendAccessToken: true
                    }
                })
            ],
            providers: [{ provide: ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NZ_I18N"], useValue: ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["zh_CN"] }],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/auth-password-flow.config.ts":
/*!**********************************************!*\
  !*** ./src/app/auth-password-flow.config.ts ***!
  \**********************************************/
/*! exports provided: authPasswordFlowConfig */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "authPasswordFlowConfig", function() { return authPasswordFlowConfig; });
// // This api will come in the next version
var authPasswordFlowConfig = {
    // Url of the Identity Provider
    issuer: 'https://steyer-identity-server.azurewebsites.net/identity',
    // URL of the SPA to redirect the user to after login
    redirectUri: window.location.origin + '/index.html',
    // URL of the SPA to redirect the user after silent refresh
    silentRefreshRedirectUri: window.location.origin + '/silent-refresh.html',
    // The SPA's id. The SPA is registerd with this id at the auth-server
    clientId: 'demo-resource-owner',
    dummyClientSecret: 'geheim',
    // set the scope for the permissions the client should request
    // The first three are defined by OIDC. The 4th is a usecase-specific one
    scope: 'openid profile email voucher',
    showDebugInformation: true,
    oidc: false
};


/***/ }),

/***/ "./src/app/auth.config.ts":
/*!********************************!*\
  !*** ./src/app/auth.config.ts ***!
  \********************************/
/*! exports provided: authConfig */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "authConfig", function() { return authConfig; });
// export const authConfig: AuthConfig = {
//     // Url of the Identity Provider
//     issuer: 'https://steyer-identity-server.azurewebsites.net/identity',
//     // URL of the SPA to redirect the user to after login
//     redirectUri: window.location.origin + '/index.html',
//     // The SPA's id. The SPA is registerd with this id at the auth-server
//     clientId: 'spa-demo',
//     // set the scope for the permissions the client should request
//     // The first three are defined by OIDC. The 4th is a usecase-specific one
//     scope: 'openid profile email voucher',
//     dummyClientSecret: 'geheim',
// }
var authConfig = {
    // Url of the Identity Provider
    issuer: 'http://10.9.53.103:5100',
    // URL of the SPA to redirect the user to after login
    redirectUri: window.location.origin + '/index.html',
    // The SPA's id. The SPA is registerd with this id at the auth-server
    // clientId: 'angular',
    clientId: 'uamc',
    // set the scope for the permissions the client should request
    // The first three are defined by OIDC. The 4th is a usecase-specific one
    scope: 'openid profile api_angular',
    requireHttps: false
};


/***/ }),

/***/ "./src/app/blocks/nav/nav.component.html":
/*!***********************************************!*\
  !*** ./src/app/blocks/nav/nav.component.html ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\n  nav works!\n</p>\n"

/***/ }),

/***/ "./src/app/blocks/nav/nav.component.less":
/*!***********************************************!*\
  !*** ./src/app/blocks/nav/nav.component.less ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2Jsb2Nrcy9uYXYvbmF2LmNvbXBvbmVudC5sZXNzIn0= */"

/***/ }),

/***/ "./src/app/blocks/nav/nav.component.ts":
/*!*********************************************!*\
  !*** ./src/app/blocks/nav/nav.component.ts ***!
  \*********************************************/
/*! exports provided: NavComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NavComponent", function() { return NavComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var NavComponent = /** @class */ (function () {
    function NavComponent() {
    }
    NavComponent.prototype.ngOnInit = function () {
    };
    NavComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-nav',
            template: __webpack_require__(/*! ./nav.component.html */ "./src/app/blocks/nav/nav.component.html"),
            styles: [__webpack_require__(/*! ./nav.component.less */ "./src/app/blocks/nav/nav.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], NavComponent);
    return NavComponent;
}());



/***/ }),

/***/ "./src/app/blocks/premission/premission.component.html":
/*!*************************************************************!*\
  !*** ./src/app/blocks/premission/premission.component.html ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- 列表操作权限 -->\n<button nz-button nzType=\"primary\" (click)=\"add()\" *ngIf=\"server.premissions.hasAddPremission && (place=='top' && !hasSave)\" style=\"margin-left:10px;\">新增</button>\n<button nz-button nzType=\"primary\" (click)=\"save()\" *ngIf=\"server.premissions.hasSavePremission && (place=='top' && hasSave)\" style=\"margin-left:10px;\">保存</button>\n<button nz-button nzType=\"primary\" (click)=\"addDataType()\"\n  *ngIf=\"server.premissions.hasAddDataTypePremission && place=='top'\" style=\"margin-left:10px;\">新增数据类型</button>\n<button nz-button nzType=\"primary\" (click)=\"addDataProject()\"\n  *ngIf=\"server.premissions.hasAddDataProjectPremission && place=='top'\" style=\"margin-left:10px;\">新增数据项目</button>\n\n<button nz-button nzType=\"primary\" (click)=\"addMenu()\" *ngIf=\"server.premissions.hasAddMenuPremission && place=='top'\" style=\"margin-left:10px;\">新增菜单</button>\n<button nz-button nzType=\"primary\" (click)=\"addPremission()\"\n  *ngIf=\"server.premissions.hasAddPrePremission && place=='top'\" style=\"margin-left:10px;\">新增权限</button>\n\n<div class=\"editable-row-operations\" *ngIf=\"place=='list'\">\n  <ng-container *ngIf=\"server.premissions.hasAddDataTypePremission && hasRead\">\n    <a (click)=\"read()\">查看</a>\n  </ng-container>\n  <s nztype=\"vertical\" class=\"ant-divider ant-divider-vertical ng-star-inserted\" ng-reflect-nz-type=\"vertical\" *ngIf=\"server.premissions.hasAddDataTypePremission && hasRead\"></s>\n  <ng-container *ngIf=\"server.premissions.hasUpdatePremission\">\n    <a (click)=\"update()\">编辑</a>\n  </ng-container>\n  <s nztype=\"vertical\" class=\"ant-divider ant-divider-vertical ng-star-inserted\" ng-reflect-nz-type=\"vertical\" *ngIf=\"server.premissions.hasDeletePremission\"\n  ></s>\n  <nz-popconfirm [nzTitle]=\"'确定删除吗?'\" (nzOnConfirm)=\"delete()\" *ngIf=\"server.premissions.hasDeletePremission\">\n    <a nz-popconfirm>删除</a>\n  </nz-popconfirm>\n</div>"

/***/ }),

/***/ "./src/app/blocks/premission/premission.component.less":
/*!*************************************************************!*\
  !*** ./src/app/blocks/premission/premission.component.less ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2Jsb2Nrcy9wcmVtaXNzaW9uL3ByZW1pc3Npb24uY29tcG9uZW50Lmxlc3MifQ== */"

/***/ }),

/***/ "./src/app/blocks/premission/premission.component.ts":
/*!***********************************************************!*\
  !*** ./src/app/blocks/premission/premission.component.ts ***!
  \***********************************************************/
/*! exports provided: PremissionComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PremissionComponent", function() { return PremissionComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");



var PremissionComponent = /** @class */ (function () {
    function PremissionComponent(server) {
        this.server = server;
        this.addFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.readFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.updateFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.deleteFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.saveFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.addMenuFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.addPreFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
    }
    PremissionComponent.prototype.ngOnInit = function () {
    };
    PremissionComponent.prototype.add = function () {
        this.addFtn.emit();
    };
    PremissionComponent.prototype.read = function () {
        this.readFtn.emit();
    };
    PremissionComponent.prototype.update = function () {
        this.updateFtn.emit();
    };
    PremissionComponent.prototype.delete = function () {
        this.deleteFtn.emit();
    };
    PremissionComponent.prototype.save = function () {
        this.saveFtn.emit();
    };
    //新增菜单
    PremissionComponent.prototype.addMenu = function () {
        this.addMenuFtn.emit();
    };
    //新增权限
    PremissionComponent.prototype.addPremission = function () {
        this.addPreFtn.emit();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('add'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "addFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('read'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "readFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('update'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "updateFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('delete'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "deleteFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('save'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "saveFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('addMenu'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "addMenuFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('addPremission'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "addPreFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PremissionComponent.prototype, "place", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean)
    ], PremissionComponent.prototype, "hasRead", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean)
    ], PremissionComponent.prototype, "hasSave", void 0);
    PremissionComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-premission',
            template: __webpack_require__(/*! ./premission.component.html */ "./src/app/blocks/premission/premission.component.html"),
            styles: [__webpack_require__(/*! ./premission.component.less */ "./src/app/blocks/premission/premission.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_2__["ServersService"]])
    ], PremissionComponent);
    return PremissionComponent;
}());



/***/ }),

/***/ "./src/app/blocks/role-cascader/role-cascader.component.html":
/*!*******************************************************************!*\
  !*** ./src/app/blocks/role-cascader/role-cascader.component.html ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nz-cascader [(ngModel)]=\"values\" nzPlaceHolder=\"{{label}}\" [nzLoadData]=\"loadData\" (nzSelect) = onChanges($event) [nzChangeOnSelect]=\"true\"\n  [nzAllowClear]=\"false\">\n</nz-cascader>"

/***/ }),

/***/ "./src/app/blocks/role-cascader/role-cascader.component.less":
/*!*******************************************************************!*\
  !*** ./src/app/blocks/role-cascader/role-cascader.component.less ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "input {\n  border: 0;\n  outline: none;\n  height: 26px;\n  line-height: 26px;\n  padding: 0 40px 0 10px;\n  border-radius: 2px;\n}\n.btn {\n  position: absolute;\n  padding: 0 7px;\n  top: 0;\n  right: -2px;\n  background-color: #007AFF;\n  color: #fff;\n  line-height: 26px;\n  border: 0;\n  border-radius: 0 2px 2px 0;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9saXRlbmcvQXBwL3Blcm1pc3Npb25zLXN5c3RlbS1mcm9udEVuZC9zcmMvYXBwL2Jsb2Nrcy9yb2xlLWNhc2NhZGVyL3JvbGUtY2FzY2FkZXIuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL2Jsb2Nrcy9yb2xlLWNhc2NhZGVyL3JvbGUtY2FzY2FkZXIuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBR0E7RUFDSSxTQUFBO0VBQ0EsYUFBQTtFQUNBLFlBQUE7RUFDQSxpQkFBQTtFQUNBLHNCQUFBO0VBQ0Esa0JBQUE7QUNGSjtBRElBO0VBQ0ksa0JBQUE7RUFDQSxjQUFBO0VBQ0EsTUFBQTtFQUNBLFdBQUE7RUFDQSx5QkFBQTtFQUNBLFdBQUE7RUFDQSxpQkFBQTtFQUNBLFNBQUE7RUFDQSwwQkFBQTtBQ0ZKIiwiZmlsZSI6InNyYy9hcHAvYmxvY2tzL3JvbGUtY2FzY2FkZXIvcm9sZS1jYXNjYWRlci5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIkBiYXNlQ29sb3I6IzFDNDg5MztcbkBhY3RpdmVDb2xvcjojMDA3QUZGO1xuQHdoaXRlOiNmZmY7XG5pbnB1dHtcbiAgICBib3JkZXI6MDtcbiAgICBvdXRsaW5lOiBub25lO1xuICAgIGhlaWdodDogMjZweDtcbiAgICBsaW5lLWhlaWdodDogMjZweDtcbiAgICBwYWRkaW5nOiAwIDQwcHggMCAxMHB4O1xuICAgIGJvcmRlci1yYWRpdXM6IDJweDtcbn1cbi5idG57XG4gICAgcG9zaXRpb246IGFic29sdXRlO1xuICAgIHBhZGRpbmc6IDAgN3B4O1xuICAgIHRvcDogMDtcbiAgICByaWdodDogLTJweDtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiBAYWN0aXZlQ29sb3I7XG4gICAgY29sb3I6QHdoaXRlO1xuICAgIGxpbmUtaGVpZ2h0OiAyNnB4O1xuICAgIGJvcmRlcjogMDtcbiAgICBib3JkZXItcmFkaXVzOiAwIDJweCAycHggMDtcbn1cbiIsImlucHV0IHtcbiAgYm9yZGVyOiAwO1xuICBvdXRsaW5lOiBub25lO1xuICBoZWlnaHQ6IDI2cHg7XG4gIGxpbmUtaGVpZ2h0OiAyNnB4O1xuICBwYWRkaW5nOiAwIDQwcHggMCAxMHB4O1xuICBib3JkZXItcmFkaXVzOiAycHg7XG59XG4uYnRuIHtcbiAgcG9zaXRpb246IGFic29sdXRlO1xuICBwYWRkaW5nOiAwIDdweDtcbiAgdG9wOiAwO1xuICByaWdodDogLTJweDtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzAwN0FGRjtcbiAgY29sb3I6ICNmZmY7XG4gIGxpbmUtaGVpZ2h0OiAyNnB4O1xuICBib3JkZXI6IDA7XG4gIGJvcmRlci1yYWRpdXM6IDAgMnB4IDJweCAwO1xufVxuIl19 */"

/***/ }),

/***/ "./src/app/blocks/role-cascader/role-cascader.component.ts":
/*!*****************************************************************!*\
  !*** ./src/app/blocks/role-cascader/role-cascader.component.ts ***!
  \*****************************************************************/
/*! exports provided: RoleCascaderComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RoleCascaderComponent", function() { return RoleCascaderComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");





var parents = [];
var childs = {};
var RoleCascaderComponent = /** @class */ (function () {
    function RoleCascaderComponent(server, http, router) {
        this.server = server;
        this.http = http;
        this.router = router;
        this.sendData = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.values = null;
    }
    RoleCascaderComponent.prototype.ngOnInit = function () {
        this.server.getAppList().subscribe(function (data) {
            parents.length = 0;
            data.forEach(function (element) {
                var obj = {
                    value: element.id,
                    label: element.label,
                    id: element.id
                };
                parents.push(obj);
            });
        });
    };
    RoleCascaderComponent.prototype.ngOnChanges = function (changes) {
        if (changes['cascadarData'] && changes['cascadarData'].currentValue) {
            this.values = this.cascadarData;
        }
    };
    //获取子列表
    RoleCascaderComponent.prototype.getChild = function (parentId) {
        this.server.getRoleList(parentId).subscribe(function (data) {
            var arr = [];
            data.forEach(function (element) {
                var obj = {
                    value: element.id,
                    label: element.label,
                    isLeaf: true
                };
                arr.push(obj);
            });
            if (arr.length == 0) {
                arr.push({
                    value: null,
                    label: '暂无数据',
                    isLeaf: true,
                    disabled: true,
                });
            }
            childs[parentId] = arr;
        });
    };
    //数据处理
    RoleCascaderComponent.prototype.loadData = function (node, index) {
        return new Promise(function (resolve) {
            setTimeout(function () {
                if (index < 0) { // if index less than 0 it is root node
                    node.children = parents;
                }
                else if (index === 0) {
                    node.children = childs[node.value];
                }
                resolve();
            }, 500);
        });
    };
    //点击选项
    RoleCascaderComponent.prototype.onChanges = function (values) {
        if (values.index == 0) {
            this.getChild(values.option.id);
        }
        else {
            this.sendData.emit(values.option);
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], RoleCascaderComponent.prototype, "label", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], RoleCascaderComponent.prototype, "cascadarData", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('sendData'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], RoleCascaderComponent.prototype, "sendData", void 0);
    RoleCascaderComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-role-cascader',
            template: __webpack_require__(/*! ./role-cascader.component.html */ "./src/app/blocks/role-cascader/role-cascader.component.html"),
            styles: [__webpack_require__(/*! ./role-cascader.component.less */ "./src/app/blocks/role-cascader/role-cascader.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_3__["ServersService"], _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["ActivatedRoute"]])
    ], RoleCascaderComponent);
    return RoleCascaderComponent;
}());



/***/ }),

/***/ "./src/app/blocks/search/search.component.html":
/*!*****************************************************!*\
  !*** ./src/app/blocks/search/search.component.html ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"search-block nz-row\">\n  <div nz-row nzType=\"flex\" nzJustify=\"end\">\n    <div class=\"pull-left\">\n      <div class=\"input-group\">\n        <div class=\"input-group-label\">\n          <nz-form-label>关键词</nz-form-label>\n        </div>\n        <div class=\"input-group-control\">\n          <input nz-input [(ngModel)]=\"keyword\" id=\"keyword\" name=\"keyword\" placeholder=\"请输入关键词\">\n        </div>\n      </div>\n    </div>\n    <div class=\"pull-left\">\n      <nz-form-control>\n        <button nz-button nzType=\"primary\" (click)=\"search()\" [nzLoading]=\"isLoading\" >查询</button>\n      </nz-form-control>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "./src/app/blocks/search/search.component.less":
/*!*****************************************************!*\
  !*** ./src/app/blocks/search/search.component.less ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".search-block {\n  display: inline-block;\n  position: relative;\n  padding-bottom: 1em;\n  z-index: 98;\n}\n.ant-btn {\n  margin-left: 1em;\n}\n.ant-row {\n  margin-bottom: 1em;\n}\n.input-group-label {\n  display: inline-block;\n}\n.ant-form-item-label label {\n  color: #000;\n}\n.ant-form-item-label {\n  text-align: right;\n  vertical-align: middle;\n  line-height: 40px;\n  display: inline-block;\n  overflow: hidden;\n  white-space: nowrap;\n}\n.input-group-control {\n  display: inline-block;\n  vertical-align: middle;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9saXRlbmcvQXBwL3Blcm1pc3Npb25zLXN5c3RlbS1mcm9udEVuZC9zcmMvYXBwL2Jsb2Nrcy9zZWFyY2gvc2VhcmNoLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9ibG9ja3Mvc2VhcmNoL3NlYXJjaC5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNJLHFCQUFBO0VBQ0Esa0JBQUE7RUFDQSxtQkFBQTtFQUNBLFdBQUE7QUNDSjtBRENBO0VBQ0ksZ0JBQUE7QUNDSjtBRENBO0VBQ0ksa0JBQUE7QUNDSjtBRENBO0VBQ0kscUJBQUE7QUNDSjtBRENBO0VBQ0ksV0FBQTtBQ0NKO0FEQ0E7RUFDSSxpQkFBQTtFQUNBLHNCQUFBO0VBQ0EsaUJBQUE7RUFDQSxxQkFBQTtFQUNBLGdCQUFBO0VBQ0EsbUJBQUE7QUNDSjtBRENBO0VBQ0kscUJBQUE7RUFDQSxzQkFBQTtBQ0NKIiwiZmlsZSI6InNyYy9hcHAvYmxvY2tzL3NlYXJjaC9zZWFyY2guY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuc2VhcmNoLWJsb2Nre1xuICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgICBwb3NpdGlvbjogcmVsYXRpdmU7XG4gICAgcGFkZGluZy1ib3R0b206IDFlbTtcbiAgICB6LWluZGV4OiA5ODtcbn1cbi5hbnQtYnRue1xuICAgIG1hcmdpbi1sZWZ0OiAxZW07XG59XG4uYW50LXJvd3tcbiAgICBtYXJnaW4tYm90dG9tOiAxZW07XG59XG4uaW5wdXQtZ3JvdXAtbGFiZWx7XG4gICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xufVxuLmFudC1mb3JtLWl0ZW0tbGFiZWwgbGFiZWx7XG4gICAgY29sb3I6ICMwMDA7XG59XG4uYW50LWZvcm0taXRlbS1sYWJlbCB7XG4gICAgdGV4dC1hbGlnbjogcmlnaHQ7XG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcbiAgICBsaW5lLWhlaWdodDogNDBweDtcbiAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gICAgb3ZlcmZsb3c6IGhpZGRlbjtcbiAgICB3aGl0ZS1zcGFjZTogbm93cmFwO1xufVxuLmlucHV0LWdyb3VwLWNvbnRyb2wge1xuICAgIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgICB2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO1xufSIsIi5zZWFyY2gtYmxvY2sge1xuICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gIHBvc2l0aW9uOiByZWxhdGl2ZTtcbiAgcGFkZGluZy1ib3R0b206IDFlbTtcbiAgei1pbmRleDogOTg7XG59XG4uYW50LWJ0biB7XG4gIG1hcmdpbi1sZWZ0OiAxZW07XG59XG4uYW50LXJvdyB7XG4gIG1hcmdpbi1ib3R0b206IDFlbTtcbn1cbi5pbnB1dC1ncm91cC1sYWJlbCB7XG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbn1cbi5hbnQtZm9ybS1pdGVtLWxhYmVsIGxhYmVsIHtcbiAgY29sb3I6ICMwMDA7XG59XG4uYW50LWZvcm0taXRlbS1sYWJlbCB7XG4gIHRleHQtYWxpZ246IHJpZ2h0O1xuICB2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO1xuICBsaW5lLWhlaWdodDogNDBweDtcbiAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xuICBvdmVyZmxvdzogaGlkZGVuO1xuICB3aGl0ZS1zcGFjZTogbm93cmFwO1xufVxuLmlucHV0LWdyb3VwLWNvbnRyb2wge1xuICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG59XG4iXX0= */"

/***/ }),

/***/ "./src/app/blocks/search/search.component.ts":
/*!***************************************************!*\
  !*** ./src/app/blocks/search/search.component.ts ***!
  \***************************************************/
/*! exports provided: SearchComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SearchComponent", function() { return SearchComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SearchComponent = /** @class */ (function () {
    function SearchComponent() {
        this.searchFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.addFtn = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.isLoading = false;
        this.keyword = '';
    }
    SearchComponent.prototype.ngOnInit = function () {
    };
    //搜索方法
    SearchComponent.prototype.search = function () {
        var _this = this;
        this.isLoading = true;
        this.searchFtn.emit(this.keyword);
        setTimeout(function () {
            _this.isLoading = false;
        }, 1000);
    };
    //新增方法
    SearchComponent.prototype.add = function () {
        this.addFtn.emit();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('search'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], SearchComponent.prototype, "searchFtn", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('add'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], SearchComponent.prototype, "addFtn", void 0);
    SearchComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-search',
            template: __webpack_require__(/*! ./search.component.html */ "./src/app/blocks/search/search.component.html"),
            styles: [__webpack_require__(/*! ./search.component.less */ "./src/app/blocks/search/search.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], SearchComponent);
    return SearchComponent;
}());



/***/ }),

/***/ "./src/app/layout/default/default.component.html":
/*!*******************************************************!*\
  !*** ./src/app/layout/default/default.component.html ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"app app-header-fixed\">\n  <nz-header [ngClass]=\"{'active': isCollapsed}\">\n    <div class=\"logo animated fadeInLeft\">\n      <span class=\"icon logo-img\">\n      </span>\n      <span class=\"campany-name animated fadeInLeft\" [routerLink]=\"[ '/dashboard' ]\">\n        {{systemName}}\n      </span>\n    </div>\n    <i class=\"trigger\" nz-icon [type]=\"isCollapsed ? 'menu-unfold' : 'menu-fold'\"\n      (click)=\"isCollapsed = !isCollapsed\"></i>\n    <ul class=\"nav navbar-nav navbar-right\">\n      <!-- <li>\n        <i nz-icon [nzType]=\"fullScreen?'shrink':'arrows-alt'\" nzTheme=\"outline\" (click)=\"fullScreen=!fullScreen\"></i>\n      </li> -->\n      <li>\n        <span class=\"msg\" (click)=\"openMsg()\">\n          <nz-badge [nzCount]=\"msgNum\">\n            <span class=\"head-example\"><i nz-icon nzType=\"message\" nzTheme=\"outline\"></i></span>\n          </nz-badge>\n        </span>\n      </li>\n      <li [ngClass]=\"{'active': userInfoActive}\">\n        <nz-avatar [nzText]=\"name\" nzSize=\"large\" [ngStyle]=\"{ 'background-color': color }\"\n          style=\"vertical-align: middle;\" (click)=\"userInfoActive = !userInfoActive\">\n        </nz-avatar>\n        <div class=\"userInfo animated fadeInRight\" *ngIf=\"userInfoActive\">\n          <ul>\n            <li>超级管理员</li>\n            <li>\n              <!-- <a (click)=\"login()\" *ngIf=\"!requestAccessToken\">登录</a> -->\n              <a nz-popconfirm nzTitle=\"您确定登出吗?\" (nzOnConfirm)=\"logout()\" (nzOnCancel)=\"cancel()\" nzPlacement=\"bottom\" *ngIf=\"requestAccessToken\">登出</a>\n            </li>\n          </ul>\n        </div>\n      </li>\n    </ul>\n  </nz-header>\n  <nz-layout>\n    <nz-sider nzCollapsible [(nzCollapsed)]=\"isCollapsed\"  [nzReverseArrow]=\"isReverseArrow\">\n      <ul nz-menu [nzTheme]=\"'dark'\" [nzMode]=\"'inline'\" [nzInlineCollapsed]=\"isCollapsed\" class=\"menu\">\n        <li nz-menu-item *ngFor=\"let item of menuData\" routerLinkActive=\"active\">\n          <a [routerLink]=\"item.url\" (click)=\"server.setPremission(item.menuId)\">\n            <i nz-icon type=\"{{item.icon}}\"></i>\n            <span class=\"nav-text\">{{item.menuName}}</span>\n          </a>\n        </li>\n      </ul>\n    </nz-sider>\n    <nz-layout>\n      <nz-content style=\"margin:0 16px;\n        \">\n        <router-outlet></router-outlet>\n      </nz-content>\n      <nz-footer style=\"text-align: center;\">©2019 上海达华测绘地理信息中心</nz-footer>\n    </nz-layout>\n    <ng-template #trigger>\n      <i nz-icon type=\"up\"></i>\n    </ng-template>\n  </nz-layout>\n</div>\n<!-- 消息列表 -->\n<nz-drawer [nzClosable]=\"false\" [nzOffsetX]=\"childrenVisible ? 180 : 0\" [nzWidth]=\"320\" [nzVisible]=\"visible\"\n  nzTitle=\"消息列表\" (nzOnClose)=\"close()\">\n  <nz-list [nzDataSource]=\"vegetables\" [nzRenderItem]=\"item\">\n    <ng-template #item let-item>\n      <nz-list-item [nzContent]=\"item\"></nz-list-item>\n    </ng-template>\n  </nz-list>\n  <div class=\"footer\" style=\"padding: 15px 0\">\n    <button type=\"button\" (click)=\"close()\" class=\"ant-btn\"><span>关闭</span></button>\n  </div>\n</nz-drawer>"

/***/ }),

/***/ "./src/app/layout/default/default.component.less":
/*!*******************************************************!*\
  !*** ./src/app/layout/default/default.component.less ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".app-header-fixed {\n  padding-top: 50px;\n}\nnz-header {\n  position: fixed;\n  left: 0;\n  top: 0;\n  height: 50px;\n  width: 100%;\n  padding: 0;\n  background-color: #fff;\n  box-shadow: 0 2px 2px rgba(0, 0, 0, 0.05), 0 1px 0 rgba(0, 0, 0, 0.05);\n  z-index: 99;\n}\nnz-header .trigger {\n  float: left;\n  font-size: 18px;\n  line-height: 50px;\n  padding: 0 24px;\n  cursor: pointer;\n  transition: color 0.3s;\n  vertical-align: inherit;\n  color: rgba(0, 0, 0, 0.65);\n}\nnz-header .trigger:hover {\n  color: #1890ff;\n}\nnz-header .logo {\n  float: left;\n  width: 200px;\n  padding: 6px 16px;\n  height: 50px;\n  margin: 0;\n  background-color: #001529;\n  color: #fff;\n  z-index: 100;\n  letter-spacing: 0.5px;\n}\nnz-header .logo .campany-name {\n  float: left;\n  width: auto;\n  opacity: 1;\n  line-height: 38px;\n  padding: 0;\n  margin-left: 10px;\n}\nnz-header .logo .logo-img {\n  float: left;\n  width: 2.78em;\n  height: 2.78em;\n  background: url('logo.png') no-repeat center;\n  background-size: contain;\n}\nnz-header .logo .fa {\n  margin: 0 5px;\n  vertical-align: middle;\n}\nnz-header.active .logo {\n  width: 80px;\n  padding: 6px 20px;\n}\nnz-header.active .campany-name {\n  display: none;\n  width: 0;\n  opacity: 0;\n}\nnz-header .navbar-right {\n  float: right;\n  line-height: 50px;\n  vertical-align: middle;\n}\nnz-header .navbar-right i {\n  font-size: 18px;\n}\nnz-header .navbar-right .msg {\n  display: inline-block;\n  width: 32px;\n  height: 50px;\n  vertical-align: middle;\n}\nnz-header .navbar-right nz-avatar {\n  cursor: pointer;\n}\nnz-header .navbar-right .roleText {\n  margin: 0 15px 0 5px;\n  color: rgba(0, 0, 0, 0.65);\n}\nnz-header .navbar-right .userInfo {\n  position: absolute;\n  top: 100%;\n  right: 0;\n  width: 120px;\n  background-color: #fff;\n  z-index: 99;\n  box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);\n  border: 1px solid rgba(0, 0, 0, 0.1);\n  border-radius: 2px;\n}\nnz-header .navbar-right .userInfo ul {\n  margin: 0;\n  padding: 0 15px;\n  list-style: none;\n}\nnz-header .navbar-right .userInfo ul li {\n  line-height: 32px;\n  display: contents;\n  padding-right: 15px;\n  border-bottom: 1px solid #E0E5F1;\n}\nnz-header .navbar-right .userInfo ul li:last-child {\n  border-top: 1px solid #e5e5e5;\n  border-bottom: 0 solid transparent;\n}\n.menu li.active {\n  background: #1890ff;\n}\n.menu li.active a {\n  color: #fff;\n}\n.menu a:active {\n  text-decoration: none;\n}\n.navbar-nav {\n  float: right;\n  list-style: none;\n}\n.navbar-nav li {\n  padding: 0 10px;\n  float: left;\n}\n.navbar-nav li a {\n  position: relative;\n  display: block;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9saXRlbmcvQXBwL3Blcm1pc3Npb25zLXN5c3RlbS1mcm9udEVuZC9zcmMvYXBwL2xheW91dC9kZWZhdWx0L2RlZmF1bHQuY29tcG9uZW50Lmxlc3MiLCJzcmMvYXBwL2xheW91dC9kZWZhdWx0L2RlZmF1bHQuY29tcG9uZW50Lmxlc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQ0E7RUFDSSxpQkFBQTtBQ0FKO0FER0E7RUFDSSxlQUFBO0VBQ0EsT0FBQTtFQUNBLE1BQUE7RUFDQSxZQUFBO0VBQ0EsV0FBQTtFQUNBLFVBQUE7RUFDQSxzQkFBQTtFQUNBLHNFQUFBO0VBQ0EsV0FBQTtBQ0RKO0FEUkE7RUFXUSxXQUFBO0VBQ0EsZUFBQTtFQUNBLGlCQUFBO0VBQ0EsZUFBQTtFQUNBLGVBQUE7RUFDQSxzQkFBQTtFQUNBLHVCQUFBO0VBQ0EsMEJBQUE7QUNBUjtBRGxCQTtFQXFCUSxjQUFBO0FDQVI7QURyQkE7RUF3QlEsV0FBQTtFQUNBLFlBQUE7RUFDQSxpQkFBQTtFQUNBLFlBQUE7RUFDQSxTQUFBO0VBQ0EseUJBQUE7RUFDQSxXQUFBO0VBQ0EsWUFBQTtFQUNBLHFCQUFBO0FDQVI7QURoQ0E7RUFrQ1ksV0FBQTtFQUNBLFdBQUE7RUFDQSxVQUFBO0VBQ0EsaUJBQUE7RUFDQSxVQUFBO0VBQ0EsaUJBQUE7QUNDWjtBRHhDQTtFQTBDWSxXQUFBO0VBQ0EsYUFBQTtFQUNBLGNBQUE7RUFDQSw0Q0FBQTtFQUNBLHdCQUFBO0FDQ1o7QUQvQ0E7RUFpRFksYUFBQTtFQUNBLHNCQUFBO0FDQ1o7QURHSTtFQUVRLFdBQUE7RUFDQSxpQkFBQTtBQ0ZaO0FEREk7RUFNUSxhQUFBO0VBQ0EsUUFBQTtFQUNBLFVBQUE7QUNGWjtBRDVEQTtFQWtFUSxZQUFBO0VBQ0EsaUJBQUE7RUFDQSxzQkFBQTtBQ0hSO0FEakVBO0VBc0VZLGVBQUE7QUNGWjtBRHBFQTtFQXlFVyxxQkFBQTtFQUNBLFdBQUE7RUFDQSxZQUFBO0VBQ0Esc0JBQUE7QUNGWDtBRDFFQTtFQStFWSxlQUFBO0FDRlo7QUQ3RUE7RUFrRlksb0JBQUE7RUFDQSwwQkFBQTtBQ0ZaO0FEakZBO0VBc0ZZLGtCQUFBO0VBQ0EsU0FBQTtFQUNBLFFBQUE7RUFDQSxZQUFBO0VBQ0Esc0JBQUE7RUFDQSxXQUFBO0VBQ0Esd0NBQUE7RUFDQSxvQ0FBQTtFQUNBLGtCQUFBO0FDRlo7QUQ1RkE7RUFnR2dCLFNBQUE7RUFDQSxlQUFBO0VBQ0EsZ0JBQUE7QUNEaEI7QURqR0E7RUFvR29CLGlCQUFBO0VBQ0EsaUJBQUE7RUFDQSxtQkFBQTtFQUNBLGdDQUFBO0FDQXBCO0FEdkdBO0VBMEdvQiw2QkFBQTtFQUNBLGtDQUFBO0FDQXBCO0FET0E7RUFDSSxtQkFBQTtBQ0xKO0FESUE7RUFHUSxXQUFBO0FDSlI7QURXRTtFQUNJLHFCQUFBO0FDVE47QURZQTtFQUNJLFlBQUE7RUFDQSxnQkFBQTtBQ1ZKO0FEUUE7RUFJUSxlQUFBO0VBQ0EsV0FBQTtBQ1RSO0FESUE7RUFPWSxrQkFBQTtFQUNBLGNBQUE7QUNSWiIsImZpbGUiOiJzcmMvYXBwL2xheW91dC9kZWZhdWx0L2RlZmF1bHQuY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyJcbi5hcHAtaGVhZGVyLWZpeGVke1xuICAgIHBhZGRpbmctdG9wOiA1MHB4O1xufVxuLy8gaGVhZGVyIGNzc1xubnotaGVhZGVye1xuICAgIHBvc2l0aW9uOiBmaXhlZDtcbiAgICBsZWZ0OiAwO1xuICAgIHRvcDogMDtcbiAgICBoZWlnaHQ6IDUwcHg7XG4gICAgd2lkdGg6IDEwMCU7XG4gICAgcGFkZGluZzogMDtcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjZmZmO1xuICAgIGJveC1zaGFkb3c6IDAgMnB4IDJweCByZ2JhKDAsMCwwLDAuMDUpLCAwIDFweCAwIHJnYmEoMCwwLDAsMC4wNSk7XG4gICAgei1pbmRleDogOTk7XG4gICAgLnRyaWdnZXIge1xuICAgICAgICBmbG9hdDogbGVmdDtcbiAgICAgICAgZm9udC1zaXplOiAxOHB4O1xuICAgICAgICBsaW5lLWhlaWdodDogNTBweDtcbiAgICAgICAgcGFkZGluZzogMCAyNHB4O1xuICAgICAgICBjdXJzb3I6IHBvaW50ZXI7XG4gICAgICAgIHRyYW5zaXRpb246IGNvbG9yIDAuM3M7XG4gICAgICAgIHZlcnRpY2FsLWFsaWduOiBpbmhlcml0O1xuICAgICAgICBjb2xvcjogcmdiYSgwLCAwLCAwLCAwLjY1KTtcbiAgICB9XG4gICAgLnRyaWdnZXI6aG92ZXIge1xuICAgICAgICBjb2xvcjogIzE4OTBmZjtcbiAgICB9XG4gICAgLmxvZ297XG4gICAgICAgIGZsb2F0OiBsZWZ0O1xuICAgICAgICB3aWR0aDogMjAwcHg7XG4gICAgICAgIHBhZGRpbmc6IDZweCAxNnB4O1xuICAgICAgICBoZWlnaHQ6IDUwcHg7XG4gICAgICAgIG1hcmdpbjogMDtcbiAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogIzAwMTUyOTtcbiAgICAgICAgY29sb3I6ICNmZmY7XG4gICAgICAgIHotaW5kZXg6IDEwMDtcbiAgICAgICAgbGV0dGVyLXNwYWNpbmc6IDAuNXB4O1xuICAgICAgICAuY2FtcGFueS1uYW1le1xuICAgICAgICAgICAgZmxvYXQ6IGxlZnQ7XG4gICAgICAgICAgICB3aWR0aDogYXV0bztcbiAgICAgICAgICAgIG9wYWNpdHk6IDE7XG4gICAgICAgICAgICBsaW5lLWhlaWdodDogMzhweDtcbiAgICAgICAgICAgIHBhZGRpbmc6IDA7XG4gICAgICAgICAgICBtYXJnaW4tbGVmdDogMTBweDtcbiAgICAgICAgfVxuICAgICAgICAubG9nby1pbWd7XG4gICAgICAgICAgICBmbG9hdDogbGVmdDtcbiAgICAgICAgICAgIHdpZHRoOiAyLjc4ZW07XG4gICAgICAgICAgICBoZWlnaHQ6IDIuNzhlbTtcbiAgICAgICAgICAgIGJhY2tncm91bmQ6IHVybCgnLi4vLi4vLi4vYXNzZXRzL2ltYWdlcy9sb2dvLnBuZycpIG5vLXJlcGVhdCBjZW50ZXI7XG4gICAgICAgICAgICBiYWNrZ3JvdW5kLXNpemU6IGNvbnRhaW5cbiAgICAgICAgfVxuICAgICAgICAuZmF7XG4gICAgICAgICAgICBtYXJnaW46IDAgNXB4O1xuICAgICAgICAgICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcbiAgICAgICAgfVxuICAgIH1cbiAgICAvLyDlhbPpl61jc3NcbiAgICAmLmFjdGl2ZXtcbiAgICAgICAgLmxvZ297XG4gICAgICAgICAgICB3aWR0aDogODBweDtcbiAgICAgICAgICAgIHBhZGRpbmc6IDZweCAyMHB4O1xuICAgICAgICB9XG4gICAgICAgIC5jYW1wYW55LW5hbWV7XG4gICAgICAgICAgICBkaXNwbGF5OiBub25lO1xuICAgICAgICAgICAgd2lkdGg6IDA7XG4gICAgICAgICAgICBvcGFjaXR5OiAwO1xuICAgICAgICB9XG4gICAgfVxuICAgIC5uYXZiYXItcmlnaHR7XG4gICAgICAgIGZsb2F0OiByaWdodDtcbiAgICAgICAgbGluZS1oZWlnaHQ6IDUwcHg7XG4gICAgICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG4gICAgICAgIGl7XG4gICAgICAgICAgICBmb250LXNpemU6MThweDtcbiAgICAgICAgfVxuICAgICAgICAubXNne1xuICAgICAgICAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gICAgICAgICAgIHdpZHRoOiAzMnB4O1xuICAgICAgICAgICBoZWlnaHQ6IDUwcHg7XG4gICAgICAgICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG4gICAgICAgIH1cbiAgICAgICAgbnotYXZhdGFye1xuICAgICAgICAgICAgY3Vyc29yOiBwb2ludGVyO1xuICAgICAgICB9XG4gICAgICAgIC5yb2xlVGV4dHtcbiAgICAgICAgICAgIG1hcmdpbjogMCAxNXB4IDAgNXB4O1xuICAgICAgICAgICAgY29sb3I6IHJnYmEoMCwgMCwgMCwgMC42NSk7XG4gICAgICAgIH1cbiAgICAgICAgLnVzZXJJbmZve1xuICAgICAgICAgICAgcG9zaXRpb246IGFic29sdXRlO1xuICAgICAgICAgICAgdG9wOiAxMDAlO1xuICAgICAgICAgICAgcmlnaHQ6IDA7XG4gICAgICAgICAgICB3aWR0aDogMTIwcHg7XG4gICAgICAgICAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjZmZmO1xuICAgICAgICAgICAgei1pbmRleDogOTk7XG4gICAgICAgICAgICBib3gtc2hhZG93OiAwIDJweCA2cHggcmdiYSgwLDAsMCwwLjEpO1xuICAgICAgICAgICAgYm9yZGVyOiAxcHggc29saWQgcmdiYSgwLDAsMCwwLjEpO1xuICAgICAgICAgICAgYm9yZGVyLXJhZGl1czogMnB4O1xuICAgICAgICAgICAgdWx7XG4gICAgICAgICAgICAgICAgbWFyZ2luOiAwO1xuICAgICAgICAgICAgICAgIHBhZGRpbmc6IDAgMTVweDtcbiAgICAgICAgICAgICAgICBsaXN0LXN0eWxlOiBub25lO1xuICAgICAgICAgICAgICAgIGxpe1xuICAgICAgICAgICAgICAgICAgICBsaW5lLWhlaWdodDogMzJweDtcbiAgICAgICAgICAgICAgICAgICAgZGlzcGxheTogY29udGVudHM7XG4gICAgICAgICAgICAgICAgICAgIHBhZGRpbmctcmlnaHQ6IDE1cHg7XG4gICAgICAgICAgICAgICAgICAgIGJvcmRlci1ib3R0b206MXB4IHNvbGlkICNFMEU1RjE7XG4gICAgICAgICAgICAgICAgfVxuICAgICAgICAgICAgICAgIGxpOmxhc3QtY2hpbGR7XG4gICAgICAgICAgICAgICAgICAgIGJvcmRlci10b3A6IDFweCBzb2xpZCAjZTVlNWU1O1xuICAgICAgICAgICAgICAgICAgICBib3JkZXItYm90dG9tOjAgc29saWQgdHJhbnNwYXJlbnQ7XG4gICAgICAgICAgICAgICAgfVxuICAgICAgICAgICAgfVxuXG4gICAgICAgIH1cbiAgICB9XG59XG4ubWVudSBsaS5hY3RpdmV7XG4gICAgYmFja2dyb3VuZDogIzE4OTBmZjtcbiAgICBhe1xuICAgICAgICBjb2xvcjogI2ZmZjtcbiAgICB9XG4gfVxuLy8gIC5tZW51IGEuYWN0aXZle1xuLy8gICAgIGJhY2tncm91bmQ6ICMxODkwZmY7XG4vLyAgICAgY29sb3I6ICNmZmY7XG4vLyAgfVxuICAubWVudSBhOmFjdGl2ZXtcbiAgICAgIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcbiAgfVxuLy8gbGVmdCBuYXZcbi5uYXZiYXItbmF2e1xuICAgIGZsb2F0OiByaWdodDtcbiAgICBsaXN0LXN0eWxlOiBub25lO1xuICAgIGxpe1xuICAgICAgICBwYWRkaW5nOiAwIDEwcHg7XG4gICAgICAgIGZsb2F0OiBsZWZ0O1xuICAgICAgICBhe1xuICAgICAgICAgICAgcG9zaXRpb246IHJlbGF0aXZlO1xuICAgICAgICAgICAgZGlzcGxheTogYmxvY2s7XG4gICAgICAgIH1cbiAgICB9XG59XG4iLCIuYXBwLWhlYWRlci1maXhlZCB7XG4gIHBhZGRpbmctdG9wOiA1MHB4O1xufVxubnotaGVhZGVyIHtcbiAgcG9zaXRpb246IGZpeGVkO1xuICBsZWZ0OiAwO1xuICB0b3A6IDA7XG4gIGhlaWdodDogNTBweDtcbiAgd2lkdGg6IDEwMCU7XG4gIHBhZGRpbmc6IDA7XG4gIGJhY2tncm91bmQtY29sb3I6ICNmZmY7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDJweCByZ2JhKDAsIDAsIDAsIDAuMDUpLCAwIDFweCAwIHJnYmEoMCwgMCwgMCwgMC4wNSk7XG4gIHotaW5kZXg6IDk5O1xufVxubnotaGVhZGVyIC50cmlnZ2VyIHtcbiAgZmxvYXQ6IGxlZnQ7XG4gIGZvbnQtc2l6ZTogMThweDtcbiAgbGluZS1oZWlnaHQ6IDUwcHg7XG4gIHBhZGRpbmc6IDAgMjRweDtcbiAgY3Vyc29yOiBwb2ludGVyO1xuICB0cmFuc2l0aW9uOiBjb2xvciAwLjNzO1xuICB2ZXJ0aWNhbC1hbGlnbjogaW5oZXJpdDtcbiAgY29sb3I6IHJnYmEoMCwgMCwgMCwgMC42NSk7XG59XG5uei1oZWFkZXIgLnRyaWdnZXI6aG92ZXIge1xuICBjb2xvcjogIzE4OTBmZjtcbn1cbm56LWhlYWRlciAubG9nbyB7XG4gIGZsb2F0OiBsZWZ0O1xuICB3aWR0aDogMjAwcHg7XG4gIHBhZGRpbmc6IDZweCAxNnB4O1xuICBoZWlnaHQ6IDUwcHg7XG4gIG1hcmdpbjogMDtcbiAgYmFja2dyb3VuZC1jb2xvcjogIzAwMTUyOTtcbiAgY29sb3I6ICNmZmY7XG4gIHotaW5kZXg6IDEwMDtcbiAgbGV0dGVyLXNwYWNpbmc6IDAuNXB4O1xufVxubnotaGVhZGVyIC5sb2dvIC5jYW1wYW55LW5hbWUge1xuICBmbG9hdDogbGVmdDtcbiAgd2lkdGg6IGF1dG87XG4gIG9wYWNpdHk6IDE7XG4gIGxpbmUtaGVpZ2h0OiAzOHB4O1xuICBwYWRkaW5nOiAwO1xuICBtYXJnaW4tbGVmdDogMTBweDtcbn1cbm56LWhlYWRlciAubG9nbyAubG9nby1pbWcge1xuICBmbG9hdDogbGVmdDtcbiAgd2lkdGg6IDIuNzhlbTtcbiAgaGVpZ2h0OiAyLjc4ZW07XG4gIGJhY2tncm91bmQ6IHVybCgnLi4vLi4vLi4vYXNzZXRzL2ltYWdlcy9sb2dvLnBuZycpIG5vLXJlcGVhdCBjZW50ZXI7XG4gIGJhY2tncm91bmQtc2l6ZTogY29udGFpbjtcbn1cbm56LWhlYWRlciAubG9nbyAuZmEge1xuICBtYXJnaW46IDAgNXB4O1xuICB2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO1xufVxubnotaGVhZGVyLmFjdGl2ZSAubG9nbyB7XG4gIHdpZHRoOiA4MHB4O1xuICBwYWRkaW5nOiA2cHggMjBweDtcbn1cbm56LWhlYWRlci5hY3RpdmUgLmNhbXBhbnktbmFtZSB7XG4gIGRpc3BsYXk6IG5vbmU7XG4gIHdpZHRoOiAwO1xuICBvcGFjaXR5OiAwO1xufVxubnotaGVhZGVyIC5uYXZiYXItcmlnaHQge1xuICBmbG9hdDogcmlnaHQ7XG4gIGxpbmUtaGVpZ2h0OiA1MHB4O1xuICB2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO1xufVxubnotaGVhZGVyIC5uYXZiYXItcmlnaHQgaSB7XG4gIGZvbnQtc2l6ZTogMThweDtcbn1cbm56LWhlYWRlciAubmF2YmFyLXJpZ2h0IC5tc2cge1xuICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XG4gIHdpZHRoOiAzMnB4O1xuICBoZWlnaHQ6IDUwcHg7XG4gIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XG59XG5uei1oZWFkZXIgLm5hdmJhci1yaWdodCBuei1hdmF0YXIge1xuICBjdXJzb3I6IHBvaW50ZXI7XG59XG5uei1oZWFkZXIgLm5hdmJhci1yaWdodCAucm9sZVRleHQge1xuICBtYXJnaW46IDAgMTVweCAwIDVweDtcbiAgY29sb3I6IHJnYmEoMCwgMCwgMCwgMC42NSk7XG59XG5uei1oZWFkZXIgLm5hdmJhci1yaWdodCAudXNlckluZm8ge1xuICBwb3NpdGlvbjogYWJzb2x1dGU7XG4gIHRvcDogMTAwJTtcbiAgcmlnaHQ6IDA7XG4gIHdpZHRoOiAxMjBweDtcbiAgYmFja2dyb3VuZC1jb2xvcjogI2ZmZjtcbiAgei1pbmRleDogOTk7XG4gIGJveC1zaGFkb3c6IDAgMnB4IDZweCByZ2JhKDAsIDAsIDAsIDAuMSk7XG4gIGJvcmRlcjogMXB4IHNvbGlkIHJnYmEoMCwgMCwgMCwgMC4xKTtcbiAgYm9yZGVyLXJhZGl1czogMnB4O1xufVxubnotaGVhZGVyIC5uYXZiYXItcmlnaHQgLnVzZXJJbmZvIHVsIHtcbiAgbWFyZ2luOiAwO1xuICBwYWRkaW5nOiAwIDE1cHg7XG4gIGxpc3Qtc3R5bGU6IG5vbmU7XG59XG5uei1oZWFkZXIgLm5hdmJhci1yaWdodCAudXNlckluZm8gdWwgbGkge1xuICBsaW5lLWhlaWdodDogMzJweDtcbiAgZGlzcGxheTogY29udGVudHM7XG4gIHBhZGRpbmctcmlnaHQ6IDE1cHg7XG4gIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCAjRTBFNUYxO1xufVxubnotaGVhZGVyIC5uYXZiYXItcmlnaHQgLnVzZXJJbmZvIHVsIGxpOmxhc3QtY2hpbGQge1xuICBib3JkZXItdG9wOiAxcHggc29saWQgI2U1ZTVlNTtcbiAgYm9yZGVyLWJvdHRvbTogMCBzb2xpZCB0cmFuc3BhcmVudDtcbn1cbi5tZW51IGxpLmFjdGl2ZSB7XG4gIGJhY2tncm91bmQ6ICMxODkwZmY7XG59XG4ubWVudSBsaS5hY3RpdmUgYSB7XG4gIGNvbG9yOiAjZmZmO1xufVxuLm1lbnUgYTphY3RpdmUge1xuICB0ZXh0LWRlY29yYXRpb246IG5vbmU7XG59XG4ubmF2YmFyLW5hdiB7XG4gIGZsb2F0OiByaWdodDtcbiAgbGlzdC1zdHlsZTogbm9uZTtcbn1cbi5uYXZiYXItbmF2IGxpIHtcbiAgcGFkZGluZzogMCAxMHB4O1xuICBmbG9hdDogbGVmdDtcbn1cbi5uYXZiYXItbmF2IGxpIGEge1xuICBwb3NpdGlvbjogcmVsYXRpdmU7XG4gIGRpc3BsYXk6IGJsb2NrO1xufVxuIl19 */"

/***/ }),

/***/ "./src/app/layout/default/default.component.ts":
/*!*****************************************************!*\
  !*** ./src/app/layout/default/default.component.ts ***!
  \*****************************************************/
/*! exports provided: DefaultComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DefaultComponent", function() { return DefaultComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");
/* harmony import */ var _auth_config__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../auth.config */ "./src/app/auth.config.ts");







var DefaultComponent = /** @class */ (function () {
    function DefaultComponent(server, msg, router, routerActive, oauthService) {
        this.server = server;
        this.msg = msg;
        this.router = router;
        this.routerActive = routerActive;
        this.oauthService = oauthService;
        this.api_list = '/api/MenuManage/GetMenuTreeList?appId='; //左侧菜单列表
        this.systemName = this.server.getSystemName();
        this.color = '#1890ff'; //头像背景色
        this.isCollapsed = false; //收否收缩
        this.triggerTemplate = null;
        this.logoTemplate = null;
        this.isAllDisplayDataChecked = false;
        this.isIndeterminate = false;
        this.listOfDisplayData = [];
        this.listOfAllData = [];
        this.mapOfCheckedId = {};
        //右侧消息弹框
        this.visible = false;
        this.menuData = []; //接收菜单
        //接收参数
        this.appList = [];
        this.searchApp = null;
        this.breadcrumbs = [];
        this.msgNum = 0;
        this.configureWithNewConfigApi();
    }
    DefaultComponent.prototype.configureWithNewConfigApi = function () {
        this.oauthService.configure(_auth_config__WEBPACK_IMPORTED_MODULE_6__["authConfig"]);
        this.oauthService.tokenValidationHandler = new angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_5__["JwksValidationHandler"]();
        this.oauthService.loadDiscoveryDocumentAndTryLogin();
    };
    DefaultComponent.prototype.login = function () {
        this.oauthService.initImplicitFlow('/some-state;p1=1;p2=2');
    };
    //登出
    DefaultComponent.prototype.logout = function () {
        this.oauthService.logOut();
        // this.msg.info('退出成功!');
        // this.router.navigateByUrl('/login');
    };
    Object.defineProperty(DefaultComponent.prototype, "name", {
        get: function () {
            var claims = this.oauthService.getIdentityClaims();
            if (!claims)
                return 'gust';
            return claims.aud;
        },
        enumerable: true,
        configurable: true
    });
    //查看消息列表
    DefaultComponent.prototype.openMsg = function () {
        if (this.msgNum) {
            this.visible = true;
        }
        else {
            this.msg.info('暂无消息！');
        }
    };
    DefaultComponent.prototype.close = function () {
        this.visible = false;
    };
    DefaultComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.router.events
            .subscribe(function (event) {
            console.log('NavigationEnd:', event);
            var root = _this.routerActive.root;
        });
        //获取应用程序列表
        this.server.getAppList().subscribe(function (data) {
            _this.appList = data;
            _this.searchApp = data[0];
            //获取页面列表
            _this.getMenuList();
        });
    };
    Object.defineProperty(DefaultComponent.prototype, "requestAccessToken", {
        get: function () {
            return this.oauthService.requestAccessToken;
        },
        enumerable: true,
        configurable: true
    });
    //获取菜单数据
    DefaultComponent.prototype.getMenuList = function () {
        var _this = this;
        var option = {
            api: this.api_list + this.searchApp.id,
        };
        var rxjsData = this.server.getRxjsData(option);
        rxjsData.subscribe(function (data) {
            _this.menuData = data[0].children;
            if (!localStorage.getItem('menuId')) {
                _this.server.setPremission(_this.menuData[0].menuId);
            }
        });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('trigger'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["TemplateRef"])
    ], DefaultComponent.prototype, "customTrigger", void 0);
    DefaultComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-default',
            template: __webpack_require__(/*! ./default.component.html */ "./src/app/layout/default/default.component.html"),
            styles: [__webpack_require__(/*! ./default.component.less */ "./src/app/layout/default/default.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_4__["ServersService"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_3__["NzMessageService"], _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"], _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"], angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_5__["OAuthService"]])
    ], DefaultComponent);
    return DefaultComponent;
}());



/***/ }),

/***/ "./src/app/pages/application/application.component.html":
/*!**************************************************************!*\
  !*** ./src/app/pages/application/application.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nz-breadcrumb style=\"margin:1em 0;\" [nzAutoGenerate]=\"true\">\n  <nz-breadcrumb-item>您所在的位置</nz-breadcrumb-item>\n  <nz-breadcrumb-item>{{breadcrumb}}</nz-breadcrumb-item>\n</nz-breadcrumb>\n<div class=\"content\">\n  <div nz-row class=\"text-right\">\n    <app-search (search)=\"searchData($event)\" (add)=\"showModal()\"></app-search>\n    <app-premission (add)=\"showModal()\" place=\"top\"></app-premission>\n  </div>\n  <nz-table #basicTable [nzData]=\"displayData\" nzBordered nzSize=\"middle\">\n    <thead>\n      <tr>\n        <th>应用程序名称</th>\n        <th>应用程序描述</th>\n        <th>创建人 </th>\n        <th>创建日期</th>\n        <th>操作</th>\n      </tr>\n    </thead>\n    <tbody>\n      <tr *ngFor=\"let item of basicTable.data\">\n        <td>{{ item.appName }}</td>\n        <td>{{ item.description }}</td>\n        <td>{{ item.createUserName }}</td>\n        <td>{{ item.createTime | date : 'yyyy-MM-dd HH:mm:ss'}}</td>\n        <td>\n          <app-premission (update)=\"editRow(item)\" (delete)=\"deleteRow(item)\" place=\"list\"></app-premission>\n        </td>\n      </tr>\n    </tbody>\n  </nz-table>\n  <!-- 编辑框 -->\n  <nz-modal [(nzVisible)]=\"isVisible\" [nzWidth]=\"700\" nzTitle=\"{{modelTitle}}\" nzOkText=\"确定\" nzCancelText=\"取消\"\n    (nzOnOk)=\"handleOk()\" (nzOnCancel)=\"handleCancel()\" [nzFooter]=\"modalFooter\">\n    <form nz-form [formGroup]=\"validateForm\">\n      <nz-form-item>\n        <nz-form-label [nzSpan]=\"4\" nzRequired>应用程序名称</nz-form-label>\n        <nz-form-control [nzSpan]=\"20\">\n          <input nz-input formControlName=\"appName\" placeholder=\"请输入\" type=\"text\">\n          <nz-form-explain *ngIf=\"validateForm.get('appName').dirty\">\n            <ng-container *ngIf=\"validateForm.get('appName').hasError('required')\">\n              应用名称不能为空！\n            </ng-container>\n          </nz-form-explain>\n        </nz-form-control>\n      </nz-form-item>\n      <nz-form-item>\n        <nz-form-label [nzSpan]=\"4\">应用程序描述</nz-form-label>\n        <nz-form-control [nzSpan]=\"20\">\n          <textarea nz-input rows=\"3\" formControlName=\"description\" placeholder=\"请输入\" type=\"text\"></textarea>\n        </nz-form-control>\n      </nz-form-item>\n      <ng-template #modalFooter>\n        <button nz-button nzType=\"default\" (click)=\"resetForm()\">重置</button>\n        <button nz-button nzType=\"primary\" [disabled]=\"!validateForm.valid\"\n          (click)=\"submitForm(validateForm.value)\">保存</button>\n      </ng-template>\n    </form>\n  </nz-modal>\n</div>\n"

/***/ }),

/***/ "./src/app/pages/application/application.component.less":
/*!**************************************************************!*\
  !*** ./src/app/pages/application/application.component.less ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3BhZ2VzL2FwcGxpY2F0aW9uL2FwcGxpY2F0aW9uLmNvbXBvbmVudC5sZXNzIn0= */"

/***/ }),

/***/ "./src/app/pages/application/application.component.ts":
/*!************************************************************!*\
  !*** ./src/app/pages/application/application.component.ts ***!
  \************************************************************/
/*! exports provided: ApplicationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ApplicationComponent", function() { return ApplicationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");








var ApplicationComponent = /** @class */ (function () {
    //初始化构造函数
    function ApplicationComponent(server, http, fb, msg, oauthService) {
        this.server = server;
        this.http = http;
        this.fb = fb;
        this.msg = msg;
        this.oauthService = oauthService;
        this.sendData = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.api_list = '/api/AppManage/GetAppList'; // 页面数据列表api
        this.api_add = '/api/AppManage/CreateApp'; // 新增行api
        this.api_update = '/api/AppManage/EditApp'; // 更新行api
        this.api_delete = '/api/AppManage/DeleteApp?id='; // 删除行api
        //列表相关数据
        this.displayData = []; //存储列表数据
        this.isLoading = false; //用于加载效果
        this.Page = 1; //初始页码
        this.Rows = 10; //显示行数
        this.total = 1; //总条数
        this.Sord = null; //正反序
        this.OrderBy = null; //排序字段
        this.loading = true; //开启加载
        this.Sidx = '0';
        this.colData = null;
        //modal 参数
        this.modelTitle = '新增'; //弹窗标题
        this.headers = new _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpHeaders"]({ 'Content-Type': 'application/json' }); //发送post请求头部
        this.isVisible = false; //控制窗口是否显示
        this.appId = ''; //行id
        this.breadcrumb = '应用程序管理';
        this.validateForm = this.fb.group({
            appName: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].required]],
            description: [null],
        });
    }
    ApplicationComponent.prototype.ngOnInit = function () {
        //获取页面列表
        this.getDataList();
    };
    //获取列表数据
    ApplicationComponent.prototype.getDataList = function () {
        var _this = this;
        var options = {
            api: this.api_list,
            params: {
                Sidx: '0',
                Page: this.Page,
                Rows: this.Rows,
            }
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.colData = data.pageResult.data;
            _this.displayData = _this.colData.slice();
        });
    };
    //搜索事件
    ApplicationComponent.prototype.searchData = function (keyword, reset) {
        var _this = this;
        if (reset === void 0) { reset = false; }
        this.isLoading = true;
        if (reset) {
            this.Page = 1;
        }
        this.loading = true;
        this.getList(keyword, this.Page, this.Rows, this.Sidx).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.colData = data.pageResult.data;
            _this.displayData = _this.colData.slice();
            _this.isLoading = false;
        });
    };
    ApplicationComponent.prototype.getList = function (keyword, pageIndex, pageSize, Sidx) {
        if (pageIndex === void 0) { pageIndex = 1; }
        if (pageSize === void 0) { pageSize = 10; }
        var params = {};
        params.Name = keyword ? keyword : '';
        if (this.Page) {
            params.Page = this.Page;
        }
        if (this.Rows) {
            params.Rows = this.Rows;
        }
        if (this.Sidx) {
            params.Sidx = this.Sidx;
        }
        if (this.Sord) {
            params.Sord = this.Sord;
        }
        var options = {
            api: this.api_list,
            params: params
        };
        return this.server.getRxjsData(options);
    };
    //打开弹框
    ApplicationComponent.prototype.showModal = function () {
        this.isVisible = true;
        this.appId = '';
        //表单初始化
        this.resetForm();
    };
    //弹框确定事件
    ApplicationComponent.prototype.handleOk = function () {
        this.isVisible = false;
    };
    //弹框取消事件
    ApplicationComponent.prototype.handleCancel = function () {
        this.isVisible = false;
    };
    ApplicationComponent.prototype.resetForm = function () {
        this.validateForm.reset();
        for (var key in this.validateForm.controls) {
            this.validateForm.controls[key].markAsPristine();
            this.validateForm.controls[key].updateValueAndValidity();
        }
    };
    //编辑行
    ApplicationComponent.prototype.editRow = function (item) {
        var _this = this;
        this.appId = item.appId;
        //初始化表单值
        var initformData = new rxjs__WEBPACK_IMPORTED_MODULE_4__["Observable"](function (observer) {
            _this.validateForm.setValue({ appName: item.appName, description: item.description });
            observer.next();
        });
        initformData.subscribe(function () {
            _this.isVisible = true;
            _this.modelTitle = '编辑';
        });
    };
    //保存行
    ApplicationComponent.prototype.submitForm = function (value) {
        var _this = this;
        var paramsObj = value;
        if (this.appId) {
            paramsObj.appId = this.appId;
        }
        var options = {
            api: this.appId ? this.api_update : this.api_add,
            params: value
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.isVisible = false;
            _this.searchData();
        });
    };
    //删除行
    ApplicationComponent.prototype.deleteRow = function (item) {
        var _this = this;
        var options = {
            api: this.api_delete + item.appId,
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.searchData();
        });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])('sendData'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], ApplicationComponent.prototype, "sendData", void 0);
    ApplicationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-application',
            template: __webpack_require__(/*! ./application.component.html */ "./src/app/pages/application/application.component.html"),
            styles: [__webpack_require__(/*! ./application.component.less */ "./src/app/pages/application/application.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_2__["ServersService"], _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClient"], _angular_forms__WEBPACK_IMPORTED_MODULE_7__["FormBuilder"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NzMessageService"], angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_6__["OAuthService"]])
    ], ApplicationComponent);
    return ApplicationComponent;
}());



/***/ }),

/***/ "./src/app/pages/login/login.component.html":
/*!**************************************************!*\
  !*** ./src/app/pages/login/login.component.html ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"container\">\n  <form nz-form [formGroup]=\"validateForm\" class=\"login-form\" (ngSubmit)=\"submitForm(validateForm.value)\">\n    <nz-form-item class=\"logo text-center\">\n      <img src=\"../../../assets/images/login-logo.png\" alt=\"\" style=\"max-height:70px \">\n      <span class=\"systemName\">{{systemName}}</span>\n    </nz-form-item>\n    <nz-form-item>\n      <nz-form-control>\n        <nz-input-group [nzPrefix]=\"prefixUser\" class=\"ant-input-affix-wrapper ant-input-affix-wrapper-lg\">\n          <input type=\"text\" nz-input formControlName=\"UserName\" placeholder=\"用户名\">\n        </nz-input-group>\n        <nz-form-explain *ngIf=\"validateForm.get('UserName').dirty && validateForm.get('UserName').errors\">请输入用户名!\n        </nz-form-explain>\n      </nz-form-control>\n    </nz-form-item>\n    <nz-form-item>\n      <nz-form-control>\n        <nz-input-group [nzPrefix]=\"prefixLock\" class=\"ant-input-affix-wrapper ant-input-affix-wrapper-lg\">\n          <input type=\"password\" nz-input formControlName=\"Password\" placeholder=\"密码\">\n        </nz-input-group>\n        <nz-form-explain *ngIf=\"validateForm.get('Password').dirty && validateForm.get('Password').errors\">请输入密码!\n        </nz-form-explain>\n      </nz-form-control>\n    </nz-form-item>\n    <nz-form-item>\n      <nz-form-control>\n        <label nz-checkbox>\n          <span>记住密码</span>\n        </label>\n        <!-- <a class=\"login-form-forgot\" class=\"login-form-forgot\">Forgot password</a> -->\n        <button nz-button class=\"login-form-button\" [nzType]=\"'primary'\">登录</button>\n        <!-- Or -->\n        <!-- <a href=\"\">register now!</a> -->\n      </nz-form-control>\n    </nz-form-item>\n  </form>\n  <ng-template #prefixUser><i nz-icon type=\"user\"></i></ng-template>\n  <ng-template #prefixLock><i nz-icon type=\"lock\"></i></ng-template>\n  <div class=\"copyright text-center\">\n    <p>Copyright<i class=\"anticon anticon-copyright\"></i> 2019 上海达华测绘有限公司</p>\n  </div>\n</div>"

/***/ }),

/***/ "./src/app/pages/login/login.component.less":
/*!**************************************************!*\
  !*** ./src/app/pages/login/login.component.less ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".container {\n  background-image: url(https://gw.alipayobjects.com/zos/rmsportal/TVYTbAXWheQpRcWDaDMu.svg);\n  background-repeat: no-repeat;\n  background-position: center 110px;\n  background-size: 100%;\n  display: flex;\n  flex-direction: column;\n  min-height: 100%;\n}\n.login-form {\n  width: 370px;\n  margin: 200px auto 0;\n}\n.login-form-forgot {\n  float: right;\n}\n.login-form-button {\n  width: 100%;\n}\n.ant-input-affix-wrapper .ant-input {\n  height: 40px !important;\n}\n.ant-btn {\n  height: 40px !important;\n  margin: 0;\n}\n.logo .systemName {\n  font-size: 24px;\n  font-weight: 400;\n  letter-spacing: 2px;\n  margin-left: 5px;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9saXRlbmcvQXBwL3Blcm1pc3Npb25zLXN5c3RlbS1mcm9udEVuZC9zcmMvYXBwL3BhZ2VzL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5sZXNzIiwic3JjL2FwcC9wYWdlcy9sb2dpbi9sb2dpbi5jb21wb25lbnQubGVzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNJLDBGQUFBO0VBQ0EsNEJBQUE7RUFDQSxpQ0FBQTtFQUNBLHFCQUFBO0VBQ0EsYUFBQTtFQUNBLHNCQUFBO0VBQ0EsZ0JBQUE7QUNDSjtBRENBO0VBQ0ksWUFBQTtFQUNBLG9CQUFBO0FDQ0o7QURFQTtFQUNJLFlBQUE7QUNBSjtBREdBO0VBQ0ksV0FBQTtBQ0RKO0FER0E7RUFDSSx1QkFBQTtBQ0RKO0FER0E7RUFDSSx1QkFBQTtFQUNBLFNBQUE7QUNESjtBREdBO0VBQ0ksZUFBQTtFQUNBLGdCQUFBO0VBQ0EsbUJBQUE7RUFDQSxnQkFBQTtBQ0RKIiwiZmlsZSI6InNyYy9hcHAvcGFnZXMvbG9naW4vbG9naW4uY29tcG9uZW50Lmxlc3MiLCJzb3VyY2VzQ29udGVudCI6WyIuY29udGFpbmVye1xuICAgIGJhY2tncm91bmQtaW1hZ2U6IHVybChodHRwczovL2d3LmFsaXBheW9iamVjdHMuY29tL3pvcy9ybXNwb3J0YWwvVFZZVGJBWFdoZVFwUmNXRGFETXUuc3ZnKTsvL2YwZjNmNFxuICAgIGJhY2tncm91bmQtcmVwZWF0OiBuby1yZXBlYXQ7XG4gICAgYmFja2dyb3VuZC1wb3NpdGlvbjogY2VudGVyIDExMHB4O1xuICAgIGJhY2tncm91bmQtc2l6ZTogMTAwJTtcbiAgICBkaXNwbGF5OiBmbGV4O1xuICAgIGZsZXgtZGlyZWN0aW9uOiBjb2x1bW47XG4gICAgbWluLWhlaWdodDogMTAwJTtcbn1cbi5sb2dpbi1mb3JtIHtcbiAgICB3aWR0aDogMzcwcHg7XG4gICAgbWFyZ2luOiAyMDBweCBhdXRvIDA7XG59XG5cbi5sb2dpbi1mb3JtLWZvcmdvdCB7XG4gICAgZmxvYXQ6IHJpZ2h0O1xufVxuXG4ubG9naW4tZm9ybS1idXR0b24ge1xuICAgIHdpZHRoOiAxMDAlO1xufVxuLmFudC1pbnB1dC1hZmZpeC13cmFwcGVyIC5hbnQtaW5wdXR7XG4gICAgaGVpZ2h0OiA0MHB4ICFpbXBvcnRhbnQ7XG59XG4uYW50LWJ0bntcbiAgICBoZWlnaHQ6IDQwcHggIWltcG9ydGFudDtcbiAgICBtYXJnaW46IDA7XG59XG4ubG9nbyAuc3lzdGVtTmFtZXtcbiAgICBmb250LXNpemU6IDI0cHg7XG4gICAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgICBsZXR0ZXItc3BhY2luZzoycHg7XG4gICAgbWFyZ2luLWxlZnQ6IDVweDtcbn0iLCIuY29udGFpbmVyIHtcbiAgYmFja2dyb3VuZC1pbWFnZTogdXJsKGh0dHBzOi8vZ3cuYWxpcGF5b2JqZWN0cy5jb20vem9zL3Jtc3BvcnRhbC9UVllUYkFYV2hlUXBSY1dEYURNdS5zdmcpO1xuICBiYWNrZ3JvdW5kLXJlcGVhdDogbm8tcmVwZWF0O1xuICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXIgMTEwcHg7XG4gIGJhY2tncm91bmQtc2l6ZTogMTAwJTtcbiAgZGlzcGxheTogZmxleDtcbiAgZmxleC1kaXJlY3Rpb246IGNvbHVtbjtcbiAgbWluLWhlaWdodDogMTAwJTtcbn1cbi5sb2dpbi1mb3JtIHtcbiAgd2lkdGg6IDM3MHB4O1xuICBtYXJnaW46IDIwMHB4IGF1dG8gMDtcbn1cbi5sb2dpbi1mb3JtLWZvcmdvdCB7XG4gIGZsb2F0OiByaWdodDtcbn1cbi5sb2dpbi1mb3JtLWJ1dHRvbiB7XG4gIHdpZHRoOiAxMDAlO1xufVxuLmFudC1pbnB1dC1hZmZpeC13cmFwcGVyIC5hbnQtaW5wdXQge1xuICBoZWlnaHQ6IDQwcHggIWltcG9ydGFudDtcbn1cbi5hbnQtYnRuIHtcbiAgaGVpZ2h0OiA0MHB4ICFpbXBvcnRhbnQ7XG4gIG1hcmdpbjogMDtcbn1cbi5sb2dvIC5zeXN0ZW1OYW1lIHtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBmb250LXdlaWdodDogNDAwO1xuICBsZXR0ZXItc3BhY2luZzogMnB4O1xuICBtYXJnaW4tbGVmdDogNXB4O1xufVxuIl19 */"

/***/ }),

/***/ "./src/app/pages/login/login.component.ts":
/*!************************************************!*\
  !*** ./src/app/pages/login/login.component.ts ***!
  \************************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");
/* harmony import */ var _auth_password_flow_config__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../auth-password-flow.config */ "./src/app/auth-password-flow.config.ts");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");









var LoginComponent = /** @class */ (function () {
    function LoginComponent(fb, http, router, server, oauthService, msg) {
        this.fb = fb;
        this.http = http;
        this.router = router;
        this.server = server;
        this.oauthService = oauthService;
        this.msg = msg;
        this.headers = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]({ 'Content-Type': 'application/json' }); //发送post请求头部
        this.api = 'Account/Login';
        this.systemName = this.server.getSystemName();
        this.oauthService.configure(_auth_password_flow_config__WEBPACK_IMPORTED_MODULE_6__["authPasswordFlowConfig"]);
        this.oauthService.loadDiscoveryDocument();
    }
    LoginComponent.prototype.ngOnInit = function () {
        this.validateForm = this.fb.group({
            UserName: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_8__["Validators"].required]],
            Password: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_8__["Validators"].required]],
        });
    };
    LoginComponent.prototype.submitForm = function (value) {
        var _this = this;
        for (var i in this.validateForm.controls) {
            this.validateForm.controls[i].markAsDirty();
            this.validateForm.controls[i].updateValueAndValidity();
        }
        var options = {
            api: this.api,
            params: value
        };
        this.oauthService
            .fetchTokenUsingPasswordFlowAndLoadUserProfile(value.UserName, value.Password)
            .then(function () {
            _this.msg.info('登录成功！');
            _this.router.navigateByUrl('/home');
        })
            .catch(function (err) {
            _this.msg.info('用户名或者密码错误！');
        });
        // this.router.navigate(['/home/']);
        // this.http.post(environment.projectUrl + options.api, JSON.stringify(options.params), { headers: this.headers }).subscribe((data: any) => {
        //   //  console.log(data)
        //   if (data.msg == '登录成功！') {
        //     //发送菜单数据到server
        //     // this.server.postMenuJson(data.menuJson);
        //   }
        // });
    };
    LoginComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-login',
            template: __webpack_require__(/*! ./login.component.html */ "./src/app/pages/login/login.component.html"),
            styles: [__webpack_require__(/*! ./login.component.less */ "./src/app/pages/login/login.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_forms__WEBPACK_IMPORTED_MODULE_8__["FormBuilder"], _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"], _servers_service__WEBPACK_IMPORTED_MODULE_4__["ServersService"], angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_5__["OAuthService"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_7__["NzMessageService"]])
    ], LoginComponent);
    return LoginComponent;
}());



/***/ }),

/***/ "./src/app/pages/menu/menu.component.html":
/*!************************************************!*\
  !*** ./src/app/pages/menu/menu.component.html ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nz-breadcrumb style=\"margin:1em 0;\" [nzAutoGenerate]=\"true\">\n  <nz-breadcrumb-item>您所在的位置</nz-breadcrumb-item>\n  <nz-breadcrumb-item>{{breadcrumb}}</nz-breadcrumb-item>\n</nz-breadcrumb>\n<div class=\"content\">\n    <div nz-row nzGutter=\"8\" class=\"text-right\" style=\"margin-bottom: 1em\">\n      <div class=\"input-group\">\n        <div class=\"input-group-label\">\n          <nz-form-label>应用程序</nz-form-label>\n        </div>\n        <div class=\"input-group-control\">\n          <nz-select style=\"width: 185px;\" nzPlaceHolder=\"请选择\" [(ngModel)]=\"searchApp\" (ngModelChange)=\"appChange($event)\">\n            <nz-option *ngFor=\"let p of appList\" [nzValue]=\"p\" [nzLabel]=\"p.label\"></nz-option>\n          </nz-select>\n        </div>\n        <app-premission (addMenu)=\"showModal()\" (addPremission)=\"showModalPremission()\" place=\"top\"></app-premission>\n      </div>\n    </div>\n      <div class=\"list-wrapper\">\n        <nz-table #expandTable [nzData]=\"listOfMapData\"  nzBordered nzSize=\"middle\">\n          <thead>\n            <tr>\n              <th>菜单名称</th>\n              <th>链接</th>\n              <th>菜单图标</th>\n              <th>级别</th>\n              <th>顺序</th>\n              <th>描述</th>\n              <th>操作</th>\n            </tr>\n          </thead>\n          <tbody>\n            <ng-container *ngFor=\"let data of expandTable.data\">\n              <ng-container *ngFor=\"let item of mapOfExpandedData[data.menuKey]\">\n                <tr *ngIf=\"item.parent && item.parent.expand || !item.parent\">\n                  <td [nzIndentSize]=\"item.levelNumber * 20\" [nzShowExpand]=\"!!item.children\" [(nzExpand)]=\"item.expand\"\n                    (nzExpandChange)=\"collapse(mapOfExpandedData[data.menuKey],item,$event)\">\n                    {{item.title}}\n                  </td>\n                  <td>{{item.url}}</td>\n                  <td>{{item.iconStr}}</td>\n                  <td>{{item.level}}</td>\n                  <td>{{item.menuOrder}}</td>\n                  <td>{{item.description}}</td>\n                  <td>\n                    <!-- 菜单操作按钮 -->\n                    <div *ngIf=\"!item.permissionId\">\n                      <app-premission (update)=\"editformData(item)\" (delete)=\"deleteRow(item)\" place=\"list\"></app-premission>\n                    </div>\n                    <!-- 权限操作按钮 -->\n                    <div *ngIf=\"item.permissionId\">\n                      <app-premission (update)=\"editePermission(item)\" (delete)=\"deleteRow(item)\" place=\"list\"></app-premission>\n                    </div>\n                  </td>\n                </tr>\n              </ng-container>\n            </ng-container>\n          </tbody>\n        </nz-table>\n      </div>\n      <!-- 新增菜单编辑弹框 -->\n      <nz-modal [(nzVisible)]=\"isVisible\"  nzWidth=\"750\" nzTitle=\"{{modalTitle}}\" nzOkText=\"保存\"\n        (nzOnCancel)=\"handleCancel()\" [nzFooter]=\"modalFooter\" *ngIf=\"isVisible\">\n        <form nz-form [formGroup]=\"validateForm\">\n          <nz-form-item>\n            <nz-form-label [nzSpan]=\"4\">上级菜单</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <nz-tree-select style=\"width: 250px\" formControlName=\"parentMenuId\" [nzNodes]=\"listOfMapData\" nzShowSearch\n                nzPlaceHolder=\"请选择上级菜单\">\n              </nz-tree-select>\n            </nz-form-control>\n            <nz-form-label [nzSpan]=\"4\" nzRequired>菜单名称</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"menuName\" placeholder=\"请输入\" type=\"text\">\n              <nz-form-explain *ngIf=\"validateForm.get('menuName').dirty\">\n                <ng-container *ngIf=\"validateForm.get('menuName').hasError('required')\">\n                  菜单名称不能为空！\n                </ng-container>\n              </nz-form-explain>\n            </nz-form-control>\n          </nz-form-item>\n          <nz-form-item>\n            <nz-form-label [nzSpan]=\"4\">链接</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"url\" placeholder=\"请输入\" type=\"text\">\n            </nz-form-control>\n            <nz-form-label [nzSpan]=\"4\">顺序</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"menuOrder\" placeholder=\"请输入\" type=\"text\">\n            </nz-form-control>\n          </nz-form-item>\n          <nz-form-item>\n            <nz-form-label [nzSpan]=\"4\">菜单图标(icon)</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"iconString\" placeholder=\"请输入\" type=\"text\">\n            </nz-form-control>\n            <nz-form-label [nzSpan]=\"4\">描述</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"description\" placeholder=\"请输入\" type=\"text\">\n            </nz-form-control>\n          </nz-form-item>\n          <ng-template #modalFooter>\n            <button nz-button nzType=\"default\" (click)=\"resetForm()\">重置</button>\n            <button nz-button nzType=\"primary\" [disabled]=\"!validateForm.valid\"\n              (click)=\"submitForm(validateForm.value)\">保存</button>\n          </ng-template>\n        </form>\n      </nz-modal>\n      <!-- 新增权限编辑弹框 -->\n      <nz-modal [(nzVisible)]=\"isVisiblePremission\" nzWidth=\"750\" nzTitle=\"{{modalTitle}}\" nzOkText=\"保存\"\n        (nzOnCancel)=\"handleCancel()\" [nzFooter]=\"modalFooter2\"  *ngIf=\"isVisiblePremission\">\n        <form nz-form [formGroup]=\"validateFormPermission\">\n          <nz-form-item>\n            <nz-form-label [nzSpan]=\"4\" nzRequired>所属菜单</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <nz-tree-select style=\"width: 250px\" formControlName=\"menuId\" [nzNodes]=\"listOfMapData\" nzShowSearch\n                nzPlaceHolder=\"请选择上级菜单\">\n              </nz-tree-select>\n              <nz-form-explain *ngIf=\"validateFormPermission.get('menuId').dirty\">\n                <ng-container *ngIf=\"validateFormPermission.get('menuId').hasError('required')\">\n                  所属菜单不能为空！\n                </ng-container>\n              </nz-form-explain>\n            </nz-form-control>\n            <nz-form-label [nzSpan]=\"4\" nzRequired>权限名称</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"permissionName\" placeholder=\"请输入\" type=\"text\">\n              <nz-form-explain *ngIf=\"validateFormPermission.get('permissionName').dirty\">\n                <ng-container *ngIf=\"validateFormPermission.get('permissionName').hasError('required')\">\n                  权限名称不能为空！\n                </ng-container>\n              </nz-form-explain>\n            </nz-form-control>\n          </nz-form-item>\n          <nz-form-item>\n            <nz-form-label [nzSpan]=\"4\">描述</nz-form-label>\n            <nz-form-control [nzSpan]=\"8\">\n              <input nz-input formControlName=\"permissionDec\" placeholder=\"请输入\" type=\"text\">\n            </nz-form-control>\n          </nz-form-item>\n          <ng-template #modalFooter2>\n            <button nz-button nzType=\"default\" (click)=\"resetFormPermission()\">重置</button>\n            <button nz-button nzType=\"primary\" [disabled]=\"!validateFormPermission.valid\"\n              (click)=\"submitFormPremission(validateFormPermission.value)\">保存</button>\n          </ng-template>\n        </form>\n      </nz-modal>\n      <!-- 查看详情 -->\n      <nz-drawer [nzClosable]=\"false\" [nzWidth]=\"360\" [nzVisible]=\"visibleDetail\" nzPlacement=\"right\" nzTitle=\"详细信息\"\n        (nzOnClose)=\"closeDetail()\">\n        <nz-row class=\"detailItem\" *ngIf=\"openItem.menuName\">\n          <div nz-col [nzSpan]=\"8\">菜单名称:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.menuName}}</div>\n        </nz-row>\n        <nz-row class=\"detailItem\" *ngIf=\"openItem.permissionName\">\n          <div nz-col [nzSpan]=\"8\">权限名称:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.permissionName}}</div>\n        </nz-row>\n        <nz-row class=\"detailItem\" *ngIf=\"openItem.menuOrder\">\n          <div nz-col [nzSpan]=\"8\">顺序:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.menuOrder}}</div>\n        </nz-row>\n        <nz-row class=\"detailItem\" *ngIf=\"openItem.url\">\n          <div nz-col [nzSpan]=\"8\">链接:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.url}}</div>\n        </nz-row>\n        <nz-row class=\"detailItem\" *ngIf=\"openItem.level\">\n          <div nz-col [nzSpan]=\"8\">级别:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.level}}</div>\n        </nz-row>\n        <nz-row class=\"detailItem\" *ngIf=\"openItem.icon\">\n          <div nz-col [nzSpan]=\"8\">菜单图标:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.icon}}</div>\n        </nz-row>\n        <nz-row class=\"detailItem\">\n          <div nz-col [nzSpan]=\"8\">描述:</div>\n          <div nz-col [nzSpan]=\"16\">{{openItem.description}}</div>\n        </nz-row>\n        <div class=\"footer\">\n          <div *ngIf=\"!openItem.permissionId\">\n            <app-premission (update)=\"editformData(item)\" (delete)=\"deleteRow(item)\" place=\"list\"></app-premission>\n            <button type=\"button\" (click)=\"closeDetail()\" class=\"ant-btn\"><span>关闭</span></button>\n          </div>\n          <div *ngIf=\"openItem.permissionId\">\n            <app-premission (update)=\"editePermission(item)\" (delete)=\"deleteRow(item)\" place=\"list\"></app-premission>\n            <button type=\"button\" (click)=\"closeDetail()\" class=\"ant-btn\"><span>关闭</span></button>\n          </div>\n        </div>\n      </nz-drawer>\n</div>"

/***/ }),

/***/ "./src/app/pages/menu/menu.component.less":
/*!************************************************!*\
  !*** ./src/app/pages/menu/menu.component.less ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3BhZ2VzL21lbnUvbWVudS5jb21wb25lbnQubGVzcyJ9 */"

/***/ }),

/***/ "./src/app/pages/menu/menu.component.ts":
/*!**********************************************!*\
  !*** ./src/app/pages/menu/menu.component.ts ***!
  \**********************************************/
/*! exports provided: MenuComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MenuComponent", function() { return MenuComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../environments/environment */ "./src/environments/environment.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");






var MenuComponent = /** @class */ (function () {
    function MenuComponent(server, fb) {
        this.server = server;
        this.fb = fb;
        this.uploadUrl = _environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].API + 'ProjectManage/UploadImgToServer';
        this.api = '/api/MenuManage/GetMenuTreeList'; //列表api
        this.api_delete = '/api/MenuManage/DeleteMenu?id='; //删除行api
        this.api_add = '/api/MenuManage/CreateMenu'; //新增行api
        this.api_update = '/api/MenuManage/EditMenu'; //更新行api
        this.api_add_permission = '/api/MenuManage/CreatePermission'; //新增权限
        this.api_update_permission = '/api/MenuManage/EditPermission'; //编辑权限
        this.api_del_permission = '/api/MenuManage/DeletePermission?id='; //删除权限
        this.visibleDetail = false; //查看详情
        this.openItem = {};
        //表格排序字段
        this.loading = true;
        this.isOkLoading = false;
        this.isVisible = false;
        this.isVisiblePremission = false;
        this.modalTitle = '新增菜单';
        this.breadcrumb = '菜单管理';
        //接收参数
        this.appList = [];
        this.searchApp = null;
        //树形表处理方法
        this.mapOfExpandedData = {};
        // tslint:disable-next-line:no-any
        this.compareFn = function (o1, o2) { return o1 && o2 ? o1.value === o2.value : o1 === o2; };
        this.validateForm = this.fb.group({
            menuName: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_5__["Validators"].required]],
            parentMenuId: [null],
            description: [null],
            iconString: [null],
            url: [null],
            menuOrder: [null]
        });
        this.validateFormPermission = this.fb.group({
            permissionName: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_5__["Validators"].required]],
            menuId: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_5__["Validators"].required]],
            permissionDec: [null],
        });
    }
    MenuComponent.prototype.collapse = function (array, data, $event) {
        var _this = this;
        if ($event === false) {
            if (data.children) {
                data.children.forEach(function (d) {
                    var target = array.find(function (a) { return a.menuKey === d.menuKey; });
                    target.expand = false;
                    _this.collapse(array, target, false);
                });
            }
            else {
                return;
            }
        }
    };
    MenuComponent.prototype.convertTreeToList = function (root) {
        var stack = [];
        var array = [];
        var hashMap = {};
        stack.push(tslib__WEBPACK_IMPORTED_MODULE_0__["__assign"]({}, root, { levelNumber: 0, expand: false }));
        while (stack.length !== 0) {
            var node = stack.pop();
            this.visitNode(node, hashMap, array);
            if (node.children) {
                for (var i = node.children.length - 1; i >= 0; i--) {
                    stack.push(tslib__WEBPACK_IMPORTED_MODULE_0__["__assign"]({}, node.children[i], { levelNumber: node.levelNumber + 1, expand: false, parent: node }));
                }
            }
        }
        return array;
    };
    MenuComponent.prototype.visitNode = function (node, hashMap, array) {
        if (!hashMap[node.menuKey]) {
            hashMap[node.menuKey] = true;
            array.push(node);
        }
    };
    MenuComponent.prototype.ngOnInit = function () {
        var _this = this;
        //获取应用程序列表
        this.server.getAppList().subscribe(function (data) {
            _this.appList = data;
            _this.searchApp = data[0];
            //获取页面列表
            _this.getDataList();
        });
    };
    MenuComponent.prototype.getDataList = function () {
        var _this = this;
        var options = {
            api: this.api,
            params: {
                appId: this.searchApp.id
            }
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            //数据处理
            data.forEach(function (element) {
                //级别+id
                element.key = element.level + '#' + element.menuId; //一级菜单
                element.menuKey = element.menuId;
                element.title = element.menuName;
                element.iconStr = element.icon;
                delete element.icon;
                if (element.children) {
                    _this.menuTransform(element.children);
                }
            });
            _this.listOfMapData = data;
            _this.listOfMapData.forEach(function (item) {
                _this.mapOfExpandedData[item.menuId] = _this.convertTreeToList(item);
            });
        });
    };
    //应用程序下拉组件改变事件
    MenuComponent.prototype.appChange = function (event) {
        this.getDataList();
    };
    // 菜单列表格式化
    MenuComponent.prototype.menuTransform = function (childrens) {
        var _this = this;
        childrens.forEach(function (element) {
            if (element.children) {
                element.key = element.level - 1 + '#' + element.menuId;
                element.menuKey = element.menuId;
                element.title = element.menuName;
                element.iconStr = element.icon;
                delete element.icon;
                if (!element.children[0].level) {
                    element.isLeaf = true;
                }
                _this.menuTransform(element.children);
            }
            else {
                element.menuKey = '30' + element.permissionId;
                element.title = element.menuName || element.permissionName;
                return;
            }
        });
    };
    // 打开菜单表单
    MenuComponent.prototype.showModal = function () {
        this.modalTitle = '新增菜单';
        this.menuId = '';
        this.isVisible = true;
        this.validateForm.reset();
        for (var menuId in this.validateForm.controls) {
            this.validateForm.controls[menuId].markAsPristine();
            this.validateForm.controls[menuId].updateValueAndValidity();
        }
    };
    // 打开权限表单
    MenuComponent.prototype.showModalPremission = function () {
        this.modalTitle = '新增权限';
        this.permissionId = '';
        this.isVisiblePremission = true;
        this.validateFormPermission.reset();
        for (var menuId in this.validateFormPermission.controls) {
            this.validateFormPermission.controls[menuId].markAsPristine();
            this.validateFormPermission.controls[menuId].updateValueAndValidity();
        }
    };
    //重置菜单表单
    MenuComponent.prototype.resetForm = function () {
        this.validateForm.reset();
        for (var key in this.validateForm.controls) {
            this.validateForm.controls[key].markAsPristine();
            this.validateForm.controls[key].updateValueAndValidity();
        }
    };
    //重置权限表单
    MenuComponent.prototype.resetFormPermission = function () {
        this.validateFormPermission.reset();
        for (var key in this.validateForm.controls) {
            this.validateFormPermission.controls[key].markAsPristine();
            this.validateFormPermission.controls[key].updateValueAndValidity();
        }
    };
    //保存数据
    MenuComponent.prototype.submitForm = function (value) {
        var _this = this;
        this.isOkLoading = true;
        var paramsObj = {
            menuName: value.menuName,
            url: value.url,
            level: value.parentMenuId ? (parseInt(value.parentMenuId.split("#")[0]) + 1) : 1,
            parentMenuId: value.parentMenuId ? parseInt(value.parentMenuId.split("#")[1]) : 0,
            description: value.description,
            icon: value.iconString,
            menuOrder: value.menuOrder
        };
        if (this.menuId) {
            paramsObj.menuId = this.menuId;
        }
        var options = {
            api: this.menuId ? this.api_update : this.api_add,
            params: paramsObj
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.isVisible = false;
            _this.isOkLoading = false;
            _this.visibleDetail = false;
            _this.getDataList();
        });
    };
    //保存数据
    MenuComponent.prototype.submitFormPremission = function (value) {
        var _this = this;
        this.isOkLoading = true;
        var paramsObj = {
            permissionName: value.permissionName,
            menuId: parseInt(value.menuId.split("#")[1]),
            description: value.permissionDec,
            menuOrder: value.menuOrder
        };
        if (this.permissionId) {
            paramsObj.permissionId = this.permissionId;
        }
        var options = {
            api: this.permissionId ? this.api_update_permission : this.api_add_permission,
            params: paramsObj
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.isVisiblePremission = false;
            _this.isOkLoading = false;
        });
    };
    MenuComponent.prototype.handleCancel = function () {
        this.isVisible = false;
        this.isVisiblePremission = false;
    };
    //删除记录
    MenuComponent.prototype.deleteRow = function (value) {
        var _this = this;
        var options = {
            api: this.api_delete + value,
            params: value
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.getDataList();
        });
    };
    //删除权限
    MenuComponent.prototype.delPermission = function (value) {
        var _this = this;
        var options = {
            api: this.api_del_permission + value,
            params: value
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.getDataList();
        });
    };
    //编辑菜单
    MenuComponent.prototype.editformData = function (item) {
        var _this = this;
        this.modalTitle = '编辑菜单';
        // 配置弹框数据
        this.menuId = item.menuId;
        //表单赋值
        var initformData = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Observable"](function (observer) {
            _this.validateForm.setValue({ menuName: item.menuName, parentMenuId: item.parent ? item.parent.key : null, iconString: item.iconStr, url: item.url, description: item.description, menuOrder: item.menuOrder });
            observer.next();
        });
        initformData.subscribe(function () {
            _this.isVisible = true;
        });
    };
    //编辑权限
    MenuComponent.prototype.editePermission = function (item) {
        // 配置弹框数据
        this.permissionId = item.permissionId;
        this.validateFormPermission.setValue({ permissionName: item.permissionName, menuId: item.parent.key, permissionDec: item.description });
        this.isVisiblePremission = true;
    };
    //上级菜单树选择事件
    MenuComponent.prototype.onChange = function ($event) {
        this.validateForm.value.level = $event.split("#")[0];
    };
    //查看详情
    MenuComponent.prototype.openDetail = function (item) {
        this.openItem = item;
        this.visibleDetail = true;
    };
    MenuComponent.prototype.closeDetail = function () {
        this.visibleDetail = false;
    };
    MenuComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-menu',
            template: __webpack_require__(/*! ./menu.component.html */ "./src/app/pages/menu/menu.component.html"),
            styles: [__webpack_require__(/*! ./menu.component.less */ "./src/app/pages/menu/menu.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_2__["ServersService"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormBuilder"]])
    ], MenuComponent);
    return MenuComponent;
}());



/***/ }),

/***/ "./src/app/pages/permission/permission.component.html":
/*!************************************************************!*\
  !*** ./src/app/pages/permission/permission.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nz-breadcrumb style=\"margin:1em 0;\" [nzAutoGenerate]=\"true\">\n  <nz-breadcrumb-item>您所在的位置</nz-breadcrumb-item>\n  <nz-breadcrumb-item>{{breadcrumb}}</nz-breadcrumb-item>\n</nz-breadcrumb>\n<div class=\"content\">\n  <!-- content -->\n  <div nz-row nzGutter=\"8\" class=\"text-right\" style=\"margin-bottom: 1em\">\n    <div class=\"input-group\">\n      <div class=\"input-group-label\">\n        <nz-form-label>应用程序</nz-form-label>\n      </div>\n      <div class=\"input-group-control\">\n        <nz-select style=\"width: 185px;\" nzPlaceHolder=\"请选择\" [(ngModel)]=\"searchApp\" (ngModelChange)=\"appChange($event)\">\n          <nz-option *ngFor=\"let p of appList\" [nzValue]=\"p\" [nzLabel]=\"p.label\"></nz-option>\n        </nz-select>\n      </div>\n    </div>\n    <button class=\"btn\" nz-button nzType=\"primary\" (click)=\"changeAllCheck(false)\">清空</button>\n    <button class=\"btn\" nz-button nzType=\"primary\" (click)=\"changeAllCheck(true)\">全选</button>\n    <app-premission (save)=\"submitForm()\" place=\"top\" hasSave=\"true\"></app-premission>\n  </div>\n  <div class=\"container\">\n    <div class=\"pannel\">\n      <div class=\"list-wrapper\">\n        <div nz-row nzGutter=\"16\">\n          <div nz-col nzSpan=\"8\">\n            <nz-table #rowSelectionTable nzShowSizeChanger [nzData]=\"displayData\" [nzLoading]=\"isOkLoading\"\n              (nzCurrentPageDataChange)=\"currentPageDataChange($event)\" nzBordered nzSize=\"middle\">\n              <thead>\n                <tr>\n                  <th>角色列表</th>\n                </tr>\n              </thead>\n              <tbody>\n                <tr *ngFor=\"let data of rowSelectionTable.data\">\n                  <td>\n                    <nz-radio-group [(ngModel)]=\"radioValue\">\n                      <label nz-radio nzValue=\"{{data.roleId}}\"\n                        (click)=\"refreshData(data.roleId)\">{{data.roleName}}</label>\n                    </nz-radio-group>\n                  </td>\n                </tr>\n              </tbody>\n            </nz-table>\n          </div>\n          <div nz-col nzSpan=\"16\">\n            <!-- 菜单列表 -->\n            <nz-table #expandTable [nzData]=\"listOfMapData\" nzBordered nzSize=\"middle\">\n              <thead>\n                <tr>\n                  <th>菜单</th>\n                  <th>权限</th>\n                </tr>\n              </thead>\n              <tbody>\n                <ng-container *ngFor=\"let data of listOfMapData\">\n                  <ng-container *ngFor=\"let item of mapOfExpandedData[data.menuId]\">\n                    <tr *ngIf=\"item.parent && item.parent.expand || !item.parent\">\n                      <td [nzIndentSize]=\"item.level * 20\" [nzShowExpand]=\"!!item.children\" [(nzExpand)]=\"item.expand\"\n                        (nzExpandChange)=\"collapse(mapOfExpandedData[data.menuId],item,$event)\">\n                        <!-- 菜单列表 -->\n                        <label *ngIf=\"!item.permission\" nz-checkbox [(ngModel)]=\"item.selected\"\n                          (ngModelChange)=\"updateAllChecked(item,$event)\"\n                          style=\"margin-right:5px\">{{item.menuName}}</label>\n                        <!-- 权限列表 -->\n                        <label *ngIf=\"item.permission\" nz-checkbox [(ngModel)]=\"item.selected\"\n                          (ngModelChange)=\"updateAllChecked(item,$event)\"\n                          style=\"margin-right:5px\">{{item.menuName}}</label>\n                      </td>\n                      <td>\n                        <span *ngIf=\"item.permissionName\">\n                          <label nz-checkbox [(ngModel)]=\"item.useYn\"\n                            (ngModelChange)=\"changeReadPage(item,$event)\">{{item.permissionName}}</label>\n                        </span>\n                        <span *ngFor=\"let p of item.permission\">\n                          <label nz-checkbox [(ngModel)]=\"p.useYn\"\n                            (ngModelChange)=\"checkPermission(item,$event)\">{{p.permissionName}}</label>\n                        </span>\n                      </td>\n                    </tr>\n                  </ng-container>\n                </ng-container>\n              </tbody>\n            </nz-table>\n          </div>\n        </div>\n      </div>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "./src/app/pages/permission/permission.component.less":
/*!************************************************************!*\
  !*** ./src/app/pages/permission/permission.component.less ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".btn {\n  margin-left: 1em;\n}\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi9Vc2Vycy9saXRlbmcvQXBwL3Blcm1pc3Npb25zLXN5c3RlbS1mcm9udEVuZC9zcmMvYXBwL3BhZ2VzL3Blcm1pc3Npb24vcGVybWlzc2lvbi5jb21wb25lbnQubGVzcyIsInNyYy9hcHAvcGFnZXMvcGVybWlzc2lvbi9wZXJtaXNzaW9uLmNvbXBvbmVudC5sZXNzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksZ0JBQUE7QUNDSiIsImZpbGUiOiJzcmMvYXBwL3BhZ2VzL3Blcm1pc3Npb24vcGVybWlzc2lvbi5jb21wb25lbnQubGVzcyIsInNvdXJjZXNDb250ZW50IjpbIi5idG4ge1xuICAgIG1hcmdpbi1sZWZ0OiAxZW07XG59IiwiLmJ0biB7XG4gIG1hcmdpbi1sZWZ0OiAxZW07XG59XG4iXX0= */"

/***/ }),

/***/ "./src/app/pages/permission/permission.component.ts":
/*!**********************************************************!*\
  !*** ./src/app/pages/permission/permission.component.ts ***!
  \**********************************************************/
/*! exports provided: PermissionComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PermissionComponent", function() { return PermissionComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");






var PermissionComponent = /** @class */ (function () {
    function PermissionComponent(server, http, fb, msg) {
        this.server = server;
        this.http = http;
        this.fb = fb;
        this.msg = msg;
        this.mapOfExpandData = {};
        this.headers = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]({ 'Content-Type': 'application/json' }); //发送post请求头部
        this.isLoading = false; //用于加载效果
        this.api = '/api/RoleManage/GetRoleList'; //获取角色列表
        this.api_premission = '/api/RoleAuthorization/GetPermissionTreeList'; //获取授权列表
        this.api_submit = '/api/RoleAuthorization/SaveRolePermission'; //保存角色授权
        this.breadcrumb = '授权管理';
        //表格排序字段
        this.sortName = null;
        this.sortValue = null;
        this.listOfSearchName = [];
        this.Page = 1;
        this.Rows = 10;
        this.total = 20;
        this.Name = '';
        this.Id = null;
        this.Sidx = '0';
        this.Sord = null;
        this.OrderBy = null;
        this.loading = true;
        this.modalTitle = '新增角色';
        this.selectedPremission = [];
        this.isOkLoading = false;
        this.isAllDisplayDataChecked = false;
        this.isIndeterminate = false;
        this.listOfAllData = [];
        this.mapOfCheckedId = {};
        //接收参数
        this.appList = [];
        this.searchApp = null;
        //树形表处理方法
        this.mapOfExpandedData = {};
    }
    PermissionComponent.prototype.currentPageDataChange = function ($event) {
        this.displayData = $event;
        this.refreshStatus();
    };
    PermissionComponent.prototype.refreshStatus = function () {
        var _this = this;
        this.isAllDisplayDataChecked = this.displayData.every(function (item) { return _this.mapOfCheckedId[item.roleId]; });
        this.isIndeterminate = this.displayData.some(function (item) { return _this.mapOfCheckedId[item.roleId]; }) && !this.isAllDisplayDataChecked;
    };
    PermissionComponent.prototype.checkAll = function (value) {
        var _this = this;
        this.displayData.forEach(function (item) { return _this.mapOfCheckedId[item.roleId] = value; });
        this.refreshStatus();
    };
    PermissionComponent.prototype.ngOnInit = function () {
        var _this = this;
        //获取应用程序列表
        this.server.getAppList().subscribe(function (data) {
            _this.appList = data;
            _this.searchApp = data[0];
            //获取页面列表
            _this.getDataList();
        });
    };
    //获取角色列表
    PermissionComponent.prototype.getDataList = function () {
        var _this = this;
        this.isOkLoading = true;
        var options = {
            api: this.api,
            params: {
                Sidx: '0',
                Page: this.Page,
                Rows: this.Rows,
                AppId: this.searchApp.id
            }
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.displayData = data.pageResult.data;
            _this.radioValue = data.pageResult.data[0].roleId.toString();
            _this.getPremissionList(_this.radioValue);
        });
        this.isOkLoading = false;
    };
    PermissionComponent.prototype.refreshData = function (roleId) {
        this.getPremissionList(roleId);
    };
    //获取权限列表
    PermissionComponent.prototype.getPremissionList = function (roleId) {
        var _this = this;
        this.selectedPremission = [];
        var options = {
            api: this.api_premission,
            params: {
                roleId: roleId,
            }
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            //判断权限全选功能
            // this.findCheckAll(data, 1);
            _this.listOfMapData = data.data;
            _this.findCheckAll(_this.listOfMapData, 1);
            _this.listOfMapData.forEach(function (item) {
                _this.mapOfExpandedData[item.menuId] = _this.convertTreeToList(item);
            });
        });
    };
    PermissionComponent.prototype.collapse = function (array, data, $event) {
        var _this = this;
        if ($event === false) {
            if (data.children) {
                data.children.forEach(function (d) {
                    var target = array.find(function (a) { return a.menuId === d.menuId; });
                    target.expand = false;
                    _this.collapse(array, target, false);
                });
            }
            else {
                return;
            }
        }
    };
    PermissionComponent.prototype.convertTreeToList = function (root) {
        var count = 0;
        root['children'].forEach(function (element) {
            if (element.selected) {
                count++;
            }
            root['selected'] = (root['children'].length == count && root['useYn']) ? true : false;
        });
        var stack = [];
        var array = [];
        var hashMap = {};
        stack.push(tslib__WEBPACK_IMPORTED_MODULE_0__["__assign"]({}, root, { level: 0, expand: false }));
        while (stack.length !== 0) {
            var node = stack.pop();
            this.visitNode(node, hashMap, array);
            if (node.children) {
                for (var i = node.children.length - 1; i >= 0; i--) {
                    stack.push(tslib__WEBPACK_IMPORTED_MODULE_0__["__assign"]({}, node.children[i], { level: node.level + 1, expand: false, parent: node }));
                }
            }
        }
        return array;
    };
    PermissionComponent.prototype.visitNode = function (node, hashMap, array) {
        if (!hashMap[node.menuId]) {
            hashMap[node.menuId] = true;
            array.push(node);
        }
    };
    //权限数组提取
    PermissionComponent.prototype.findCheckAll = function (list, type) {
        var _this = this;
        var count = 0;
        list.forEach(function (element) {
            if (element.children) {
                _this.findCheckAll(element.children, type);
            }
            else if (element.permission) {
                _this.checkPermission(element, type);
            }
        });
    };
    //权限列表全选判断
    PermissionComponent.prototype.checkPermission = function (item, event) {
        if (!event) {
            item['selected'] = false;
            this.mapOfExpandedData[item.parentMenuId][0]['selected'] = false;
        }
        else {
            var count_1 = 0;
            item.permission.forEach(function (element) {
                if (element.useYn) {
                    count_1++;
                }
            });
            item.selected = count_1 == item.permission.length ? true : false;
            if (event === true) {
                var count2_1 = 0;
                this.mapOfExpandedData[item.parentMenuId].forEach(function (element2, index) {
                    if (index != 0 && element2['selected']) {
                        count2_1++;
                    }
                });
                if (count2_1 == this.mapOfExpandedData[item.parentMenuId].length - 1) {
                    this.mapOfExpandedData[item.parentMenuId][0]['selected'] = true;
                }
            }
        }
    };
    //查看页面权限修改
    PermissionComponent.prototype.changeReadPage = function (item, event) {
        if (!event) {
            item['selected'] = false;
        }
        else {
            var count_2 = 0;
            item.children.forEach(function (element, index) {
                if (element['selected']) {
                    count_2++;
                }
            });
            if (count_2 == item.children.length) {
                item['selected'] = true;
            }
        }
    };
    //菜单全选修改事件
    PermissionComponent.prototype.menuCheckAll = function (menuId, list) {
        var count = 0;
        if (list) {
            list.forEach(function (element) {
                if (element.menuId == menuId) {
                    element.children.forEach(function (item) {
                        if (item.selected) {
                            count++;
                        }
                    });
                    element.selected = count == element.children.length ? true : false;
                }
            });
        }
    };
    //行全选事件
    PermissionComponent.prototype.updateAllChecked = function (item, event) {
        // 改变子集
        if (item.permission) {
            this.mapOfExpandedData[item.parent.menuId].forEach(function (element) {
                if (element.menuId == item.menuId) {
                    element['permission'] = element['permission'].map(function (element2) {
                        return tslib__WEBPACK_IMPORTED_MODULE_0__["__assign"]({}, element2, { useYn: event });
                    });
                }
            });
            this.mapOfExpandedData[item.parent.menuId][0].children.forEach(function (element) {
                if (element.menuId == item.menuId) {
                    element['permission'] = element['permission'].map(function (element2) {
                        return tslib__WEBPACK_IMPORTED_MODULE_0__["__assign"]({}, element2, { useYn: event });
                    });
                }
            });
        }
        //改变上级选中
        if (item.level > 0) {
            if (!event) {
                this.mapOfExpandedData[item.parent.menuId][0]['selected'] = false;
            }
            else {
                var count_3 = 0;
                this.mapOfExpandedData[item.parent.menuId].forEach(function (element, index) {
                    if (index != 0 && element['selected']) {
                        count_3++;
                    }
                });
                if (count_3 == this.mapOfExpandedData[item.parent.menuId].length - 1 && this.mapOfExpandedData[item.parent.menuId][0]['useYn']) {
                    this.mapOfExpandedData[item.parent.menuId][0]['selected'] = true;
                }
            }
        }
        else {
            this.mapOfExpandedData[item.menuId].forEach(function (ele) {
                ele['useYn'] = event;
                ele['selected'] = event;
                if (ele['permission']) {
                    ele['permission'].forEach(function (per) {
                        per['useYn'] = event;
                    });
                }
            });
        }
    };
    //保存数据
    PermissionComponent.prototype.submitForm = function () {
        var _this = this;
        this.selectedPremission = [];
        var dataList = [];
        for (var i in this.mapOfExpandedData) {
            if (this.mapOfExpandedData[i][0]['useYn']) {
                this.selectedPremission.push(this.mapOfExpandedData[i][0]['permissionId']);
            }
            dataList.push(this.mapOfExpandedData[i][0]);
        }
        this.getSelectedPremission(dataList);
        //提取数据
        var paramsObj = {
            roleId: this.radioValue,
            buttonIds: this.selectedPremission,
        };
        var options = {
            api: this.api_submit,
            params: paramsObj
        };
        //保存权限
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.status = new Date();
        });
    };
    PermissionComponent.prototype.getSelectedPremission = function (list) {
        var _this = this;
        if (list) {
            list.forEach(function (element) {
                if (element.children) {
                    _this.getSelectedPremission(element.children);
                }
                else {
                    element.permission.forEach(function (item) {
                        if (item.useYn) {
                            _this.selectedPremission.push(item.permissionId);
                        }
                    });
                }
            });
        }
    };
    //清除选项
    PermissionComponent.prototype.changeAllCheck = function (status) {
        this.selectedPremission = status ? this.selectedPremission : [];
        var dataList = [];
        for (var i in this.mapOfExpandedData) {
            this.mapOfExpandedData[i].forEach(function (item) {
                dataList.push(item);
            });
        }
        this.clearPremission(dataList, status);
        this.projectData.forEach(function (element) {
            element.useYn = status;
        });
    };
    PermissionComponent.prototype.clearPremission = function (list, status) {
        var _this = this;
        if (list) {
            list.forEach(function (element) {
                element['selected'] = status;
                if (element.children) {
                    element['useYn'] = status;
                    element['selected'] = status;
                    _this.clearPremission(element.children, status);
                }
                else {
                    element.permission.forEach(function (item) {
                        item.useYn = status;
                        item['selected'] = status;
                    });
                }
            });
        }
    };
    //应用程序下拉组件改变事件
    PermissionComponent.prototype.appChange = function (event) {
        this.getDataList();
    };
    PermissionComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-permission',
            encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].None,
            template: __webpack_require__(/*! ./permission.component.html */ "./src/app/pages/permission/permission.component.html"),
            styles: [__webpack_require__(/*! ./permission.component.less */ "./src/app/pages/permission/permission.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_3__["ServersService"], _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormBuilder"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_4__["NzMessageService"]])
    ], PermissionComponent);
    return PermissionComponent;
}());



/***/ }),

/***/ "./src/app/pages/role/role.component.html":
/*!************************************************!*\
  !*** ./src/app/pages/role/role.component.html ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n<nz-breadcrumb style=\"margin:1em 0;\" [nzAutoGenerate]=\"true\">\n  <nz-breadcrumb-item>您所在的位置</nz-breadcrumb-item>\n  <nz-breadcrumb-item>{{breadcrumb}}</nz-breadcrumb-item>\n</nz-breadcrumb>\n<div class=\"content\">\n<div nz-row nzGutter=\"8\" class=\"text-right\">\n  <app-search (search)=\"searchData($event)\" (add)=\"showModal()\"></app-search>\n  <div class=\"input-group\">\n    <div class=\"input-group-label\">\n      <nz-form-label>应用程序</nz-form-label>\n    </div>\n    <div class=\"input-group-control\">\n      <nz-select style=\"width: 185px;\" nzPlaceHolder=\"请选择\" [(ngModel)]=\"searchApp\" (ngModelChange)=\"appChange($event)\">\n        <nz-option *ngFor=\"let p of appList\" [nzValue]=\"p\" [nzLabel]=\"p.label\"></nz-option>\n      </nz-select>\n    </div>\n  </div>\n  <app-premission (add)=\"showModal()\" place=\"top\"></app-premission>\n</div>\n<nz-table #basicTable [nzData]=\"displayData\" nzBordered nzSize=\"middle\">\n  <thead>\n    <tr>\n      <th>角色名称</th>\n      <th>描述</th>\n      <th>创建人 </th>\n      <th>创建日期</th>\n      <th>是否启用</th>\n      <th>操作</th>\n    </tr>\n  </thead>\n  <tbody>\n    <tr *ngFor=\"let item of basicTable.data\">\n      <td>{{ item.roleName }}</td>\n      <td>{{ item.description }}</td>\n      <td>{{ item.createUserName }}</td>\n      <td>{{ item.createTime | date : 'yyyy-MM-dd HH:mm:ss'}}</td>\n      <td>{{ item.strUseYn }}</td>\n      <td>\n        <app-premission (update)=\"editRow(item)\" (delete)=\"deleteRow(item)\" place=\"list\"></app-premission>\n      </td>\n    </tr>\n  </tbody>\n</nz-table>\n<!-- 编辑框 -->\n<nz-modal [(nzVisible)]=\"isVisible\" [nzWidth]=\"700\" nzTitle=\"{{modelTitle}}\" nzOkText=\"确定\" nzCancelText=\"取消\"\n  (nzOnOk)=\"handleOk()\" (nzOnCancel)=\"handleCancel()\" [nzFooter]=\"modalFooter\">\n  <form nz-form [formGroup]=\"validateForm\">\n    <nz-form-item>\n      <nz-form-label [nzSpan]=\"4\" nzRequired>角色名称</nz-form-label>\n      <nz-form-control [nzSpan]=\"20\">\n        <input nz-input formControlName=\"roleName\" placeholder=\"请输入\" type=\"text\">\n        <nz-form-explain *ngIf=\"validateForm.get('roleName').dirty\">\n          <ng-container *ngIf=\"validateForm.get('roleName').hasError('required')\">\n            角色名称不能为空！\n          </ng-container>\n        </nz-form-explain>\n      </nz-form-control>\n    </nz-form-item>\n    <nz-form-item>\n      <nz-form-label [nzSpan]=\"4\">角色描述</nz-form-label>\n      <nz-form-control [nzSpan]=\"20\">\n        <textarea nz-input rows=\"3\" formControlName=\"description\" placeholder=\"请输入\" type=\"text\"></textarea>\n      </nz-form-control>\n    </nz-form-item>\n    <ng-template #modalFooter>\n      <button nz-button nzType=\"default\" (click)=\"resetForm()\">重置</button>\n      <button nz-button nzType=\"primary\" [disabled]=\"!validateForm.valid\"\n        (click)=\"submitForm(validateForm.value)\">保存</button>\n    </ng-template>\n  </form>\n</nz-modal>\n</div>"

/***/ }),

/***/ "./src/app/pages/role/role.component.less":
/*!************************************************!*\
  !*** ./src/app/pages/role/role.component.less ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3BhZ2VzL3JvbGUvcm9sZS5jb21wb25lbnQubGVzcyJ9 */"

/***/ }),

/***/ "./src/app/pages/role/role.component.ts":
/*!**********************************************!*\
  !*** ./src/app/pages/role/role.component.ts ***!
  \**********************************************/
/*! exports provided: RoleComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RoleComponent", function() { return RoleComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");







var RoleComponent = /** @class */ (function () {
    //初始化构造函数
    function RoleComponent(server, http, fb, msg) {
        this.server = server;
        this.http = http;
        this.fb = fb;
        this.msg = msg;
        this.api_list = '/api/RoleManage/GetRoleList'; // 页面数据列表api
        this.api_add = '/api/RoleManage/CreateRole'; // 新增行api
        this.api_update = '/api/RoleManage/EditRole'; // 更新行api
        this.api_delete = '/api/RoleManage/DeleteRole?id='; // 删除行api
        //列表相关数据
        this.displayData = []; //存储列表数据
        this.isLoading = false; //用于加载效果
        this.Page = 1; //初始页码
        this.Rows = 10; //显示行数
        this.total = 1; //总条数
        this.Sord = null; //正反序
        this.OrderBy = null; //排序字段
        this.loading = true; //开启加载
        this.Sidx = '0';
        this.colData = null;
        //modal 参数
        this.modelTitle = '新增'; //弹窗标题
        this.headers = new _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpHeaders"]({ 'Content-Type': 'application/json' }); //发送post请求头部
        this.isVisible = false; //控制窗口是否显示
        this.roleId = ''; //行id
        //接收参数
        this.appList = [];
        this.searchApp = null;
        this.breadcrumb = '角色管理';
        this.validateForm = this.fb.group({
            roleName: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].required]],
            description: [null],
        });
    }
    RoleComponent.prototype.ngOnInit = function () {
        var _this = this;
        //获取应用程序列表
        this.server.getAppList().subscribe(function (data) {
            _this.appList = data;
            _this.searchApp = data[0];
            //获取页面列表
            _this.getDataList();
        });
    };
    //获取列表数据
    RoleComponent.prototype.getDataList = function () {
        var _this = this;
        var options = {
            api: this.api_list,
            params: {
                Sidx: '0',
                Page: this.Page,
                Rows: this.Rows,
                AppId: this.searchApp.id
            }
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.colData = data.pageResult.data;
            _this.displayData = _this.colData.slice();
        });
    };
    //应用程序下拉组件改变事件
    RoleComponent.prototype.appChange = function (event) {
        this.getDataList();
    };
    //搜索事件
    RoleComponent.prototype.searchData = function (keyword, reset) {
        var _this = this;
        if (reset === void 0) { reset = false; }
        this.isLoading = true;
        if (reset) {
            this.Page = 1;
        }
        this.loading = true;
        this.getList(keyword, this.Page, this.Rows, this.Sidx).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.colData = data.pageResult.data;
            _this.displayData = _this.colData.slice();
            _this.isLoading = false;
        });
    };
    RoleComponent.prototype.getList = function (keyword, pageIndex, pageSize, Sidx) {
        if (pageIndex === void 0) { pageIndex = 1; }
        if (pageSize === void 0) { pageSize = 10; }
        var params = {};
        params.Name = keyword ? keyword : '';
        params.AppId = this.searchApp.id;
        if (this.Page) {
            params.Page = this.Page;
        }
        if (this.Rows) {
            params.Rows = this.Rows;
        }
        if (this.Sidx) {
            params.Sidx = this.Sidx;
        }
        if (this.Sord) {
            params.Sord = this.Sord;
        }
        var options = {
            api: this.api_list,
            params: params
        };
        return this.server.getRxjsData(options);
    };
    //打开弹框
    RoleComponent.prototype.showModal = function () {
        this.isVisible = true;
        this.roleId = '';
        //表单初始化
        this.resetForm();
    };
    //弹框确定事件
    RoleComponent.prototype.handleOk = function () {
        this.isVisible = false;
    };
    //弹框取消事件
    RoleComponent.prototype.handleCancel = function () {
        this.isVisible = false;
    };
    RoleComponent.prototype.resetForm = function () {
        this.validateForm.reset();
        for (var key in this.validateForm.controls) {
            this.validateForm.controls[key].markAsPristine();
            this.validateForm.controls[key].updateValueAndValidity();
        }
    };
    //编辑行
    RoleComponent.prototype.editRow = function (item) {
        var _this = this;
        this.roleId = item.roleId;
        //初始化表单值
        var initformData = new rxjs__WEBPACK_IMPORTED_MODULE_4__["Observable"](function (observer) {
            _this.validateForm.setValue({ roleName: item.roleName, description: item.description });
            observer.next();
        });
        initformData.subscribe(function () {
            _this.isVisible = true;
            _this.modelTitle = '编辑';
        });
    };
    //保存行
    RoleComponent.prototype.submitForm = function (value) {
        var _this = this;
        var paramsObj = value;
        if (this.roleId) {
            paramsObj.roleId = this.roleId;
        }
        paramsObj.appId = this.searchApp.id;
        var options = {
            api: this.roleId ? this.api_update : this.api_add,
            params: value,
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.isVisible = false;
            _this.searchData();
        });
    };
    //删除行
    RoleComponent.prototype.deleteRow = function (item) {
        var _this = this;
        var options = {
            api: this.api_delete + item.roleId,
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.searchData();
        });
    };
    RoleComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-role',
            template: __webpack_require__(/*! ./role.component.html */ "./src/app/pages/role/role.component.html"),
            styles: [__webpack_require__(/*! ./role.component.less */ "./src/app/pages/role/role.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_2__["ServersService"], _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClient"], _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormBuilder"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NzMessageService"]])
    ], RoleComponent);
    return RoleComponent;
}());



/***/ }),

/***/ "./src/app/pages/user/user.component.html":
/*!************************************************!*\
  !*** ./src/app/pages/user/user.component.html ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nz-breadcrumb style=\"margin:1em 0;\" [nzAutoGenerate]=\"true\">\n  <nz-breadcrumb-item>您所在的位置</nz-breadcrumb-item>\n  <nz-breadcrumb-item>{{breadcrumb}}</nz-breadcrumb-item>\n</nz-breadcrumb>\n<div class=\"content\">\n<div nz-row nzGutter=\"8\" class=\"text-right\">\n  <app-search (search)=\"searchData($event)\" (add)=\"showModal()\"></app-search>\n  <app-premission (add)=\"showModal()\" place=\"top\"></app-premission>\n</div>\n<nz-table #basicTable [nzData]=\"displayData\" nzBordered nzSize=\"middle\">\n  <thead>\n    <tr>\n      <th>用户名称</th>\n      <th>手机号</th>\n      <th>电话</th>\n      <th>邮件 </th>\n      <th>职务</th>\n      <th>操作</th>\n    </tr>\n  </thead>\n  <tbody>\n    <tr *ngFor=\"let item of basicTable.data\">\n      <td>{{ item.sysUserName }}</td>\n      <td>{{ item.mobile }}</td>\n      <td>{{item.telephone}}</td>\n      <td>{{ item.email }}</td>\n      <td>{{ item.position}}</td>\n      <td>\n        <app-premission (read)=\"openDetail(item)\" (update)=\"editRow(item)\" (delete)=\"deleteRow(item)\" place=\"list\"  hasRead=\"true\"></app-premission>\n      </td>\n    </tr>\n  </tbody>\n</nz-table>\n<!-- 编辑框 -->\n<nz-modal [(nzVisible)]=\"isVisible\" nzWidth=\"750\" nzTitle=\"{{modelTitle}}\" nzOkText=\"保存\" (nzOnCancel)=\"handleCancel()\"\n  [nzFooter]=\"modalFooter\" [nzOkLoading]=\"isOkLoading\">\n  <form nz-form [formGroup]=\"validateForm\">\n    <nz-form-item>\n      <nz-form-label [nzSpan]=\"4\" nzRequired>用户名称</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <input nz-input formControlName=\"sysUserName\" placeholder=\"请输入\" type=\"text\">\n        <nz-form-explain *ngIf=\"validateForm.get('sysUserName').dirty\">\n          <ng-container *ngIf=\"validateForm.get('sysUserName').hasError('required')\">\n            用户名称不能为空！\n          </ng-container>\n        </nz-form-explain>\n      </nz-form-control>\n      <nz-form-label [nzSpan]=\"4\" nzRequired>角色</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <!-- <nz-cascader [(ngModel)]=\"values\" nzPlaceHolder=\"请选择\" [nzLoadData]=\"loadData\" (nzSelect)=onChanges($event)\n          [nzChangeOnSelect]=\"true\" [nzAllowClear]=\"false\" formControlName=\"roleIds\">\n          \n        </nz-cascader> -->\n        <nz-tree-select  [nzNodes]=\"nodes\" nzShowSearch nzCheckable nzPlaceHolder=\"请选择\"\n          [(ngModel)]=\"selectRole\" (ngModelChange)=\"onChange($event)\" formControlName=\"roleIds\">\n        </nz-tree-select>\n        <ng-template #omittedPlaceHolder let-omittedValues> and {{ omittedValues.length }} more... </ng-template>\n        <nz-form-explain *ngIf=\"validateForm.get('roleIds').dirty\">\n          <ng-container *ngIf=\"validateForm.get('roleIds').hasError('required')\">\n            角色不能为空\n          </ng-container>\n        </nz-form-explain>\n      </nz-form-control>\n    </nz-form-item>\n    <nz-form-item>\n      <nz-form-label [nzSpan]=\"4\" nzRequired>手机号</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <input nz-input formControlName=\"mobile\" minlength=\"11\" maxlength=\"11\" placeholder=\"请输入\" type=\"text\" validateMobile>\n        <nz-form-explain *ngIf=\"validateForm.get('mobile').dirty\">\n          <ng-container *ngIf=\"validateForm.controls.mobile.errors?.validateMobile\">\n            手机号码格式不正确\n          </ng-container>\n          <ng-container *ngIf=\"validateForm.controls.mobile.errors?.required\">\n            手机号码不能为空\n          </ng-container>\n        </nz-form-explain>\n      </nz-form-control>\n      <nz-form-label [nzSpan]=\"4\">电话</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <input nz-input formControlName=\"telephone\" placeholder=\"请输入\" type=\"text\" />\n      </nz-form-control>\n    </nz-form-item>\n    <nz-form-item>\n      <nz-form-label [nzSpan]=\"4\">邮箱</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <input nz-input formControlName=\"email\" placeholder=\"请输入\" type=\"text\" />\n      </nz-form-control>\n      <nz-form-label [nzSpan]=\"4\">职务</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <input nz-input formControlName=\"position\" placeholder=\"请输入\" type=\"text\" />\n      </nz-form-control>\n    </nz-form-item>\n    <nz-form-item *ngIf=\"!userId\">\n      <nz-form-label [nzSpan]=\"4\" nzRequired>密码</nz-form-label>\n      <nz-form-control [nzSpan]=\"8\">\n        <nz-input-group [nzSuffix]=\"suffix4\">\n          <input [type]=\"passwordVisible?'text':'password'\" formControlName=\"password\" nz-input placeholder=\"请输入\"\n            autocomplete=\"off\">\n        </nz-input-group>\n        <ng-template #suffix4>\n          <i nz-icon [type]=\"passwordVisible? 'eye-invisible':'eye'\" (click)=\"passwordVisible = !passwordVisible\"></i>\n        </ng-template>\n        <nz-form-explain *ngIf=\"validateForm.get('password').dirty\">\n          <ng-container *ngIf=\"validateForm.get('password').hasError('required')\">\n            密码不能为空！\n          </ng-container>\n          <ng-container *ngIf=\"validateForm.get('password').errors\">\n            密码长度至少6位字符！\n          </ng-container>\n        </nz-form-explain>\n      </nz-form-control>\n    </nz-form-item>\n    <ng-template #modalFooter>\n      <button nz-button nzType=\"default\" (click)=\"changePassword()\">修改密码</button>\n      <button nz-popconfirm nzTitle=\"您确定重置密码吗?\" (nzOnConfirm)=\"resetPassword()\" nzPlacement=\"top\" nz-button>\n        重置密码\n      </button>\n      <button nz-button nzType=\"primary\" [disabled]=\"!validateForm.valid\"\n        (click)=\"submitForm(validateForm.value)\">保存</button>\n    </ng-template>\n  </form>\n</nz-modal>\n  <!-- 修改密码弹框 -->\n  <nz-modal [(nzVisible)]=\"isVisiblePassword\" nzWidth=\"450\" nzTitle=\"修改密码\" nzOkText=\"保存\"\n    (nzOnCancel)=\"handleCancelPassword()\" [nzFooter]=\"modalFooter2\">\n    <form nz-form [formGroup]=\"validateFormPassword\">\n      <nz-form-item>\n        <nz-form-label [nzSpan]=\"6\" nzRequired>旧密码</nz-form-label>\n        <nz-form-control [nzSpan]=\"18\">\n          <nz-input-group [nzSuffix]=\"suffix1\">\n            <input [type]=\"oldPasswordVisible?'text':'password'\" formControlName=\"oldPassword\" nz-input placeholder=\"请输入\">\n          </nz-input-group>\n          <ng-template #suffix1>\n            <i nz-icon [type]=\"oldPasswordVisible? 'eye-invisible':'eye'\"\n              (click)=\"oldPasswordVisible = !oldPasswordVisible\"></i>\n          </ng-template>\n          <nz-form-explain *ngIf=\"validateFormPassword.get('oldPassword').dirty\">\n            <ng-container *ngIf=\"validateFormPassword.get('oldPassword').hasError('required')\">\n              密码不能为空！\n            </ng-container>\n            <ng-container *ngIf=\"validateFormPassword.get('oldPassword').errors\">\n              密码长度至少6位字符！\n            </ng-container>\n          </nz-form-explain>\n        </nz-form-control>\n      </nz-form-item>\n      <nz-form-item>\n        <nz-form-label [nzSpan]=\"6\" nzRequired>新密码</nz-form-label>\n        <nz-form-control [nzSpan]=\"18\">\n          <nz-input-group [nzSuffix]=\"suffix2\">\n            <input [type]=\"newPasswordVisible?'text':'password'\" formControlName=\"newPassword\" nz-input placeholder=\"请输入\">\n          </nz-input-group>\n          <ng-template #suffix2>\n            <i nz-icon [type]=\"newPasswordVisible? 'eye-invisible':'eye'\"\n              (click)=\"newPasswordVisible = !newPasswordVisible\"></i>\n          </ng-template>\n          <nz-form-explain *ngIf=\"validateFormPassword.get('newPassword').dirty\">\n            <ng-container *ngIf=\"validateFormPassword.get('newPassword').hasError('required')\">\n              密码不能为空！\n            </ng-container>\n            <ng-container *ngIf=\"validateFormPassword.get('newPassword')?.hasError('length')\">\n              密码至少6位字符！\n            </ng-container>\n            <ng-container *ngIf=\"validateFormPassword.get('newPassword')?.hasError('equal')\">\n              与旧密码不能相同！\n            </ng-container>\n          </nz-form-explain>\n        </nz-form-control>\n      </nz-form-item>\n      <nz-form-item>\n        <nz-form-label [nzSpan]=\"6\" nzRequired>确认密码</nz-form-label>\n        <nz-form-control [nzSpan]=\"18\">\n          <nz-input-group [nzSuffix]=\"suffix3\">\n            <input [type]=\"checkedNewPasswordVisible?'text':'password'\" formControlName=\"checkedNewPassword\" nz-input\n              placeholder=\"请输入\">\n          </nz-input-group>\n          <ng-template #suffix3>\n            <i nz-icon [type]=\"checkedNewPasswordVisible? 'eye-invisible':'eye'\"\n              (click)=\"checkedNewPasswordVisible = !checkedNewPasswordVisible\"></i>\n          </ng-template>\n          <nz-form-explain *ngIf=\"validateFormPassword.get('checkedNewPassword').dirty\">\n            <ng-container *ngIf=\"validateFormPassword.get('checkedNewPassword').hasError('required')\">\n              密码不能为空！\n            </ng-container>\n            <ng-container *ngIf=\"validateFormPassword.get('checkedNewPassword')?.hasError('length')\">\n              密码至少6位字符！\n            </ng-container>\n            <ng-container *ngIf=\"validateFormPassword.get('checkedNewPassword')?.hasError('confirm')\">\n              两次输入密码不一致！\n            </ng-container>\n          </nz-form-explain>\n        </nz-form-control>\n      </nz-form-item>\n      <ng-template #modalFooter2>\n        <button nz-button nzType=\"primary\" [disabled]=\"!validateFormPassword.valid\"\n          (click)=\"submitFormPassword(validateFormPassword.value)\">保存</button>\n        <button nz-button nzType=\"default\" (click)=\"handleCancelPassword()\">取消</button>\n      </ng-template>\n    </form>\n  </nz-modal>\n<nz-drawer [nzClosable]=\"false\" [nzWidth]=\"360\" [nzVisible]=\"visibleDetail\" nzPlacement=\"right\" nzTitle=\"详细信息\"\n  (nzOnClose)=\"closeDetail()\">\n  <nz-row class=\"detailItem\">\n    <div nz-col [nzSpan]=\"8\">用户名称:</div>\n    <div nz-col [nzSpan]=\"16\">{{openItem.sysUserName}}</div>\n  </nz-row>\n  <nz-row class=\"detailItem\">\n    <div nz-col [nzSpan]=\"8\">手机号:</div>\n    <div nz-col [nzSpan]=\"16\">{{openItem.mobile}}</div>\n  </nz-row>\n  <nz-row class=\"detailItem\">\n    <div nz-col [nzSpan]=\"8\">电话:</div>\n    <div nz-col [nzSpan]=\"16\">{{openItem.telephone}}</div>\n  </nz-row>\n  <nz-row class=\"detailItem\">\n    <div nz-col [nzSpan]=\"8\">邮箱:</div>\n    <div nz-col [nzSpan]=\"16\">{{openItem.email}}</div>\n  </nz-row>\n  <nz-row class=\"detailItem\">\n    <div nz-col [nzSpan]=\"8\">职务:</div>\n    <div nz-col [nzSpan]=\"16\">{{openItem.position}}</div>\n  </nz-row>\n  <nz-row class=\"detailItem\">\n    <div nz-col [nzSpan]=\"8\">角色:</div>\n    <div nz-col [nzSpan]=\"16\">\n      <nz-list [nzDataSource]=\"detailSelectRole\" nzSize=\"small\"\n        [nzRenderItem]=\"item\">\n        <ng-template #item let-item>\n          <nz-list-item [nzContent]=\"item\"></nz-list-item>\n        </ng-template>\n      </nz-list>\n    </div>\n  </nz-row>\n  <div class=\"footer\">\n    <button type=\"button\" (click)=\"closeDetail()\" class=\"ant-btn\"><span>关闭</span></button>\n  </div>\n</nz-drawer>\n</div>"

/***/ }),

/***/ "./src/app/pages/user/user.component.less":
/*!************************************************!*\
  !*** ./src/app/pages/user/user.component.less ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3BhZ2VzL3VzZXIvdXNlci5jb21wb25lbnQubGVzcyJ9 */"

/***/ }),

/***/ "./src/app/pages/user/user.component.ts":
/*!**********************************************!*\
  !*** ./src/app/pages/user/user.component.ts ***!
  \**********************************************/
/*! exports provided: UserComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserComponent", function() { return UserComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _servers_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../servers.service */ "./src/app/servers.service.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var _validators_mobile_validators__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../validators/mobile.validators */ "./src/app/validators/mobile.validators.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");








var parents = [];
var childs = {};
var UserComponent = /** @class */ (function () {
    //初始化构造函数
    function UserComponent(server, http, fb, msg) {
        var _this = this;
        this.server = server;
        this.http = http;
        this.fb = fb;
        this.msg = msg;
        this.api_list = '/api/UserManage/GetUserList'; // 页面数据列表api
        this.api_add = '/api/UserManage/CreateUser'; // 新增行api
        this.api_update = '/api/UserManage/EditUser'; // 更新行api
        this.api_delete = '/api/UserManage/DeleteUser?id='; // 删除行api
        this.api_update_password = '/api/UserManage/ChangePassword'; //修改密码
        this.api_reset_password = '/api/UserManage/ResetUserPassword'; //重置密码
        this.api_RolesWithAppTree = '/api/UserManage/GetRolesWithAppTree'; //获取角色树形结构
        //列表相关数据
        this.displayData = []; //存储列表数据
        this.isLoading = false; //用于加载效果
        this.Page = 1; //初始页码
        this.Rows = 10; //显示行数
        this.total = 1; //总条数
        this.Sord = null; //正反序
        this.OrderBy = null; //排序字段
        this.loading = true; //开启加载
        this.Sidx = '0';
        this.colData = null;
        this.selectRole = [];
        this.nodes = [];
        //modal 参数
        this.modelTitle = '新增'; //弹窗标题
        this.headers = new _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpHeaders"]({ 'Content-Type': 'application/json' }); //发送post请求头部
        this.isVisible = false; //控制窗口是否显示
        this.userId = ''; //行id
        //接收参数
        this.appList = []; //应用程序列表
        this.searchApp = null; //应用程序下拉组件
        this.openItem = {}; //接收详情数据
        this.visibleDetail = false; //控制显示详情
        this.roles = [];
        this.breadcrumb = '用户管理';
        this.values = null;
        this.isVisiblePassword = false; //修改密码弹框
        this.detailSelectRole = [];
        //新增用户密码输入验证
        this.addUserPassword = function (control) {
            if (_this.userId) {
                return {};
            }
            if (!control.value) {
                return { required: true };
            }
            else if (control.value.length < 6) {
                return { length: true };
            }
            else if (control.value !== _this.validateForm.controls.password.value) {
                return { confirm: true };
            }
            return {};
        };
        //验证新密码与确认密码是否不一样
        this.confirmValidator = function (control) {
            if (!control.value) {
                return { required: true };
            }
            else if (control.value.length < 6) {
                return { length: true };
            }
            else if (control.value !== _this.validateFormPassword.controls.newPassword.value) {
                return { confirm: true };
            }
            return {};
        };
        //验证新密码与旧密码是否不一样
        this.newValidator = function (control) {
            if (!control.value) {
                return { required: true };
            }
            else if (control.value.length < 6) {
                return { length: true };
            }
            else if (control.value == _this.validateFormPassword.controls.oldPassword.value) {
                return { equal: true };
            }
            return {};
        };
        this.validateForm = this.fb.group({
            sysUserName: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].required]],
            mobile: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].minLength(11), _angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].maxLength(11), _validators_mobile_validators__WEBPACK_IMPORTED_MODULE_6__["validateMobile"]]],
            email: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].email]],
            position: [null],
            telephone: [null],
            roleIds: [null],
            password: [null, [this.addUserPassword]],
        });
        //重置密码表单
        this.validateFormPassword = this.fb.group({
            oldPassword: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].minLength(6), _angular_forms__WEBPACK_IMPORTED_MODULE_7__["Validators"].maxLength(20)]],
            newPassword: [null, [this.newValidator]],
            checkedNewPassword: [null, [this.confirmValidator]],
        });
    }
    UserComponent.prototype.ngOnInit = function () {
        var _this = this;
        //获取应用程序列表
        this.server.getAppList().subscribe(function (data) {
            _this.appList = data;
            _this.searchApp = data[0];
            //获取页面列表
            _this.getDataList();
            //获取用户角色
            _this.server.getRoleList(_this.searchApp.id).subscribe(function (data) {
                _this.roles = data;
            });
            //设置角色下拉组件数据
            parents.length = 0;
            data.forEach(function (element) {
                var obj = {
                    value: element.id,
                    label: element.label,
                    id: element.id
                };
                parents.push(obj);
            });
        });
        //获取角色树
        var options = {
            api: this.api_RolesWithAppTree,
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            data.data.forEach(function (element) {
                element.value = '1-' + element.value;
                element.key = '1-' + element.key;
                _this.nodes.push(element);
            });
        });
    };
    //获取列表数据
    UserComponent.prototype.getDataList = function () {
        var _this = this;
        var options = {
            api: this.api_list,
            params: {
                Sidx: '0',
                Page: this.Page,
                Rows: this.Rows,
                AppId: this.searchApp.id
            }
        };
        this.server.getRxjsData(options).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.colData = data.pageResult.data;
            _this.displayData = _this.colData.slice();
        });
    };
    //应用程序下拉组件改变事件
    UserComponent.prototype.appChange = function (event) {
        this.getDataList();
    };
    //搜索事件
    UserComponent.prototype.searchData = function (keyword, reset) {
        var _this = this;
        if (reset === void 0) { reset = false; }
        this.isLoading = true;
        if (reset) {
            this.Page = 1;
        }
        this.loading = true;
        this.getList(keyword, this.Page, this.Rows, this.Sidx).subscribe(function (data) {
            _this.loading = false;
            _this.total = data.total;
            _this.colData = data.pageResult.data;
            _this.displayData = _this.colData.slice();
            _this.isLoading = false;
        });
    };
    UserComponent.prototype.getList = function (keyword, pageIndex, pageSize, Sidx) {
        if (pageIndex === void 0) { pageIndex = 1; }
        if (pageSize === void 0) { pageSize = 10; }
        var params = {};
        params.Name = keyword ? keyword : '';
        params.AppId = this.searchApp.id;
        if (this.Page) {
            params.Page = this.Page;
        }
        if (this.Rows) {
            params.Rows = this.Rows;
        }
        if (this.Sidx) {
            params.Sidx = this.Sidx;
        }
        if (this.Sord) {
            params.Sord = this.Sord;
        }
        var options = {
            api: this.api_list,
            params: params
        };
        return this.server.getRxjsData(options);
    };
    //打开弹框
    UserComponent.prototype.showModal = function () {
        this.isVisible = true;
        this.userId = '';
        //表单初始化
        this.resetForm();
    };
    //弹框确定事件
    UserComponent.prototype.handleOk = function () {
        this.isVisible = false;
    };
    //弹框取消事件
    UserComponent.prototype.handleCancel = function () {
        this.isVisible = false;
    };
    UserComponent.prototype.resetForm = function () {
        this.validateForm.reset();
        for (var key in this.validateForm.controls) {
            this.validateForm.controls[key].markAsPristine();
            this.validateForm.controls[key].updateValueAndValidity();
        }
    };
    //编辑行
    UserComponent.prototype.editRow = function (item) {
        var _this = this;
        this.userId = item.userId;
        //初始化表单值
        var initformData = new rxjs__WEBPACK_IMPORTED_MODULE_4__["Observable"](function (observer) {
            _this.validateForm.setValue({ sysUserName: item.sysUserName, email: item.email, mobile: item.mobile, position: item.position, telephone: item.telephone, roleIds: item.roleIds, password: null });
            observer.next();
        });
        initformData.subscribe(function () {
            _this.isVisible = true;
            _this.modelTitle = '编辑';
        });
    };
    //保存行
    UserComponent.prototype.submitForm = function (value) {
        var _this = this;
        var paramsObj = value;
        paramsObj.roleIds = [];
        if (this.userId) {
            paramsObj.userId = this.userId;
        }
        paramsObj.appId = this.searchApp.id;
        //提取子role id
        this.selectRole.forEach(function (element, index) {
            _this.nodes.forEach(function (ele) {
                if (element == ele.key) {
                    _this.selectRole.splice(index, 1);
                    for (var _i = 0, _a = ele.children; _i < _a.length; _i++) {
                        var entry = _a[_i];
                        _this.selectRole.push(entry.key);
                    }
                }
            });
        });
        paramsObj.roleIds = this.selectRole;
        var options = {
            api: this.userId ? this.api_update : this.api_add,
            params: paramsObj,
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.isVisible = false;
            _this.searchData();
        });
    };
    //删除行
    UserComponent.prototype.deleteRow = function (item) {
        var _this = this;
        var options = {
            api: this.api_delete + item.userId,
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.searchData();
        });
    };
    //查看行详情
    UserComponent.prototype.openDetail = function (item) {
        var _this = this;
        this.detailSelectRole = [];
        this.openItem = item;
        //处理角色
        item.roleIds.forEach(function (element) {
            _this.nodes.forEach(function (element2) {
                element2.children.forEach(function (element3) {
                    if (element == element3.key) {
                        _this.detailSelectRole.push(element2.title + '-' + element3.title);
                    }
                });
            });
        });
        this.visibleDetail = true;
    };
    //关闭查看详情
    UserComponent.prototype.closeDetail = function () {
        this.visibleDetail = false;
    };
    //获取子列表
    UserComponent.prototype.getChild = function (parentId) {
        this.server.getRoleList(parentId).subscribe(function (data) {
            var arr = [];
            data.forEach(function (element) {
                var obj = {
                    value: element.id,
                    label: element.label,
                    isLeaf: true
                };
                arr.push(obj);
            });
            if (arr.length == 0) {
                arr.push({
                    value: null,
                    label: '暂无数据',
                    isLeaf: true,
                    disabled: true,
                });
            }
            childs[parentId] = arr;
        });
    };
    //数据处理
    UserComponent.prototype.loadData = function (node, index) {
        return new Promise(function (resolve) {
            setTimeout(function () {
                if (index < 0) { // if index less than 0 it is root node
                    node.children = parents;
                }
                else if (index === 0) {
                    node.children = childs[node.value];
                }
                resolve();
            }, 500);
        });
    };
    //点击选项
    UserComponent.prototype.onChanges = function (values) {
        if (values.index == 0) {
            this.getChild(values.option.id);
        }
    };
    //打开编辑密码窗口
    UserComponent.prototype.changePassword = function () {
        this.isVisiblePassword = true;
    };
    //保存修改密码
    UserComponent.prototype.submitFormPassword = function (value) {
        var _this = this;
        var options = {
            api: this.api_update_password,
            params: value
        };
        options.params.userId = this.userId;
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
            _this.isVisiblePassword = false;
        });
    };
    //重置密码
    UserComponent.prototype.resetPassword = function () {
        var options = {
            api: this.api_reset_password,
            params: {
                id: this.userId
            }
        };
        var postData = this.server.postRxjsData(options);
        postData.subscribe(function () {
        });
    };
    //下拉树选中事件
    UserComponent.prototype.onChange = function ($event) {
        console.log($event);
    };
    UserComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-user',
            template: __webpack_require__(/*! ./user.component.html */ "./src/app/pages/user/user.component.html"),
            styles: [__webpack_require__(/*! ./user.component.less */ "./src/app/pages/user/user.component.less")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_servers_service__WEBPACK_IMPORTED_MODULE_2__["ServersService"], _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClient"], _angular_forms__WEBPACK_IMPORTED_MODULE_7__["FormBuilder"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NzMessageService"]])
    ], UserComponent);
    return UserComponent;
}());



/***/ }),

/***/ "./src/app/servers.service.ts":
/*!************************************!*\
  !*** ./src/app/servers.service.ts ***!
  \************************************/
/*! exports provided: ServersService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ServersService", function() { return ServersService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../environments/environment */ "./src/environments/environment.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-zorro-antd */ "./node_modules/ng-zorro-antd/fesm5/ng-zorro-antd.js");
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");







var ServersService = /** @class */ (function () {
    function ServersService(http, msg, oauthService) {
        this.http = http;
        this.msg = msg;
        this.oauthService = oauthService;
        this.configUrl = _environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].API; //获取环境文件中api地址
        this.postHeaders = new _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpHeaders"]({ 'Content-Type': 'application/json', Authorization: "Bearer " + this.oauthService.getAccessToken() });
        this.getHeaders = new _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpHeaders"]({ Authorization: "Bearer " + this.oauthService.getAccessToken() });
        this.api_list_app = '/api/AppManage/GetAppList'; // 应用程序数据列表api
        this.api_roles = '/api/RoleManage/GetRoleList'; //角色列表
        this.api_premission = '/api/Common/GetButtonsPermission'; // 权限api
        this.premissions = {}; //权限
        if (localStorage.getItem('menuId')) {
            this.setPremission(localStorage.getItem('menuId'));
        }
    }
    ServersService.prototype.getSystemName = function () {
        return "通用权限管理系统";
    };
    //通过rxjs获取数据
    ServersService.prototype.getRxjsData = function (options) {
        var _this = this;
        var headers = new Headers({});
        return new rxjs__WEBPACK_IMPORTED_MODULE_2__["Observable"](function (observer) {
            _this.http.get(_this.configUrl + options.api, { params: options.params, headers: _this.getHeaders }).subscribe(function (response) {
                if (response.status !== 0) {
                    observer.next(response);
                }
                else {
                    window.location.reload();
                    return false;
                }
            });
        });
    };
    ServersService.prototype.postRxjsData = function (options) {
        var _this = this;
        return new rxjs__WEBPACK_IMPORTED_MODULE_2__["Observable"](function (observer) {
            _this.http.post(_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].API + options.api, JSON.stringify(options.params), { headers: _this.postHeaders }).subscribe(function (response) {
                _this.msg.info(response.message);
                if (response.status) {
                    observer.next();
                }
                else {
                    return false;
                }
            }, function (error) {
                if (error.status == 400 || error.status == 404) {
                    _this.msg.info(error.error);
                }
                else {
                    _this.msg.info('操作成功！');
                    observer.next();
                }
            });
        });
    };
    //获取应用程序列表
    ServersService.prototype.getAppList = function () {
        var _this = this;
        //获取应用程序列表
        var options = {
            api: this.api_list_app,
            params: {
                Sidx: '0',
            }
        };
        return new rxjs__WEBPACK_IMPORTED_MODULE_2__["Observable"](function (observer) {
            _this.getRxjsData(options).subscribe(function (data) {
                //数据处理成可识别的下拉数据
                var array = [];
                data.pageResult.data.forEach(function (element) {
                    var obj = {
                        value: element.appId,
                        label: element.appName,
                        id: element.appId
                    };
                    array.push(obj);
                });
                observer.next(array);
            });
        });
    };
    //获取用户角色
    ServersService.prototype.getRoleList = function (appid) {
        var _this = this;
        //获取应用程序列表
        var options = {
            api: this.api_roles,
            params: {
                Sidx: '0',
                AppId: appid
            }
        };
        return new rxjs__WEBPACK_IMPORTED_MODULE_2__["Observable"](function (observer) {
            _this.getRxjsData(options).subscribe(function (data) {
                //数据处理成可识别的下拉数据
                var array = [];
                data.pageResult.data.forEach(function (element) {
                    var obj = {
                        value: element.roleId,
                        label: element.roleName,
                        id: element.roleId
                    };
                    array.push(obj);
                });
                observer.next(array);
            });
        });
    };
    //通过promise获取数据
    ServersService.prototype.getDataPromise = function (options) {
        var _this = this;
        return new Promise(function (resolve) {
            _this.http.get(_this.configUrl + options.api).subscribe(function (response) {
                resolve(response);
            });
        });
    };
    //设置用户权限
    //menuId:菜单id
    ServersService.prototype.setPremission = function (menuId) {
        var _this = this;
        localStorage.setItem('menuId', menuId);
        var option = {
            api: this.api_premission,
            params: {
                menuId: menuId || 0,
            }
        };
        var rxjsData = this.getRxjsData(option);
        rxjsData.subscribe(function (data) {
            if (data.data.length) {
                _this.premissions = {};
                data.data.forEach(function (item) {
                    if (item.permissionName == '查看页面') {
                        _this.premissions.hasReadPremission = true;
                    }
                    if (item.permissionName == '新增') {
                        _this.premissions.hasAddPremission = true;
                    }
                    if (item.permissionName == '编辑') {
                        _this.premissions.hasUpdatePremission = true;
                    }
                    if (item.permissionName == '删除') {
                        _this.premissions.hasDeletePremission = true;
                    }
                    if (item.permissionName == '导入') {
                        _this.premissions.hasInportPremission = true;
                    }
                    if (item.permissionName == '导出') {
                        _this.premissions.hasExportPremission = true;
                    }
                    if (item.permissionName == '新增数据类型') {
                        _this.premissions.hasAddDataTypePremission = true;
                    }
                    if (item.permissionName == '新增数据项目') {
                        _this.premissions.hasAddDataProjectPremission = true;
                    }
                    if (item.permissionName == '新增权限') {
                        _this.premissions.hasAddPrePremission = true;
                    }
                    if (item.permissionName == '新增菜单') {
                        _this.premissions.hasAddMenuPremission = true;
                    }
                    if (item.permissionName == '保存') {
                        _this.premissions.hasSavePremission = true;
                    }
                });
            }
            return _this.premissions;
        });
    };
    ServersService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"], ng_zorro_antd__WEBPACK_IMPORTED_MODULE_5__["NzMessageService"], angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_6__["OAuthService"]])
    ], ServersService);
    return ServersService;
}());



/***/ }),

/***/ "./src/app/shared/auth/auth.guard.ts":
/*!*******************************************!*\
  !*** ./src/app/shared/auth/auth.guard.ts ***!
  \*******************************************/
/*! exports provided: AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return AuthGuard; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! angular-oauth2-oidc */ "./node_modules/angular-oauth2-oidc/esm5/angular-oauth2-oidc.js");




var AuthGuard = /** @class */ (function () {
    function AuthGuard(oauthService, router) {
        this.oauthService = oauthService;
        this.router = router;
    }
    AuthGuard.prototype.canActivate = function () {
        var _this = this;
        return this.oauthService
            .loadDiscoveryDocumentAndTryLogin()
            .then(function (res) {
            return _this.oauthService.hasValidIdToken() && _this.oauthService.hasValidAccessToken();
        });
    };
    AuthGuard = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [angular_oauth2_oidc__WEBPACK_IMPORTED_MODULE_3__["OAuthService"], _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"]])
    ], AuthGuard);
    return AuthGuard;
}());



/***/ }),

/***/ "./src/app/validators/mobile.validators.ts":
/*!*************************************************!*\
  !*** ./src/app/validators/mobile.validators.ts ***!
  \*************************************************/
/*! exports provided: validateMobile, MobileValidator */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "validateMobile", function() { return validateMobile; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MobileValidator", function() { return MobileValidator; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");



function validateMobile(c) {
    var MOBILE_REGEXP = /^1[0-9]{10,10}$/;
    return MOBILE_REGEXP.test(c.value) ? null : {
        validateMobile: { valid: false }
    };
}
var MobileValidator = /** @class */ (function () {
    function MobileValidator() {
    }
    MobileValidator = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Directive"])({
            selector: '[validateMobile][ngModel]',
            providers: [
                { provide: _angular_forms__WEBPACK_IMPORTED_MODULE_1__["NG_VALIDATORS"], useValue: validateMobile, multi: true }
            ]
        })
    ], MobileValidator);
    return MobileValidator;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false,
    evnName: 'dev',
    API: 'http://10.9.53.103:5101',
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.error(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! /Users/liteng/App/permissions-system-frontEnd/src/main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map