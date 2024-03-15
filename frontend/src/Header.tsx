import React from 'react';
import logo from './bowlinglogo.png';

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} height="150px" className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 style={{ color: 'gold' }}>{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
