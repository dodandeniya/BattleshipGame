import React, { useEffect } from "react";
import Board from "../board/Board";
import { useHistory } from "react-router-dom";
import { useSelector, useDispatch } from "react-redux";
import { RootState } from "../../redux/reducers";
import {
  getPlayerShootStatus,
  getPlayersList,
  getShipList,
} from "../../redux/actions/player/playerActions";
import { getPCShootStatus } from "../../redux/actions/pc/pcActions";
import { Grid, Typography } from "@material-ui/core";
import IPosition from "../../shared/interfaces/IPosition";

export interface IGameProps {}

export default function Game(props: IGameProps) {
  const dispatch = useDispatch();
  const history = useHistory();
  const player = useSelector((state: RootState) => state.player) as any;
  const playerList = useSelector((state: RootState) => state.playerList);

  if (!player.userId) history.push("/");

  useEffect(() => {
    dispatch(getPlayersList());
    dispatch(getShipList());

    dispatch(getPCShootStatus());
  }, [dispatch]);

  const handleClick = (position: IPosition) => {
    dispatch(getPlayerShootStatus(position));
  };

  return (
    <>
      <Grid item xs={12} sm={12} md={6}>
        {playerList.length > 0 && (
          <Typography variant="h6">Player : {playerList[0].name}</Typography>
        )}

        <Board enabled={false} handleClick={handleClick} />
      </Grid>
      <Grid item xs={12} sm={12} md={6}>
        {playerList.length > 0 && (
          <Typography variant="h6">Player : {playerList[1].name}</Typography>
        )}
        <Board enabled handleClick={handleClick} />
      </Grid>
    </>
  );
}
