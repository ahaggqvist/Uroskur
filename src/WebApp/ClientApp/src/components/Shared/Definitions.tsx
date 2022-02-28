import { TextBlock } from "react-placeholder/lib/placeholders";

export interface IProps {
  onProgressHandler: (hasFinished: boolean) => void;
}

export interface ILocation {
  lat: string;
  lon: string;
  timezone: string;
  timezone_offset: string;
  hourly: {
    dt: number;
    feels_like: number;
    temp: number;
    uvi: number;
    wind_speed: number;
    wind_deg: number;
    weather: [
      {
        id: number;
        main: string;
        description: string;
        icon: number;
      }
    ];
  }[];
  current: {
    temp: number;
    uvi: number;
    feels_like: number;
    wind_speed: number;
    wind_deg: number;
    weather: [
      {
        id: number;
        main: string;
        description: string;
        icon: number;
      }
    ];
  };
}

export interface IOption {
  label: string;
  value: string;
}

export interface ISubscription {
  id: number;
  resource_state: number;
  application_id: number;
  callback_url: string;
  created_at: string;
  updated_at: string;
}

export interface IRoute {
  id: number;
  name: string;
}

export const customPlaceholder = (
  <div className="custom-placeholder">
    <TextBlock lineSpacing={25} widths={[100]} rows={100} color="#e4e5e4" />
  </div>
);

export type TUser = {
  display_name: string | undefined;
  mail: string | undefined;
  athlete_id: number | undefined;
  client_id: string | undefined;
  locale: string | undefined;
  timezone: string | undefined;
};
