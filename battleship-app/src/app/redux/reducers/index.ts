import { combineReducers } from "redux";
import { errorsReducer } from "./errors/errorsReducer";
import {
  getShipListReducer,
  playerReducer,
  playersListReducer,
} from "./player/playerReducer";

const rootReducer = combineReducers({
  player: playerReducer,
  playerList: playersListReducer,
  myShipList: getShipListReducer,
  errors: errorsReducer,
});

export default rootReducer;
export type RootState = ReturnType<typeof rootReducer>;
