import {
  Button,
  FormControl,
  FormLabel,
  Grid,
  TextField,
} from "@material-ui/core";
import React, { useState, useEffect } from "react";
import { useHistory } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../redux/reducers";
import { createPlayer } from "../../redux/actions/player/playerActions";

export default function Home() {
  const dispatch = useDispatch();
  const player = useSelector((state: RootState) => state.player) as any;
  const history = useHistory();

  const [disable, setDisable] = useState(true);
  const [value, setValue] = React.useState("");

  useEffect(() => {
    if (player.userId != null) {
      history.push("/game");
    }
  }, [history, player]);

  const onTextChangeHandler = (event: any) => {
    setValue(event.target.value);

    if (event.target.value.length > 0) setDisable(false);
    else setDisable(true);
  };

  const onSaveButtonClickHandler = () => {
    console.log("clicked");
    dispatch(createPlayer(value));
  };

  return (
    <>
      <Grid item xs={false} sm={false} md={3} />
      <Grid item xs={12} sm={12} md={6}>
        <FormControl fullWidth margin="normal">
          <FormLabel component="legend">Name*</FormLabel>
          <TextField
            id="name"
            placeholder="Player's Name"
            value={value}
            onChange={onTextChangeHandler}
          />
        </FormControl>
        <FormControl margin="normal">
          <Button
            color="primary"
            variant="contained"
            type="submit"
            disabled={disable}
            onClick={onSaveButtonClickHandler}
          >
            Start
          </Button>
        </FormControl>
      </Grid>
      <Grid item xs={false} sm={false} md={3} />
    </>
  );
}
