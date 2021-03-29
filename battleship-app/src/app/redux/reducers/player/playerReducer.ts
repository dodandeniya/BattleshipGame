import { PlayerTypes } from "../../actions/actionTypes";
import * as actions from "../../constants";
import { initialPlayer } from "../../initialStates";

export const playerReducer = (state = initialPlayer, action: PlayerTypes) => {
  switch (action.type) {
    case actions.CREATE_PLAYER_REQUEST:
      return state;

    case actions.CREATE_PLAYER_SUCCESS:
      return { userId: action.payload };

    case actions.CREATE_PLAYER_FAIL:
      return { error: action.payload as string };

    default:
      return state;
  }
};
