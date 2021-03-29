import React, { useEffect } from "react";
import Board from "../board/Board";
import { useHistory } from "react-router-dom";
import { useSelector, useDispatch } from "react-redux";
import { RootState } from "../../redux/reducers";
import { getPlayersList } from "../../redux/actions/player/playerActions";
import IPlayer from "../../shared/interfaces/IPlayer";

export interface IGameProps {}

export default function Game(props: IGameProps) {
  const dispatch = useDispatch();
  const history = useHistory();
  const player = useSelector((state: RootState) => state.player) as any;
  const playerList = useSelector((state: RootState) => state.playerList);

  if (!player.userId) history.push("/");

  useEffect(() => {
    dispatch(getPlayersList());
  }, [dispatch]);

  return (
    <div>
      Game! <Board />
      {playerList.length > 0 &&
        playerList.map((item: IPlayer, index: number) => (
          <p key={index}>{item.name}</p>
        ))}
    </div>
  );
}
