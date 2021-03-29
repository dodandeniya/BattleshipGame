import { environment as envDev } from "../../../environments/environment";
import { environment as envProd } from "../../../environments/environment.prod";

export const getConfig = () => {
  return {
    headers: {
      "Content-Type": "application/json",
    },
  };
};

export const getConfigWithParams = (params: any) => {
  return {
    headers: {
      "Content-Type": "application/json",
    },
    params: params,
  };
};

export const apiUrl =
  process.env.NODE_ENV === "production"
    ? envProd.battleshipServiceURL
    : envDev.battleshipServiceURL;
