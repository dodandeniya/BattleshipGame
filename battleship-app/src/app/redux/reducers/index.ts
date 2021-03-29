import { combineReducers } from "redux";
import { errorsReducer } from "./errors/errorsReducer";
import { playerReducer } from "./player/playerReducer";

const rootReducer = combineReducers({
  player: playerReducer,
  errors: errorsReducer,
});

export default rootReducer;
export type RootState = ReturnType<typeof rootReducer>;
