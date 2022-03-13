import {Line} from "react-chartjs-2";
import {
    CategoryScale,
    Chart as ChartJS,
    Filler,
    Legend,
    LinearScale,
    LineElement,
    PointElement,
    Title,
    Tooltip
} from 'chart.js';
import {ILocation} from "../Shared/Definitions";
import {DateTime} from "luxon";
import {useUserService} from "../../providers/UserServiceProvider";
import {FC} from "react";

ChartJS.register(
    CategoryScale,
    LinearScale,
    PointElement,
    LineElement,
    Title,
    Tooltip,
    Legend,
    Filler
);

type TProps = {
    locations?: ILocation[];
    startTime: string;
    speed: number;
    day: string;
};

const Charts: FC<TProps> = ({locations, startTime, speed, day}) => {
    const userService = useUserService();
    const user = userService?.user();
    const labels: string[] = [];
    const datasetTemp: number[] = [];
    const datasetFeelsLike: number[] = [];
    const datasetWind: number[] = [];
    const datasetUvi: number[] = [];
    const datasetPop: number[] = [];
    const datasetCloudiness: number[] = [];

    locations.forEach((l: ILocation, index) => {
        let dt = DateTime.fromFormat(`${day} ${startTime}`, "yyyyMMdd HH:mm")
            .set({minute: 0})
            .setZone(user?.timezone);
        let unixTime = Math.floor(dt.toMillis() / 1000);

        const km = index * 10 + 10;
        const time = km / speed;
        const seconds = 3600 * time + unixTime;

        dt = DateTime.fromSeconds(seconds).startOf("hour");
        unixTime = Math.floor(dt.toMillis() / 1000);

        const hourly = l.hourly.find((x) => x.dt === unixTime);
        const temp = Number(hourly?.temp.toFixed(1));
        const feelsLike = Number(hourly?.feels_like.toFixed(1));
        const windSpeed = Number(hourly?.wind_speed.toFixed(1));
        const datetime = DateTime.fromSeconds(seconds)
            .setZone(user.timezone)
            .setLocale(user.locale)
            .toFormat("T");
        const uvi = Math.round(hourly?.uvi);
        const pop = Math.round(hourly?.pop * 100);
        const cloudiness = hourly?.clouds;

        labels.push(datetime);
        datasetTemp.push(temp);
        datasetFeelsLike.push(feelsLike);
        datasetWind.push(windSpeed);
        datasetUvi.push(uvi);
        datasetPop.push(pop);
        datasetCloudiness.push(cloudiness)
    });


    const optionsTemp = {
        plugins: {
            filler: {
                propagate: false,
            },
            title: {
                display: true,
                text: 'TEMPERATURE',
                color: '#666',
                font: {
                    family: '-apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji"',
                    weight: 'lighter',
                    size: 14
                }
            },
            legend: {
                display: true,
            }
        },
        interaction: {
            intersect: false,
        },
        elements: {
            line: {
                tension: 0.3
            }
        }
    };

    const optionsWind = JSON.parse(JSON.stringify(optionsTemp));
    optionsWind.plugins.title.text = 'WIND';

    const optionsUvi = JSON.parse(JSON.stringify(optionsTemp));
    optionsUvi.plugins.title.text = 'UV';

    const optionsPop = JSON.parse(JSON.stringify(optionsTemp));
    optionsPop.plugins.title.text = 'CHANCE OF RAIN AND CLOUDINESS';

    const dataTemp = {
        labels,
        datasets: [
            {
                label: 'TEMPERATURE (°C)',
                data: datasetTemp,
                borderColor: 'rgb(254, 130, 77)',
                backgroundColor: 'rgba(254, 130, 77)',
                fill: false
            },
            {
                label: 'FEELS LIKE (°C)',
                data: datasetFeelsLike,
                borderColor: 'rgb(77, 201, 254)',
                backgroundColor: 'rgba(77, 201, 254)',
                fill: false
            }
        ],
    };

    const dataWind = {
        labels,
        datasets: [
            {
                label: 'WIND (M/S)',
                data: datasetWind,
                borderColor: 'rgb(254, 130, 77)',
                backgroundColor: 'rgba(254, 130, 77)',
                fill: false
            }
        ],
    };

    const dataPop = {
        labels,
        datasets: [
            {
                label: 'CHANCE OF RAIN (%)',
                data: datasetPop,
                borderColor: 'rgb(254, 130, 77)',
                backgroundColor: 'rgba(254, 130, 77)',
                fill: false
            },
            {
                label: 'CLOUDINESS (%)',
                data: datasetCloudiness,
                borderColor: 'rgb(77, 201, 254)',
                backgroundColor: 'rgba(77, 201, 254)',
                fill: false
            }
        ],
    };

    const dataUvi = {
        labels,
        datasets: [
            {
                label: 'UV INDEX',
                data: datasetUvi,
                borderColor: 'rgb(254, 130, 77)',
                backgroundColor: 'rgba(254, 130, 77)',
                fill: false
            }
        ],
    };

    return (
        <>
            <div className="uk-margin-large-bottom">
                <Line options={optionsTemp} data={dataTemp}/>
            </div>
            <div className="uk-margin-large-bottom">
                <Line options={optionsPop} data={dataPop}/>
            </div>
            <div className="uk-margin-large-bottom">
                <Line options={optionsWind} data={dataWind}/>
            </div>
            <div className="uk-margin-large-bottom">
                <Line options={optionsUvi} data={dataUvi}/>
            </div>
        </>
    )
};

export default Charts;