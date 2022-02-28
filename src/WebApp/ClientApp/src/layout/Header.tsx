import { Link } from "react-router-dom";
import React, { FC } from "react";
import { useUserService } from "../providers/UserServiceProvider";
import axios from "axios";

const Header: FC = () => {
  const userService = useUserService();

  const onClickHandler = async (
    event: React.MouseEvent<HTMLElement>
  ): Promise<void> => {
    event.preventDefault();

    try {
      await axios.post(`${process.env.REACT_APP_API_URL}Auth/Logout`);
    } catch (error) {
      // Ignore
    } finally {
      window.location.href = `${process.env.PUBLIC_URL}`;
    }
  };

  return (
    <div className="uk-container uk-container-expand">
      <nav className="uk-navbar" role="navigation" aria-label="main navigation">
        <div className="uk-navbar-left">
          <Link to="/">
            <img alt="logotype" src="logo.svg" width="28" height="28" />
          </Link>
        </div>

        <div className="uk-navbar-right">
          <ul className="uk-navbar-nav">
            <li>
              <Link to={userService.user() ? "/route-weather" : "#"}>
                Weather
              </Link>
            </li>
            <li>
              <Link to={userService.user() ? "/settings" : "#"}>Settings</Link>
            </li>
            <li>
              {userService.user() ? (
                <a href="#" onClick={onClickHandler}>
                  Log out
                </a>
              ) : (
                <></>
              )}
            </li>
          </ul>
        </div>
      </nav>
    </div>
  );
};

export default Header;
