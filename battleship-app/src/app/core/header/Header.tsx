import { AppBar, Toolbar, Typography } from "@material-ui/core";
import React from "react";

export interface IHeader {}

export function Header(props: IHeader) {
  return (
    <AppBar position="static">
      <Toolbar>
        <Typography variant="h6">Battleship Game</Typography>
      </Toolbar>
    </AppBar>
  );
}
