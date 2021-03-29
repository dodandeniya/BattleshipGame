import axios from "axios";
import { getConfig, apiUrl } from "../shared/utils/apiConfigs";
import { handleResponse, handleError } from "../shared/utils/apiUtils";

export const getScore = async () => {
  return await axios
    .get(`${apiUrl}/Game/Score`, getConfig())
    .then(handleResponse)
    .catch(handleError);
};

export const getWinner = async () => {
  return await axios
    .get(`${apiUrl}/Game/GetWinner`, getConfig())
    .then(handleResponse)
    .catch(handleError);
};
