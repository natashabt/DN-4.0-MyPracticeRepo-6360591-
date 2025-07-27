import React from 'react';
import CurrencyConvertor from './CurrencyConvertor';

class App extends React.Component {
  constructor() {
    super();
    this.state = {
      count: 0
    };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayHello = () => {
    alert("Hello! This is a static message.");
  };

  handleIncrement = () => {
    this.increment();
    this.sayHello();
  };

  sayWelcome = (msg) => {
    alert(msg);
  };

  handleSyntheticEvent = (event) => {
    alert("I was clicked");
    console.log("Synthetic event: ", event);
  };

  render() {
    return (
      <div style={{ padding: '20px' }}>
        <h1>React Event Handling</h1>
        <h2>Counter: {this.state.count}</h2>

        <button onClick={this.handleIncrement}>Increment</button>
        <button onClick={this.decrement}>Decrement</button>
        <br /><br />

        <button onClick={() => this.sayWelcome("Welcome!")}>Say Welcome</button>
        <br /><br />

        <button onClick={this.handleSyntheticEvent}>Synthetic Event</button>
        <br /><br />

        <CurrencyConvertor />
      </div>
    );
  }
}

export default App;



