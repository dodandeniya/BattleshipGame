import * as actions from "../../constants";
import * as api from "../../../apis/playerApi";
import { setErrors } from "../errors/errorsActions";

export const createPlayer = (name: string) => async (
  dispatch: any,
  getState: any
) => {
  try {
    dispatch({ type: actions.CREATE_PLAYER_REQUEST });
    const data = await api.createPlayer(name);
    dispatch({
      type: actions.CREATE_PLAYER_SUCCESS,
      payload: data,
    });
  } catch (error) {
    dispatch({
      type: actions.CREATE_PLAYER_FAIL,
      payload:
        error.response && error.response.data.message
          ? error.response.data.message
          : error.message,
    });
    dispatch(setErrors(error));
  }
};
