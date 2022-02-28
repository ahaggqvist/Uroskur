import { FC, useRef } from "react";
import Footer from "./Footer";
import Main from "./Main";
import Header from "./Header";
import LoadingBar from "react-top-loading-bar";
import { Route, Switch } from "react-router-dom";
import RouteWeather from "../components/RouteWeather/RouteWeather";
import Settings from "../components/Settings/Settings";

const Layout: FC = () => {
  const loadingBarRef = useRef(null);
  const onProgressHandler = (hasFinished: boolean): void => {
    // @ts-ignore
    hasFinished
      ? loadingBarRef.current.complete()
      : loadingBarRef.current.continuousStart();
  };

  return (
    <>
      <Header />
      <div className="uk-container uk-container-small">
        <LoadingBar color="#000" ref={loadingBarRef} />
        <Switch>
          <Route path="/route-weather">
            <RouteWeather onProgressHandler={onProgressHandler} />
          </Route>
          <Route path="/settings">
            <Settings onProgressHandler={onProgressHandler} />
          </Route>
          <Route path="/*">
            <Main />
          </Route>
        </Switch>
      </div>
      <Footer />
    </>
  );
};

export default Layout;
