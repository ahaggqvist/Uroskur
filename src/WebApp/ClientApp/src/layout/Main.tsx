import React, { FC } from "react";
import { useUserService } from "../providers/UserServiceProvider";

const Main: FC = () => {
  const userService = useUserService();

  const onClickHandler = async (
    event: React.MouseEvent<HTMLElement>
  ): Promise<void> => {
    event.preventDefault();
    window.location.href = `${process.env.REACT_APP_API_URL}Auth/Login`;
  };

  return (
    <>
      <article className="uk-article uk-margin-small-top">
        <h1 className="uk-article-title uk-text-uppercase uk-text-light">
          Uroskur
        </h1>
        <p className="uk-article-meta">
            Display the weather conditions along your Strava routes to make every bike ride or run enjoyable (or atleast make them suck less!).
        </p>
        {userService.user() ? (
          <div />
        ) : (
          <>
            <img
              className="pointer-button"
              onClick={onClickHandler}
              src="/btn_google_signin_light_normal_web.png"
              width="191"
              height="46"
              alt="Sign in with Google"
            />
          </>
        )}
      </article>
    </>
  );
};

export default Main;
