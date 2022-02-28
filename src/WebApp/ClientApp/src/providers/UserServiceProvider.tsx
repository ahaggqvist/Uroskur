import {
  createContext,
  useCallback,
  useContext,
  useEffect,
  useState,
} from "react";
import axios from "axios";
import { TUser } from "../components/Shared/Definitions";
import { useHistory } from "react-router-dom";

export interface IUserService {
  user(): TUser;
}

export const useUserService = () => useContext(UserServiceContext);

const UserServiceContext = createContext<IUserService | undefined>(undefined);

const UserServiceProvider = ({ children }: any) => {
  const [user, setUser] = useState(null);
  const history = useHistory();

  const fetchUser = useCallback(async (): Promise<TUser> => {
    const url = `${process.env.REACT_APP_API_URL}Auth/UserInfo`;
    try {
      const response = await axios.get<TUser>(url);
      return {
        display_name: response?.data.display_name,
        mail: response?.data.mail,
        athlete_id: response?.data.athlete_id,
        client_id: response?.data.client_id,
        locale: response?.data.locale,
        timezone: response?.data.timezone,
      };
    } catch (error) {
      history.replace("/");
      history.push(`${process.env.PUBLIC_URL}`);
    }
  }, [history]);

  useEffect(() => {
    (async () => {
      setUser(await fetchUser());
    })();
  }, [fetchUser]);

  return (
    <>
      <UserServiceContext.Provider
        value={{
          user: (): TUser => {
            return user;
          },
        }}
      >
        {children}
      </UserServiceContext.Provider>
    </>
  );
};

export default UserServiceProvider;
