import React, { Component } from 'react';
import { Routes, Route } from "react-router-dom";
import { Layout } from './components/templates/Layout';
import { Home } from './components/organisms/Home';
import { FetchData } from './components/organisms/FetchData';
import { Counter } from './components/organisms/Counter';

import './styles/custom.css';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Routes>
          <Route exact path='/' element={<Home />} />
          <Route path='/counter' element={<Counter />} />
          <Route path='/fetch-data' element={<FetchData />} />
        </Routes>
      </Layout>
    );
  }
}
