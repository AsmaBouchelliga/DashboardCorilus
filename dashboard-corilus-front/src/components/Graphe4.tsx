import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";
import { ApexOptions } from "apexcharts";
import { Card, CardHeader, CardBody } from "reactstrap";
import { Icon } from "@iconify/react";
import axios from "../config/axios";
import "../assets/css/graphe1.css";

interface TotalSessionRevenueDto {
  type_b: string;
  total_a_facturer: number;
}

interface UserProps {
  currentUser: string;
  period: number;
  refreshing: number;
  moveUpOrDown: () => void;
}

const Graphe4: React.FC<UserProps> = (props) => {
  const {
    currentUser = "63c0579b-a9b7-4c00-bb4a-a5ed00fb2b58",
    period = 30,
    refreshing = 0,
    moveUpOrDown,
  } = props;

  const [labels, setLabels] = useState<string[]>(["Autres", "Mutuelle", "Patient"]);
  const [colors, setColors] = useState(["#ff8042", "#0088fe", "#00c49f"]);
  const [sessionData, setSessionData] = useState<number[]>([0, 0, 0]);
  const [totalRevenue, setTotalRevenue] = useState<number>(0);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const endDate = new Date();
    const startDate = new Date();
    startDate.setDate(endDate.getDate() - period);

    fetchData(currentUser, startDate, endDate);
  }, [refreshing]);

  const fetchData = async (selectedUserId: string, startDate: Date, endDate: Date) => {
    try {
      setLoading(true);
      console.log(`Fetching data for user: ${selectedUserId}, from: ${startDate} to: ${endDate}`);
      const response = await axios.get<TotalSessionRevenueDto[]>(
        `https://localhost:7232/api/PaymentRevenue/total-session-revenue/${selectedUserId}`,
        {
          params: {
            startDate: startDate.toISOString(),
            endDate: endDate.toISOString(),
          },
        }
      );

      if (response?.status === 200 && response.data) {
        const items: TotalSessionRevenueDto[] = response.data;

        console.log("Data fetched successfully:", items);

        const labelsHolder: string[] = [];
        const sessionDataHolder: number[] = [];

        items.forEach(item => {
          console.log("Processing item:", item);
          if (item.type_b && item.total_a_facturer !== undefined) {
            labelsHolder.push(item.type_b);
            sessionDataHolder.push(item.total_a_facturer);
          } else {
            console.error("Invalid item in response:", item);
          }
        });

        setLabels(labelsHolder);
        setSessionData(sessionDataHolder);
        setTotalRevenue(sessionDataHolder.reduce((acc, curr) => acc + curr, 0));
      } else {
        console.error("Failed to fetch data, response status:", response?.status);
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setLoading(false);
    }
  };

  const options: ApexOptions = {
    series: [
      {
        name: "Total à facturer",
        data: sessionData,
      }
    ],
    chart: {
      type: "bar",
      height: 350,
    },
    plotOptions: {
      bar: {
        horizontal: false,
        columnWidth: "55%",
      },
    },
    dataLabels: {
      enabled: false,
    },
    stroke: {
      show: true,
      width: 2,
      colors: ["transparent"],
    },
    xaxis: {
      categories: labels,
    },
    fill: {
      opacity: 1,
    },
    tooltip: {
      y: {
        formatter: (val) => `€ ${val}`,
      },
    },
  };

  const optionsPie: ApexOptions = {
    legend: {
      show: true,
      position: "bottom",
    },
    labels: labels,
    series: sessionData,
    colors: colors,
    dataLabels: {
      enabled: true,
      formatter: (val) => `${parseInt(val.toString())}%`,
    },
    plotOptions: {
      pie: {
        customScale: 0.8,
      },
    },
    responsive: [
      {
        breakpoint: 992,
        options: {
          chart: {
            height: 380,
          },
          legend: {
            position: "bottom",
          },
        },
      },
      {
        breakpoint: 576,
        options: {
          chart: {
            height: 320,
          },
          plotOptions: {
            pie: {
              donut: {
                labels: {
                  show: true,
                  name: {
                    fontSize: "1.5rem",
                  },
                  value: {
                    fontSize: "1rem",
                  },
                  total: {
                    fontSize: "1.5rem",
                  },
                },
              },
            },
          },
        },
      },
    ],
  };

  useEffect(() => {
    console.log("Session Data:", sessionData);
    console.log("Labels:", labels);
  }, [sessionData, labels]);

  return (
    <Card>
      <CardHeader className="text-left">
        <div className="d-flex justify-content-between">
          <div>Total des sessions/attestations à facturer : {totalRevenue} €</div>
          <div>
            <Icon
              icon="typcn:pin"
              width="30"
              height="30"
              style={{ color: "#707070" }}
              onClick={moveUpOrDown}
            />
            <Icon
              icon="material-symbols:info"
              width="30"
              height="30"
              style={{ color: "#1ba796" }}
            />
            <Icon
              icon="mingcute:time-fill"
              width="30"
              height="30"
              style={{ color: "#707070" }}
            />
          </div>
        </div>
      </CardHeader>
      <CardBody className="pb-0">
        <div className="d-flex justify-content-between align-items-center">
          <div className="custom-top-padding-7 custom-left-padding-7">
            <div className="custom-bottom-padding-2">
              <Icon icon="bi:receipt" width="20" height="20" />
              <a href="/path/to/mutuelle" className="ml-2">Créer facture mutuelle</a>
              <div>Montant total à facturer : {sessionData[labels.indexOf("Mutuelle")]} €</div>
              <div>Nombre de sessions et attestations à facturer : 25</div>
            </div>
            <div className="custom-bottom-padding-2">
              <Icon icon="bi:receipt" width="20" height="20" />
              <a href="/path/to/patient" className="ml-2">Créer facture patient</a>
              <div>Montant total à facturer : {sessionData[labels.indexOf("Patient")]} €</div>
              <div>Nombre de sessions et attestations à facturer : 9</div>
            </div>
            <div className="custom-bottom-padding-2">
              <Icon icon="bi:receipt" width="20" height="20" />
              <a href="/path/to/autres" className="ml-2">Créer facture autres</a>
              <div>Montant total à facturer : {sessionData[labels.indexOf("Autres")]} €</div>
              <div>Nombre de sessions et attestations à facturer : 11</div>
            </div>
          </div>
          <div className="d-flex flex-wrap" style={{ width: "50%" }}>
            <div style={{ height: "401px", width: "50%" }}>
              <Chart
                options={optionsPie}
                series={optionsPie.series}
                type="pie"
                height={400}
              />
            </div>
            <div style={{ height: "401px", width: "50%" }}>
              <Chart
                options={options}
                type="bar"
                series={options.series}
                height={400}
              />
            </div>
          </div>
        </div>
      </CardBody>
    </Card>
  );
};

export default Graphe4;
