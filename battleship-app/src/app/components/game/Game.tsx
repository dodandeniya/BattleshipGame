import React from "react";
import Board from "../board/Board";
import { useHistory } from "react-router-dom";
import { useSelector } from "react-redux";
import { RootState } from "../../redux/reducers";

export interface IGameProps {}

export default function Game(props: IGameProps) {
  const history = useHistory();
  const player = useSelector((state: RootState) => state.player) as any;

  if (!player.userId) history.push("/");

  return (
    <div>
      Game! <Board />
    </div>
  );
}
