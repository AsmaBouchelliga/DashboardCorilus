import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";
import { ApexOptions } from "apexcharts";
import { Card, CardHeader, CardBody } from "reactstrap";
import { Icon } from "@iconify/react/dist/iconify.js";
import axios from "../config/axios";
import "../assets/css/graphe1.css";

interface ApiResponseDto {
  type_b: string;
  chiffre_Affaire: number;
}

interface RevenueByPayerDto {
  Type_b: string;
  Chiffre_Affaire: number;
}

interface UserProps {
  currentUser: string;
  period: number;
  refreshing: number;
  moveUpOrDown: () => void;
}

const Graphe1: React.FC<UserProps> = (props) => {
  const {
    currentUser = "63c0579b-a9b7-4c00-bb4a-a5ed00fb2b58",
    period = 300,
    refreshing = 0,
  } = props;

  const [labels, setLabels] = useState<string[]>([]);
  const [colors, setColors] = useState(["#ff8042", "#0088fe", "#00c49f"]);
  const [salesData, setSalesData] = useState<number[]>([]);
  const [totalSales, setTotalSales] = useState<number>(0);
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
      const response = await axios.get<ApiResponseDto[]>(
        `https://localhost:7232/api/PaymentRevenue/revenue-by-payer/${selectedUserId}`,
        {
          params: {
            startDate: startDate.toISOString(),
            endDate: endDate.toISOString(),
          },
        }
      );

      if (response?.status === 200 && response.data) {
        const items: RevenueByPayerDto[] = response.data.map((item) => ({
          Type_b: item.type_b,
          Chiffre_Affaire: item.chiffre_Affaire,
        }));

        console.log("Data fetched successfully:", items);

        const labelsHolder: string[] = [];
        const salesDataHolder: number[] = [];

        items.forEach((item) => {
          if (item.Type_b && item.Chiffre_Affaire !== undefined) {
            labelsHolder.push(item.Type_b);
            salesDataHolder.push(item.Chiffre_Affaire);
          } else {
            console.error("Invalid item in response:", item);
          }
        });

        setLabels(labelsHolder);
        setSalesData(salesDataHolder);
        setTotalSales(salesDataHolder.reduce((acc, curr) => acc + curr, 0));
      } else {
        console.error("Failed to fetch data, response status:", response?.status);
      }
    } catch (error) {
      console.error("Error fetching data:", error);
    } finally {
      setLoading(false);
    }
  };

  const handlePrint = () => {
    window.print();
  };

  const options: ApexOptions = {
    series: [
      {
        name: "Chiffre d'affaires",
        data: salesData,
      },
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
    series: salesData,
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
    console.log("Sales Data:", salesData);
    console.log("Labels:", labels);
  }, [salesData, labels]);

  return (
    <Card>
      <CardHeader className="text-left">
        <div className="d-flex justify-content-between">
          <div>Total des chiffres d'affaires : {totalSales} €</div>
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
        <div className="d-flex justify-content-between">
          <div className="custom-top-padding-7 custom-left-padding-7">
            {loading ? (
              <div>Loading...</div>
            ) : (
              salesData.map((amount, index) => (
                <div key={index} className="custom-bottom-padding-2">
                  {labels[index]} : {amount}€
                </div>
              ))
            )}
            <button className="btn btn-outline-dark" onClick={handlePrint}>
              Imprimer la liste des attestations
            </button>
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

export default Graphe1;
