import {FC} from "react";
import {ILocation} from "../Shared/Definitions";
import RouteListItem from "./RouteListItem";

type TProps = {
    locations?: ILocation[];
    startTime: string;
    speed: number;
    day: string;
};

const RouteList: FC<TProps> = ({locations, startTime, speed, day}) => {
    return (
        <table className="uk-table uk-table-divider">
            <thead>
            <tr>
                <th className="uk-text-center">time</th>
                <th className="uk-text-center">temperature (°C)</th>
                <th className="uk-text-center">feels like (°C)</th>
                <th className="uk-text-center">chance of rain (%)</th>
                <th className="uk-text-center">wind (m/s)</th>
                <th>&nbsp;</th>
            </tr>
            </thead>
            <tbody>
            {locations?.map((location, index) => (
                <RouteListItem
                    key={index}
                    location={location}
                    index={index}
                    startTime={startTime}
                    speed={speed}
                    day={day}
                />
            ))}
            </tbody>
        </table>
    );
};

export default RouteList;
