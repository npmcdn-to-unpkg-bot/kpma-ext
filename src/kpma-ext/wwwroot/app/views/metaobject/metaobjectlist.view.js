"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
//import {RouteData, Router} from '@angular/router-deprecated';
var metaobject_service_1 = require('../../services/metaobject.service');
var MetaObjectList = (function () {
    function MetaObjectList(moSrv) {
        this.moSrv = moSrv;
    }
    MetaObjectList.prototype.ngOnInit = function () {
        var _this = this;
        this.moSrv.getList(this.parentId).subscribe(function (res) { return _this.moList = res; }, function (err) { return console.log(err); });
    };
    MetaObjectList = __decorate([
        core_1.Component({}), 
        __metadata('design:paramtypes', [metaobject_service_1.MetaObjectService])
    ], MetaObjectList);
    return MetaObjectList;
}());
exports.MetaObjectList = MetaObjectList;
//# sourceMappingURL=metaobjectlist.view.js.map