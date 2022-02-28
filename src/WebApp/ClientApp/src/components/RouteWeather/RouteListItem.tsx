import { DateTime } from "luxon";
import { FC } from "react";
import { useUserService } from "../../providers/UserServiceProvider";
import { ILocation } from "../Shared/Definitions";

type TProps = {
  location: ILocation;
  index: number;
  startTime: string;
  speed: number;
  day: string;
};

const RouteListItem: FC<TProps> = ({
  location,
  index,
  startTime,
  speed,
  day,
}) => {
  const userService = useUserService();
  const user = userService?.user();

  let dt = DateTime.fromFormat(`${day} ${startTime}`, "yyyyMMdd HH:mm")
    .set({ minute: 0 })
    .setZone(user?.timezone);
  let unixTime = Math.floor(dt.toMillis() / 1000);

  const km = index * 10 + 10;
  const time = km / speed;
  const seconds = 3600 * time + unixTime;

  dt = DateTime.fromSeconds(seconds).startOf("hour");
  unixTime = Math.floor(dt.toMillis() / 1000);

  const hourly = location.hourly.find((x) => x.dt === unixTime);
  const temp = hourly?.temp;
  const feelsLike = hourly?.feels_like;
  const windSpeed = hourly?.wind_speed;
  const iconId = hourly?.weather[0]?.id;
  const weatherIcon = `wi wi-owm-${iconId}`;
  const windIcon = `wi wi-wind towards-${hourly?.wind_deg}-deg`;

  return (
    <>
      {
        <tr className="uk-text-center" key={index.toString()}>
          <td>{`${km} (${DateTime.fromSeconds(seconds)
            .setZone(user.timezone)
            .setLocale(user.locale)
            .toFormat("ccc dd LLL T")})`}</td>
          <td>{temp}</td>
          <td>{feelsLike}</td>
          <td>
            {windSpeed} <i className={windIcon}></i>
          </td>
          <td>
            <i className={weatherIcon}></i>
          </td>
        </tr>
      }
    </>
  );
};

export default RouteListItem;
