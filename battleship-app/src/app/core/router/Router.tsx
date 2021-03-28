import React from "react";
import { Route, Switch } from "react-router-dom";
import Game from "../../components/game/Game";
import Home from "../../components/home/Home";

const Router = () => {
  return (
    <Switch>
      <Route path="/game" component={Game} />
      <Route path="/" component={Home} />
    </Switch>
  );
};

export default Router;
