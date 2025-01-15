import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";
import { ApexOptions } from "apexcharts";
import { Card, CardHeader, CardBody } from "reactstrap";
import { Icon } from "@iconify/react";
import axios from "../config/axios";
import "../assets/css/graphe1.css";

interface BalanceByPayerDto {
  type_b: string;
  solde_du: number;
}

interface UserProps {
  currentUser: string;
  period: number;
  refreshing: number;
  moveUpOrDown: () => void;
}

const Graphe3: React.FC<UserProps> = (props) => {
  const {
    currentUser = "63c0579b-a9b7-4c00-bb4a-a5ed00fb2b58",
    period = 30,
    refreshing = 0,
  } = props;

  const [labels, setLabels] = useState<string[]>([]);
  const [colors, setColors] = useState(["#ff8042", "#0088fe", "#00c49f"]);
  const [balanceData, setBalanceData] = useState<number[]>([]);
  const [totalBalance, setTotalBalance] = useState<number>(0);
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
      const response = await axios.get<BalanceByPayerDto[]>(
        `https://localhost:7232/api/PaymentRevenue/balance-by-payer/${selectedUserId}`,
        {
          params: {
            startDate: startDate.toISOString(),
            endDate: endDate.toISOString(),
          },
        }
      );

      if (response?.status === 200 && response.data) {
        const items: BalanceByPayerDto[] = response.data;

        console.log("Data fetched successfully:", items);

        const labelsHolder: string[] = [];
        const balanceDataHolder: number[] = [];

        items.forEach(item => {
          console.log("Processing item:", item);
          if (item.type_b && item.solde_du !== undefined) {
            labelsHolder.push(item.type_b);
            balanceDataHolder.push(item.solde_du);
          } else {
            console.error("Invalid item in response:", item);
          }
        });

        setLabels(labelsHolder);
        setBalanceData(balanceDataHolder);
        setTotalBalance(balanceDataHolder.reduce((acc, curr) => acc + curr, 0));
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
        name: "Solde dû",
        data: balanceData,
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
    series: balanceData,
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
    console.log("Balance Data:", balanceData);
    console.log("Labels:", labels);
  }, [balanceData, labels]);

  return (
    <Card>
      <CardHeader className="text-left">
        <div className="d-flex justify-content-between">
          <div>Total des soldes du : {totalBalance} €</div>
          <div>
            <Icon
              icon="typcn:pin"
              width="30"
              height="30"
              style={{ color: "#707070" }}
              onClick={props.moveUpOrDown}
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
            {loading ? <div>Loading...</div> : balanceData.map((amount, index) => (
              <div key={index} className="custom-bottom-padding-2">
                {labels[index]} : {amount}€
                {labels[index] === "Mutuelle" && (
                  <a href="/path/to/mutuelle" className="ml-2">Aller vers Enregistrer paiement mutuelle</a>
                )}
                {labels[index] === "Patient" && (
                  <a href="/path/to/patient" className="ml-2">Aller vers Enregistrer paiement patient</a>
                )}
                {labels[index] === "Autres" && (
                  <a href="/path/to/autres" className="ml-2">Aller vers Enregistrer paiement autres</a>
                )}
              </div>
            ))}
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

export default Graphe3;
