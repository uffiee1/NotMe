import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Login } from './components/Login';
import { Mapper } from './components/map/Mapper';
import { TodoUNauth } from './components/todo/todo-unauthorized/TodoUNauth';
import { Todo } from './components/todo/todo/Todo';

import AuthorizeRoute from './components/Account/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/Account/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/Account/ApiAuthorizationConstants';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Layout>
            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
            <Route exact path='/' component={Home} />
            <Route path='/counter' component={Counter} />
            <AuthorizeRoute path='/fetch-data' component={FetchData} />
            <Route path='/login' component={Login} />
            <Route path='/mapper' component={Mapper} />
            <Route path='/todo' component={Todo} />
            <Route path='/todo-unauthorized' component={TodoUNauth} />
      </Layout>
    );
  }
}
