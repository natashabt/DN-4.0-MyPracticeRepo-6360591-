import React from 'react';
import Home from './Components/Home';
import About from './Components/About';
import Contact from './Components/Contact';
import './App.css'; // make sure this is imported

function App() {
  return (
    <div className="App">
      <div className="center-content">
        <Home />
        <About />
        <Contact />
      </div>
    </div>
  );
}

export default App;

