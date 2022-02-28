import axios from "axios";
import { FC, useCallback, useEffect, useState } from "react";
import { useHistory } from "react-router-dom";
import { useUserService } from "../../providers/UserServiceProvider";
import { IProps, ISubscription } from "../Shared/Definitions";
import SettingDetails from "./SettingDetails";

const Settings: FC<IProps> = ({ onProgressHandler }) => {
  const history = useHistory();
  const userService = useUserService();
  const [subscription, setSubscription] = useState<ISubscription | undefined>();
  const [counter, setCounter] = useState<number>(0);

  const reRender = () => {
    setCounter((value) => value + 1);
  };

  const fetchSubscriptionCallback = useCallback(async () => {
    const url = `${process.env.REACT_APP_API_URL}Strava/ViewSubscription`;
    try {
      onProgressHandler(false);
      return await axios.get<ISubscription>(url);
    } catch (error) {
      history.replace("/");
      history.push(`${process.env.PUBLIC_URL}`);
    } finally {
      onProgressHandler(true);
    }
  }, [history, onProgressHandler]);

  useEffect(() => {
    (async () => {
      const response = await fetchSubscriptionCallback();
      setSubscription(response?.data);
    })();
  }, [fetchSubscriptionCallback, counter]);

  return (
    <>
      {userService.user() ? (
        <article className="uk-article uk-margin-small-top">
          <h1 className="uk-article-title uk-text-uppercase uk-text-light">
            Settings
          </h1>
          <SettingDetails
            user={userService.user()}
            subscription={subscription}
            onProgressHandler={onProgressHandler}
            reRender={reRender}
          />
        </article>
      ) : (
        <div />
      )}
    </>
  );
};

export default Settings;
