import { IOption, ISubscription, TUser } from "../Shared/Definitions";
import React, {
  ChangeEvent,
  FC,
  useCallback,
  useEffect,
  useState,
} from "react";
import axios from "axios";
import { toast } from "react-hot-toast";
import { useHistory } from "react-router-dom";
import TimezoneSelect, { ITimezoneOption } from "react-timezone-select";
import { DateTime } from "luxon";

interface IProps {
  user: TUser;
  onProgressHandler: (hasFinished: boolean) => void;
  subscription: ISubscription;
  reRender: () => void;
}

interface ISetting {
  clientId: string;
  clientSecret: string;
  appId: string;
}

const SettingDetails: FC<IProps> = ({
  user,
  subscription,
  onProgressHandler,
  reRender,
}) => {
  const history = useHistory();

  const notifySuccess = (message: string = "Save successful") =>
    toast.success(message, {
      position: "bottom-right",
    });
  const notifyError = (message: string = "Save failed") =>
    toast.error(message, {
      position: "bottom-right",
    });
  const [clientId, setClientId] = useState("");
  const [clientSecret, setClientSecret] = useState("");
  const [appId, setAppId] = useState("");
  const [timezone, setTimezone] = useState<ITimezoneOption>({
    value: "Europe/Amsterdam",
    label: "",
  });
  const [locale, setLocale] = useState<string>("en");

  const fetchSettingsCallback = useCallback(async () => {
    const url = `${process.env.REACT_APP_API_URL}Setting/Settings`;
    try {
      onProgressHandler(false);
      return await axios.get<ISetting>(url);
    } catch (error) {
      history.replace("/");
      history.push(`${process.env.PUBLIC_URL}`);
    } finally {
      onProgressHandler(true);
    }
  }, [history, onProgressHandler]);

  const onClickHandler = async (
    event: React.MouseEvent<HTMLElement>
  ): Promise<void> => {
    event.preventDefault();
    window.location.href = `https://www.strava.com/oauth/authorize?client_id=${clientId}&response_type=code&redirect_uri=${process.env.REACT_APP_API_URL}Strava/TokenExchange/${user.mail}?approval_prompt=force&scope=read_all`;
  };

  const onSubmitHandler = async (
    event: React.SyntheticEvent
  ): Promise<void> => {
    event.preventDefault();

    if (!/^\d+$/.test(clientId)) {
      toast.error("Client ID must be a positive number", {
        position: "bottom-right",
      });
      return;
    }

    const url = `${process.env.REACT_APP_API_URL}Setting/Settings`;
    try {
      onProgressHandler(false);
      await axios.post(url, {
        clientId: clientId,
        clientSecret: clientSecret,
        appId: appId,
      });
      notifySuccess();
    } catch (error) {
      notifyError();
    } finally {
      onProgressHandler(true);
    }
  };

  const onClientIdChangeHandler = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    setClientId(event.target.value);
  };

  const onClientSecretChangeHandler = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    setClientSecret(event.target.value);
  };

  const onAppIdChangeHandler = (event: React.ChangeEvent<HTMLInputElement>) => {
    setAppId(event.target.value);
  };

  const onDeleteClickHandler = async (
    event: React.MouseEvent<HTMLElement>
  ): Promise<void> => {
    event.preventDefault();
    const url = `${process.env.REACT_APP_API_URL}Strava/DeleteSubscription`;
    try {
      await axios.get(url);
      reRender();
      notifySuccess("Deleted successful");
    } catch (e) {
      notifyError("Delete failed");
    }
  };

  const onCreateClickHandler = async (
    event: React.MouseEvent<HTMLElement>
  ): Promise<void> => {
    event.preventDefault();
    const url = `${process.env.REACT_APP_API_URL}Strava/CreateSubscription`;
    try {
      await axios.get(url);
      reRender();
      notifySuccess("Create successful");
    } catch (e) {
      notifyError("Create failed");
    }
  };

  const onLocaleChangeHandler = (event: ChangeEvent<HTMLSelectElement>) => {
    event.preventDefault();
    setLocale(event.target.value);
  };

  useEffect(() => {
    if (user.client_id) {
      setClientId(user.client_id);
    }
  }, [user, subscription]);

  useEffect(() => {
    (async () => {
      const response = await fetchSettingsCallback();
      if (response) {
        setClientId(response.data.clientId);
        setClientSecret(response.data.clientSecret);
        setAppId(response.data.appId);
      }
    })();
  }, [fetchSettingsCallback]);

  return (
    <>
      <form
        className="uk-form-stacked uk-text-uppercase uk-text-light"
        onSubmit={onSubmitHandler}
      >
        <div>
          <label className="uk-form-label">Google name</label>
          <input
            className="uk-input uk-form-controls"
            type="text"
            value={user.display_name == null ? "" : user.display_name}
            disabled
          />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">Google mail</label>
          <input
            className="uk-input uk-form-controls"
            type="text"
            value={user.mail == null ? "" : user.mail}
            disabled
          />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">Strava athlete ID</label>
          <input
            className="uk-input uk-form-controls"
            type="text"
            value={user.athlete_id == null ? "" : user.athlete_id}
            disabled
          />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">Strava client ID</label>
          <input
            className="uk-input uk-form-controls"
            type="text"
            value={clientId}
            onChange={onClientIdChangeHandler}
          />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">Strava client secret</label>
          <input
            className="uk-input uk-form-controls"
            type="text"
            value={clientSecret}
            onChange={onClientSecretChangeHandler}
          />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">OpenWeather app ID</label>
          <input
            className="uk-input uk-form-controls"
            type="text"
            value={appId}
            onChange={onAppIdChangeHandler}
          />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">Timezone</label>
          <TimezoneSelect value={timezone} onChange={setTimezone} />
        </div>
        <div className="uk-margin-small-top">
          <label className="uk-form-label">Locale</label>
          <select
            className="uk-select uk-text-uppercase uk-text-light"
            value={locale}
            onChange={onLocaleChangeHandler}
          >
            <option value="en">English</option>
            <option value="sv">Swedish</option>
          </select>
        </div>
        <button
          className="uk-button uk-button-default uk-margin-medium-top"
          type="submit"
        >
          Save
        </button>
      </form>

      {user.athlete_id || !clientId ? (
        <></>
      ) : (
        <article className="uk-margin-medium-top uk-article">
          <div className="uk-article-meta">
            Connect with your API Application
            <br />
            <div style={{ marginLeft: "-5px" }}>
              <img
                className="pointer-button"
                onClick={onClickHandler}
                src="/btn_strava_connectwith_light.png"
                alt="Connect with Strava button"
              />
            </div>
          </div>
        </article>
      )}

      <article className="uk-article uk-margin-medium-top">
        <div className="uk-section">
          <form className="uk-form-stacked uk-text-uppercase uk-text-light">
            <div>
              <label className="uk-form-label">Strava subscription ID</label>
              <input
                className="uk-input uk-form-controls"
                type="text"
                value={subscription?.id == null ? "" : subscription?.id}
                disabled
              />
            </div>
            <div className="uk-margin-small-top">
              <label className="uk-form-label">
                Strava subscription Created At
              </label>
              <input
                className="uk-input uk-form-controls"
                type="text"
                value={
                  subscription?.created_at == null ? "" : DateTime.fromISO(subscription?.created_at).toFormat("yyyy-MM-dd HH:mm")
                }
                disabled
              />
            </div>
            <div className="uk-margin-small-top">
              <label className="uk-form-label">
                Strava subscription Updated At
              </label>
              <input
                className="uk-input uk-form-controls"
                type="text"
                value={
                  subscription?.updated_at == null ? "" : DateTime.fromISO(subscription?.updated_at).toFormat("yyyy-MM-dd HH:mm")
                }
                disabled
              />
            </div>
            {subscription ? (
              <button
                className="uk-button uk-button-default uk-margin-medium-top"
                type="button"
                onClick={onDeleteClickHandler}
              >
                Delete subscription
              </button>
            ) : (
              <button
                className="uk-button uk-button-default uk-margin-medium-top"
                type="button"
                onClick={onCreateClickHandler}
              >
                Create subscription
              </button>
            )}
          </form>
        </div>
      </article>
    </>
  );
};

export default SettingDetails;
