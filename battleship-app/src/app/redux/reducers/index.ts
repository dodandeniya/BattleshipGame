import { combineReducers } from "redux";
import { errorsReducer } from "./errors/errorsReducer";
import { playerReducer, playersListReducer } from "./player/playerReducer";

const rootReducer = combineReducers({
  player: playerReducer,
  playerList: playersListReducer,
  errors: errorsReducer,
});

export default rootReducer;
export type RootState = ReturnType<typeof rootReducer>;
