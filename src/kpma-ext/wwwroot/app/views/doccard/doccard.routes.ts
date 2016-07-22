﻿import {RouterConfig} from '@angular/router';

import {UserService} from '../../services/user.service';

import {DocCardList} from './doccard.list.view';
import {DocCardEdit} from './doccard.edit.view';

export const DocCardRoutes: RouterConfig = [
	{ path: 'doccard/list', component: DocCardList, canActivate: [UserService] },
	{ path: 'doccard/edit/:id', component: DocCardEdit, canActivate: [UserService] },
	{ path: 'doccard/edit/:id/:mode', component: DocCardEdit, canActivate: [UserService] },

];