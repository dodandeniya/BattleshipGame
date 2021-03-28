import { Container, Grid } from "@material-ui/core";
import React from "react";
import { Header } from "./core/header/Header";
import Router from "./core/router/Router";
import { useStyles } from "./styles/style";

export interface IAppProps {}

export default function App(props: IAppProps) {
  const classes = useStyles();

  return (
    <div>
      <Header />
      <Container maxWidth="lg" className={classes.container}>
        <Grid container spacing={3}>
          <Router />
        </Grid>
      </Container>
    </div>
  );
}
