import React from "react";
import IPosition from "../../shared/interfaces/IPosition";
import Square from "../square/Square";
import "./Board.css";

export interface IBoardProps {
  enabled: boolean;
  handleClick: (position: IPosition) => void;
}

export default function Board({ enabled, handleClick }: IBoardProps) {
  const gridArray = () => {
    let table = [];

    for (let i = 1; i <= 10; i++) {
      let children = [];

      for (let j = 1; j <= 10; j++) {
        children.push(
          <Square
            enabled={enabled}
            onClick={handleClick}
            position={{ xPosition: j, yPosition: i }}
          />
        );
      }

      table.push(
        <div key={i} className="board-row">
          {children}
        </div>
      );
    }

    return table;
  };

  return <div>{gridArray()}</div>;
}
