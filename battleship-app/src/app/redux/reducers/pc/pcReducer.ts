import { PCPlayerTypes } from "../../actions/actionTypes";
import * as actions from "../../constants";
import { initialShootStatus } from "../../initialStates";

export const getPCPlayerShootStatusReducer = (
  state = initialShootStatus,
  action: PCPlayerTypes
) => {
  switch (action.type) {
    case actions.GET_PC_SHOOT_STATUS_REQUEST:
      return state;

    case actions.GET_PC_SHOOT_STATUS_SUCCESS:
      return action.payload;

    case actions.GET_PC_SHOOT_STATUS_FAIL:
      return { error: action.payload as string };

    default:
      return state;
  }
};
