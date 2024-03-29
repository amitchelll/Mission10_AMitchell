import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './Header';
import BowlerList from './Bowlers/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="The Bowling League" />
      <BowlerList />
    </div>
  );
}

export default App;
