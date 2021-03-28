import * as React from "react";
import Board from "../board/Board";

export interface IGameProps {}

export default function Game(props: IGameProps) {
  return (
    <div>
      Game! <Board />
    </div>
  );
}
