import axios from "axios";
import {
  getConfig,
  apiUrl,
  getConfigWithParams,
} from "../shared/utils/apiConfigs";
import { handleResponse, handleError } from "../shared/utils/apiUtils";

export const createPlayer = async (name: string) => {
  return await axios
    .post(`${apiUrl}/Player`, { name: name }, getConfig())
    .then(handleResponse)
    .catch(handleError);
};

export const getPlayers = async () => {
  return await axios
    .get(`${apiUrl}/Player`, getConfig())
    .then(handleResponse)
    .catch(handleError);
};

export const getShipList = async () => {
  return await axios
    .get(`${apiUrl}/Player/ShipList`, getConfig())
    .then(handleResponse)
    .catch(handleError);
};

export const getPlayerShootStatus = async (params: any) => {
  return await axios
    .get(`${apiUrl}/Player/ShootStatus`, getConfigWithParams(params))
    .then(handleResponse)
    .catch(handleError);
};
