import axios from "axios";
import {DateTime} from "luxon";
import {ChangeEvent, FC, useCallback, useEffect, useState} from "react";
import {useHistory} from "react-router-dom";
import TimePicker from "react-time-picker";
import {useUserService} from "../../providers/UserServiceProvider";
import {ILocation, IOption, IProps, IRoute} from "../Shared/Definitions";
import RouteList from "./RouteList";
import RouteListFooter from "./RouteListFooter";
import Charts from "./Charts";

const RouteWeather: FC<IProps> = ({onProgressHandler}) => {
    const userService = useUserService();
    const history = useHistory();

    const [locations, setLocations] = useState<ILocation[] | undefined>([]);
    const [route, setRoute] = useState("0");
    const [routes, setRoutes] = useState<IRoute[] | undefined>([]);
    const [speed, setSpeed] = useState("30");
    const [day, setDay] = useState("");

    const [days, setDays] = useState<IOption[]>([]);
    const [startTime, setStartTime] = useState("");
    const [minTime, setMinTime] = useState("00:00:00");
    const [forecastDates, setForecastDates] = useState("");

    const fetchRoutesCallback = useCallback(
        async (athleteId: number) => {
            const url = `${process.env.REACT_APP_API_URL}Strava/Routes`;
            const params = {params: {athleteId: athleteId}};
            try {
                onProgressHandler(false);
                return await axios.get<IRoute[]>(url, params);
            } catch (error) {
                history.replace("/");
                history.push(`${process.env.PUBLIC_URL}`);
            } finally {
                onProgressHandler(true);
            }
        },
        [history, onProgressHandler]
    );

    const fetchLocationsCallback = useCallback(
        async (routeId: string, athleteId: number) => {
            const url = `${process.env.REACT_APP_API_URL}Forecast/Forecast`;
            const params = {params: {routeId: routeId, athleteId: athleteId}};
            try {
                onProgressHandler(false);
                return await axios.get<ILocation[]>(url, params);
            } catch (error) {
                history.replace("/");
                history.push(`${process.env.PUBLIC_URL}`);
            } finally {
                onProgressHandler(true);
            }
        },
        [history, onProgressHandler]
    );

    const onRouteChangeHandler = async (
        event: ChangeEvent<HTMLSelectElement>
    ) => {
        event.preventDefault();
        setRoute(event.target.value);
        const athleteId = userService.user()?.athlete_id;
        if (athleteId) {
            const locationsResponse = await fetchLocationsCallback(
                event.target.value,
                athleteId
            );
            setLocations(locationsResponse?.data);
        }
    };

    const onSpeedChangeHandler = (event: ChangeEvent<HTMLSelectElement>) => {
        event.preventDefault();
        setSpeed(event.target.value);
    };

    const onDayChangeHandler = (event: ChangeEvent<HTMLSelectElement>) => {
        event.preventDefault();
        setDay(event.target.value);
    };

    const onStartTimeChangeHandler = (value: any) => {
        if (value != null) {
            if (day === days[0].value) {
                const hour = Number(value.substring(0, 2));
                if (hour < Number(minTime)) {
                    setStartTime(`${minTime}:00`);
                } else {
                    setStartTime(value);
                }
            } else {
                setStartTime(value);
            }
        }
    };

    useEffect(() => {
        (async () => {
            const user = userService.user();
            const athleteId = user?.athlete_id;
            if (athleteId) {
                const routesResponse = await fetchRoutesCallback(athleteId);
                if (routesResponse?.status === 200) {
                    if (routesResponse.data.length > 0) {
                        setRoutes(routesResponse.data);

                        const locationsResponse = await fetchLocationsCallback(
                            String(routesResponse.data[0].id),
                            athleteId
                        );
                        setLocations(locationsResponse?.data);

                        if (locationsResponse?.data.length > 0) {
                            let dtLocation = DateTime.fromSeconds(
                                locationsResponse?.data[0].hourly[0].dt
                            )
                                .setZone(user?.timezone)
                                .setLocale(user?.locale);

                            setDays([
                                {label: "Today", value: dtLocation.toFormat("yyyyMMdd")},
                                {
                                    label: "Tomorrow",
                                    value: dtLocation.plus({days: 1}).toFormat("yyyyMMdd"),
                                },
                            ]);

                            setMinTime(dtLocation.toFormat("HH"));
                            setStartTime(dtLocation.toFormat("T"));
                            setDay(dtLocation.toFormat("yyyyMMdd"));

                            const forecastStart = dtLocation.toFormat("ccc d LLL T");
                            setForecastDates(`OpenWeather Forecast Issued at ${forecastStart}`)
                        }
                    }
                }
            }
        })();
    }, [
        onProgressHandler,
        userService,
        fetchRoutesCallback,
        fetchLocationsCallback,
    ]);

    return (
        <>
            {userService.user() ? (
                <>
                    <article className="uk-article uk-margin-small-top">
                        <h1 className="uk-article-title uk-text-uppercase uk-text-light">
                            Weather
                        </h1>
                        <div className="uk-section">
                            <form className="uk-form-stacked uk-text-uppercase uk-text-light">
                                <div className="uk-grid">
                                    <div className="uk-width-auto">
                                        <label className="uk-form-label">Routes</label>
                                        <select
                                            className="uk-select"
                                            onChange={onRouteChangeHandler}
                                            value={route}
                                        >
                                            {routes
                                                ?.sort((r1, r2) => r1.name.localeCompare(r2.name))
                                                .map((r) => (
                                                    <option key={r.id} value={r.id}>
                                                        {r.name}
                                                    </option>
                                                ))}
                                        </select>
                                    </div>
                                    <div className="uk-width-auto">
                                        <label className="uk-form-label">Km/h</label>
                                        <select
                                            className="uk-select"
                                            onChange={onSpeedChangeHandler}
                                            value={speed}
                                        >
                                            <option value="20">10</option>
                                            <option value="20">20</option>
                                            <option value="30">30</option>
                                            <option value="40">40</option>
                                            <option value="50">50</option>
                                        </select>
                                    </div>
                                    <div className="uk-width-auto">
                                        <label className="uk-form-label">Day</label>
                                        <select
                                            className="uk-select"
                                            onChange={onDayChangeHandler}
                                            value={day}
                                        >
                                            {days.map((d, index) => (
                                                <option key={index} value={d.value}>
                                                    {d.label}
                                                </option>
                                            ))}
                                        </select>
                                    </div>
                                    <div className="uk-width-auto">
                                        <label className="uk-form-label">Time</label>
                                        <TimePicker
                                            className="uk-input uk-form-controls"
                                            clearIcon={null}
                                            format={"HH:mm"}
                                            locale={"sv-SE"}
                                            maxDetail={"hour"}
                                            disableClock={true}
                                            onChange={onStartTimeChangeHandler}
                                            value={startTime}
                                        />
                                    </div>
                                </div>
                            </form>
                            <p className="uk-text-meta">
                                {forecastDates}
                            </p>
                            <div className="uk-card uk-card-default uk-card-body uk-margin-small-top">
                                <RouteList
                                    locations={locations}
                                    startTime={startTime}
                                    speed={Number(speed)}
                                    day={day}
                                />
                            </div>
                            <RouteListFooter/>
                        </div>
                    </article>

                        <Charts locations={locations}
                                startTime={startTime}
                                speed={Number(speed)}
                                day={day}/>

                </>
            ) : (
                <div/>
            )}
        </>
    );
};

export default RouteWeather;
