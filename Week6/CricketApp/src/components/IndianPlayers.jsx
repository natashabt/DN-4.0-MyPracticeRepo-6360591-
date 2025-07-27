import React from "react";

const IndianPlayers = () => {
  const oddPlayers = ["Sachin1", "Virat3", "Yuvraj5"];
  const evenPlayers = ["Dhoni2", "Rohit4", "Raina6"];

  const [first, , third, , fifth] = ["Sachin1", "Dhoni2", "Virat3", "Rohit4", "Yuvraj5", "Raina6"];
  const [second, fourth, sixth] = evenPlayers;

  const T20 = ["First Player", "Second Player", "Third Player"];
  const Ranji = ["Fourth Player", "Fifth Player", "Sixth Player"];
  const merged = [...T20, ...Ranji];

  return (
    <div>
      <h2>Odd Players</h2>
      <ul>
        <li>First : {oddPlayers[0]}</li>
        <li>Third : {oddPlayers[1]}</li>
        <li>Fifth : {oddPlayers[2]}</li>
      </ul>

      <h2>Even Players</h2>
      <ul>
        <li>Second : {evenPlayers[0]}</li>
        <li>Fourth : {evenPlayers[1]}</li>
        <li>Sixth : {evenPlayers[2]}</li>
      </ul>

      <h2>List of Indian Players Merged:</h2>
      <ul>
        {merged.map((player, idx) => (
          <li key={idx}>Mr. {player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;

