import { combineReducers } from "redux";
import { errorsReducer } from "./errors/errorsReducer";
import { getPCPlayerShootStatusReducer } from "./pc/pcReducer";
import {
  getPlayerShootStatusReducer,
  getShipListReducer,
  playerReducer,
  playersListReducer,
} from "./player/playerReducer";

const rootReducer = combineReducers({
  player: playerReducer,
  playerList: playersListReducer,
  myShipList: getShipListReducer,
  myShootStatus: getPlayerShootStatusReducer,
  pcShootStatus: getPCPlayerShootStatusReducer,
  errors: errorsReducer,
});

export default rootReducer;
export type RootState = ReturnType<typeof rootReducer>;
